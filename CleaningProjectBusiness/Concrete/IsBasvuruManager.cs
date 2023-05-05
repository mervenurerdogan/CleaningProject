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
    public class IsBasvuruManager : IIsBasvuruService
    {
        private readonly IIsBasvuruRepository _ısBasvuruRepository;
        public IsBasvuruManager(IIsBasvuruRepository ısBasvuruRepository)
        {
            _ısBasvuruRepository = ısBasvuruRepository;
        }
        public void Add(IsBasvuru tablo)
        {
            _ısBasvuruRepository.Add(tablo);    
        }

        public void Delete(IsBasvuru tablo)
        {
            _ısBasvuruRepository.Delete (tablo);    
        }

        public List<IsBasvuru> GetAll()
        {
            return _ısBasvuruRepository.GetAll();   
        }

        public IsBasvuru GetById(int id)
        {
            return _ısBasvuruRepository.GetById(id);
        }

        public void Update(IsBasvuru tablo)
        {
            _ısBasvuruRepository.Update(tablo);
        }
    }
}
