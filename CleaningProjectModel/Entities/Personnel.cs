using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class Personnel:BaseEntity,IEntity
    {
        public int PersonnelID { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public virtual ICollection<PersonnelHizmet> PersonnelHizmets { get; set; }
    }
}
