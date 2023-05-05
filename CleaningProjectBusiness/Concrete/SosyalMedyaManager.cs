using CleaningProjectBusiness.Abstract;
using CleaningProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectBusiness.Concrete
{
    public class SosyalMedyaManager : ISosyalMedyaService
    {
        private readonly ISosyalMedyaService _sosyalMedyaService;
        public SosyalMedyaManager(ISosyalMedyaService sosyalMedyaService)
        {
            _sosyalMedyaService = sosyalMedyaService;   
        }
        public void Add(SosyalMedya tablo)
        {
            _sosyalMedyaService.Add(tablo);
        }

        public void Delete(SosyalMedya tablo)
        {
            _sosyalMedyaService.Delete(tablo);
        }

        public List<SosyalMedya> GetAll()
        {
            return _sosyalMedyaService.GetAll();
        }

        public SosyalMedya GetById(int id)
        {
            return _sosyalMedyaService.GetById(id);
        }

        public void Update(SosyalMedya tablo)
        {
            _sosyalMedyaService.Update(tablo);
        }
    }
}
