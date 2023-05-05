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
    public class IletisimManager : IIletisimService
    {
        private readonly IIletisimRepository _ıletisimRepository;
        public IletisimManager(IIletisimRepository ıletisimRepository)
        {
            _ıletisimRepository = ıletisimRepository;
        }
        public void Add(Iletisim tablo)
        {
            _ıletisimRepository.Add(tablo);
        }

        public void Delete(Iletisim tablo)
        {
            _ıletisimRepository.Delete(tablo);
        }

        public List<Iletisim> GetAll()
        {
            return _ıletisimRepository.GetAll();
        }

        public Iletisim GetById(int id)
        {
           return _ıletisimRepository.GetById(id);
        }

        public void Update(Iletisim tablo)
        {
            _ıletisimRepository.Update(tablo);
        }
    }
}
