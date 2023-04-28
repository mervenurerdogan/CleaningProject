using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class IsBasvuru:BaseEntity,IEntity
    {
        public int IsBasvuruID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string LastEmployedCompany { get; set; }
        public DateTime StartEmployed { get; set; }
        public DateTime FinishEmployed { get; set; }
        public string CV { get; set; }
    }
}
