using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class Hakkimizda:BaseEntity,IEntity
    {
        public int HakkimizdaID { get; set; }
        public string Tanitim { get; set; }
        public string Vizyonumuz { get; set; }
        public string Misyonumuz { get; set; }
        public string ImagePath { get; set; }
    }
}
