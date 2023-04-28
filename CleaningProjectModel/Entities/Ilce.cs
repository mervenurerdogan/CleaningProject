using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class Ilce:BaseEntity,IEntity
    {
        public int IlceID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeklifAl> TeklifAls { get; set; }

    }
}
