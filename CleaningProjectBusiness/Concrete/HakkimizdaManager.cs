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
    public class HakkimizdaManager : IHakkimizdaService
    {
        private readonly IHakkimizdaRepository _hakkimizdaRepository;
        public HakkimizdaManager(IHakkimizdaRepository hakkimizdaRepository)
        {
            _hakkimizdaRepository = hakkimizdaRepository;
        }
        public void Add(Hakkimizda tablo)
        {
           _hakkimizdaRepository.Add(tablo);
        }

        public void Delete(Hakkimizda tablo)
        {
            _hakkimizdaRepository.Delete(tablo);
        }

        public List<Hakkimizda> GetAll()
        {
            return _hakkimizdaRepository.GetAll();
        }

        public Hakkimizda GetById(int id)
        {
            return _hakkimizdaRepository.GetById(id);
        }

        public void Update(Hakkimizda tablo)
        {
             _hakkimizdaRepository.Update(tablo);
        }
    }
}
