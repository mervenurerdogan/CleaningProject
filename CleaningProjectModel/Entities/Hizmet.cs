using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class Hizmet:BaseEntity, IEntity
    {
        public int HizmetID { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string img_path { get; set; }


        public virtual ICollection<TeklifAl> TeklifAls { get; set; }
        public virtual ICollection<PersonnelHizmet> PersonnelHizmets { get; set; }
    }
}
