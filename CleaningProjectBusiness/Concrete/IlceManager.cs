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
    public class IlceManager : IIlceService
    {
        private readonly IIlceRepository _ılceRepository;
        public IlceManager(IIlceRepository ılceRepository)
        {
            _ılceRepository = ılceRepository;
        }
        public void Add(Ilce tablo)
        {
            _ılceRepository.Add(tablo);
        }

        public void Delete(Ilce tablo)
        {
            _ılceRepository.Delete(tablo);  
        }

        public List<Ilce> GetAll()
        {
            return _ılceRepository.GetAll();
        }

        public Ilce GetById(int id)
        {
            return _ılceRepository.GetById(id);
        }

        public void Update(Ilce tablo)
        {
           _ılceRepository.Update(tablo);
        }
    }
}
