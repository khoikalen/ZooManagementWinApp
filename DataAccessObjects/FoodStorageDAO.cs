using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class FoodStorageDAO
    {
        private static FoodStorageDAO instance = null;
        private static readonly object instanceLock = new object();

        private FoodStorageDAO() { }
        public static FoodStorageDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance=new FoodStorageDAO();
                    }
                }
                return instance;
            }
        }


        public List<FoodStorage> GetListFoodByType(String type)
        {
            var listFood = new List<FoodStorage>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                listFood = db.FoodStorages.Where(a=>a.Type == type).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return listFood;
        }
        public FoodStorage GetFoodInStorageById(int id)
        {
            var food = new FoodStorage();
            try
            {
                using var db = new ZooManagementDotNetContext();
                food = db.FoodStorages.SingleOrDefault(a => a.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
            return food;
        }


        public void AddNewFood(FoodStorage food)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                var check = db.FoodStorages.SingleOrDefault(a => a.Name == food.Name);
                if(check != null) 
                {
                    throw new Exception();
                }
                db.FoodStorages.Add(food);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


        public void UpdateFood(FoodStorage food)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
                db.FoodStorages.Update(food);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void DeleteFood(int id)
        {
            try
            {
                using var db = new ZooManagementDotNetContext();
               var food =  db.FoodStorages.SingleOrDefault(a => a.Id == id);
                db.FoodStorages.Remove(food);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<FoodStorage> GetFoodStorage()
        {
            var listFood = new List<FoodStorage>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                listFood = db.FoodStorages.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return listFood;
        }

/*        public List<string> GetFoodStorageType()
        {
            var listType = new List<string>();
            try
            {
                using var db = new ZooManagementDotNetContext();
                List<FoodStorage> listFood = db.FoodStorages.ToList();
                 listType = (List<string>)listFood.Select(a=> a.Type).Distinct();
            }
            catch (Exception)
            {
                throw;
            }
            return listType;
        }*/
    }
}
