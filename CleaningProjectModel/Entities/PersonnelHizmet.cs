using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class PersonnelHizmet:BaseEntity,IEntity
    {
        public int PersonelHizmetID { get; set; }
        public DateTime WorkDate { get; set; }
        public int Price { get; set; }


        public int PersonelID { get; set; }
        public virtual Personnel Personnel  { get; set; }
        public int HizmetID { get; set; }
        public virtual Hizmet Hizmet { get; set; }
        public int TeklifID { get; set; }
        public virtual TeklifAl TeklifAl { get; set; }

      

    }
}
