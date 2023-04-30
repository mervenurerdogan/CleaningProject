using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class TeklifAl:BaseEntity,IEntity
    {
        public int TeklifID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Note { get; set; }
        public DateTime TeklifDate { get; set; }
        public string Address { get; set; }

        //foreign Key
        public int TeklifHizmetID { get; set; }
        public virtual Hizmet Hizmet { get; set; }
        public int TeklifIlceID { get; set; }
        public virtual  Ilce Ilce { get; set; }

        public virtual ICollection<PersonnelHizmet> PersonnelHizmets { get; set; }
    }
}
