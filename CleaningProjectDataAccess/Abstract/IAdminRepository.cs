using CleaningProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Abstract
{
    public interface IAdminRepository:IEntityRepository<Admin>
    {
    }
}
