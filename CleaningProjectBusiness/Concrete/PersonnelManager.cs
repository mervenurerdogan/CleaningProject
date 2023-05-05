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
    public class PersonnelManager : IPersonnelService
    {
        private readonly IPersonnelRepository _personnelRepository;
        public PersonnelManager(IPersonnelRepository personnelRepository)
        {
            _personnelRepository= personnelRepository;
        }
        public void Add(Personnel tablo)
        {
            _personnelRepository.Add(tablo);
        }

        public void Delete(Personnel tablo)
        {
            _personnelRepository.Delete (tablo);
        }

        public List<Personnel> GetAll()
        {
            return _personnelRepository.GetAll();   
        }

        public Personnel GetById(int id)
        {
          return  _personnelRepository.GetById (id);
        }

        public void Update(Personnel tablo)
        {
           _personnelRepository.Update(tablo);
        }
    }
}
