using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dtos
{
   public class HealthLogResponse
    {
        public String Type { get; set; }
        public String AnimalName {  get; set; }
        public String ShortDescription {  get; set; }
        public String Species {  get; set; }
        public DateTime DateTime { get; set; }
    }
}
