using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class SosyalMedya:BaseEntity,IEntity
    {
        public int SocialID { get; set; }
        public string HesapFA { get; set; }
        public string HesapURL { get; set; }
    }
}
