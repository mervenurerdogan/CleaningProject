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
    public class TeklifAlManager : ITeklifAlService
    {
        private readonly ITeklifAlRepository _teklifAlRepository;
        public TeklifAlManager(ITeklifAlRepository teklifAlRepository)
        {
            _teklifAlRepository = teklifAlRepository;
        }
        public void Add(TeklifAl tablo)
        {
            _teklifAlRepository.Add(tablo);
        }

        public void Delete(TeklifAl tablo)
        {
            _teklifAlRepository.Delete(tablo);  
        }

        public List<TeklifAl> GetAll()
        {
            return _teklifAlRepository.GetAll();    
        }

        public TeklifAl GetById(int id)
        {
            return _teklifAlRepository.GetById(id);
        }

        public void Update(TeklifAl tablo)
        {
            _teklifAlRepository.Update(tablo);
        }
    }
}
