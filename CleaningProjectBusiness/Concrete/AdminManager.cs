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
    public class AdminManager : IAdminService
    {
        public readonly IAdminRepository _adminRepository;
        public AdminManager(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;   
        }
        public void Add(Admin tablo)
        {
            _adminRepository.Add(tablo);
        }

        public void Delete(Admin tablo)
        {
            _adminRepository.Delete(tablo);
        }

        public List<Admin> GetAll()
        {
            return _adminRepository.GetAll();
        }

        public Admin GetById(int id)
        {
            return _adminRepository.GetById(id);
        }

        public void Update(Admin tablo)
        {
             _adminRepository.Update(tablo);
        }
    }
}
