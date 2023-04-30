using CleaningProjectCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectModel.Entities
{
    public class Iletisim:BaseEntity,IEntity
    {
        public int IletisimID { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string ShortAddress { get; set; }
        public string Address { get; set; }
    }
}
