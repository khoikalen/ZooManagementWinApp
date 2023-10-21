using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BusinessObjects
{
    public partial class ZooManagement_DotNetContext : DbContext
    {
        public ZooManagement_DotNetContext()
        {
        }

        public ZooManagement_DotNetContext(DbContextOptions<ZooManagement_DotNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<AnimalLog> AnimalLogs { get; set; }
        public virtual DbSet<AnimalSpecie> AnimalSpecies { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Cage> Cages { get; set; }
        public virtual DbSet<Expert> Experts { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodInMeal> FoodInMeals { get; set; }
        public virtual DbSet<FoodStorage> FoodStorages { get; set; }
        public virtual DbSet<LogType> LogTypes { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<SoldTicket> SoldTickets { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ZooManagement_DotNet; Uid=sa; Pwd=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");
            });

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.ToTable("animal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CageId).HasColumnName("cage_id");

                entity.Property(e => e.Dez)
                    .HasColumnType("date")
                    .HasColumnName("dez");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .HasColumnName("sex");

                entity.Property(e => e.Specie)
                    .HasMaxLength(255)
                    .HasColumnName("specie");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.CageId)
                    .HasConstraintName("FK__animal__cage_id__47DBAE45");
            });

            modelBuilder.Entity<AnimalLog>(entity =>
            {
                entity.ToTable("animal_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time");

                entity.Property(e => e.LogtypeId).HasColumnName("logtype_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Logtype)
                    .WithMany(p => p.AnimalLogs)
                    .HasForeignKey(d => d.LogtypeId)
                    .HasConstraintName("FK__animal_lo__logty__5070F446");
            });

            modelBuilder.Entity<AnimalSpecie>(entity =>
            {
                entity.ToTable("animal_specie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CageId).HasColumnName("cage_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.AnimalSpecies)
                    .HasForeignKey(d => d.CageId)
                    .HasConstraintName("FK__animal_sp__cage___4AB81AF0");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.ToTable("area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Cage>(entity =>
            {
                entity.ToTable("cage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.CageStatus)
                    .HasMaxLength(20)
                    .HasColumnName("cage_status");

                entity.Property(e => e.CageType)
                    .HasMaxLength(20)
                    .HasColumnName("cage_type");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.StaffId).HasColumnName("staff_id");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Cages)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__cage__area_id__440B1D61");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Cages)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__cage__staff_id__44FF419A");
            });

            modelBuilder.Entity<Expert>(entity =>
            {
                entity.ToTable("expert");

                entity.HasIndex(e => e.PhoneNumber, "UQ__expert__A1936A6BB3DAA2BD")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__expert__AB6E616425F2A879")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .HasColumnName("sex");

                entity.Property(e => e.StartDay)
                    .HasColumnType("date")
                    .HasColumnName("start_day");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Experts)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK__expert__area_id__3F466844");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("food");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<FoodInMeal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("food_in_meal");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.MealId).HasColumnName("meal_id");

                entity.HasOne(d => d.Food)
                    .WithMany()
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("FK__food_in_m__food___59FA5E80");

                entity.HasOne(d => d.Meal)
                    .WithMany()
                    .HasForeignKey(d => d.MealId)
                    .HasConstraintName("FK__food_in_m__meal___59063A47");
            });

            modelBuilder.Entity<FoodStorage>(entity =>
            {
                entity.ToTable("food_storage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<LogType>(entity =>
            {
                entity.ToTable("log_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnimalId).HasColumnName("animal_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.LogTypes)
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("FK__log_type__animal__4D94879B");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("meal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CageId).HasColumnName("cage_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Cage)
                    .WithMany(p => p.Meals)
                    .HasForeignKey(d => d.CageId)
                    .HasConstraintName("FK__meal__cage_id__534D60F1");
            });

            modelBuilder.Entity<SoldTicket>(entity =>
            {
                entity.ToTable("sold_ticket");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasIndex(e => e.PhoneNumber, "UQ__staff__A1936A6B899D43E6")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__staff__AB6E61643BFBD35A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Sex)
                    .HasMaxLength(20)
                    .HasColumnName("sex");

                entity.Property(e => e.StartDay)
                    .HasColumnType("date")
                    .HasColumnName("start_day");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
