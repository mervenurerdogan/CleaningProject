using CleaningProjectBusiness.Abstract;
using CleaningProjectDataAccess.Abstract;
using CleaningProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectBusiness.Concrete
{
    public class HizmetManager : IHizmetService
    {
        private readonly IHizmetRespository _hizmetRespository;
        public HizmetManager(IHizmetRespository hizmetRespository)
        {
            _hizmetRespository = hizmetRespository;
        }
        public void Add(Hizmet tablo)
        {
            _hizmetRespository.Add(tablo);
        }

        public void Delete(Hizmet tablo)
        {
            _hizmetRespository.Delete(tablo);   
        }

        public List<Hizmet> GetAll()
        {
            return _hizmetRespository.GetAll();
        }

        public Hizmet GetById(int id)
        {
           return _hizmetRespository.GetById(id);
        }

        public void Update(Hizmet tablo)
        {
            _hizmetRespository.Update(tablo);
        }
    }
}
