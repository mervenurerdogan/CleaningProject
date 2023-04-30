using CleaningProjectDataAccess.Abstract;
using CleaningProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Concrete
{
    public class EfSosyalMedyaRepository:EfEntityRepository<SosyalMedya>,ISosyalMedyaRespository
    {
    }
}
