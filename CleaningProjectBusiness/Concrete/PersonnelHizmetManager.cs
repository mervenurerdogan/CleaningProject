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
    public class PersonnelHizmetManager : IPersonnelHizmetService
    {
        private readonly IPersonnelHizmetRepository _personnelHizmetRepository;
        public PersonnelHizmetManager(IPersonnelHizmetRepository personnelHizmetRepository)
        {
            _personnelHizmetRepository = personnelHizmetRepository;
        }
        public void Add(PersonnelHizmet tablo)
        {
           _personnelHizmetRepository.Add(tablo);
        }

        public void Delete(PersonnelHizmet tablo)
        {
            _personnelHizmetRepository.Delete (tablo);
        }

        public List<PersonnelHizmet> GetAll()
        {
            return _personnelHizmetRepository.GetAll();
        }

        public PersonnelHizmet GetById(int id)
        {
            return _personnelHizmetRepository.GetById(id);
        }

        public void Update(PersonnelHizmet tablo)
        {
            _personnelHizmetRepository.Update(tablo);
        }
    }
}
