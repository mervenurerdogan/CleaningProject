using CleaningProjectCore.Entities;
using CleaningProjectDataAccess.Abstract;
using CleaningProjectDataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningProjectDataAccess.Concrete
{
    public class EfEntityRepository<Tablo> : IEntityRepository<Tablo> where Tablo : class, IEntity, new()
    {
        public void Add(Tablo tablo)
        {
            using var context = new CleaningProjectDbContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Delete(Tablo tablo)
        {
            using var context = new CleaningProjectDbContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }

        public List<Tablo> GetAll()
        {
            using var context = new CleaningProjectDbContext();
            return context.Set<Tablo>().ToList();
        }

        public Tablo GetById(int id)
        {
            using var context=new CleaningProjectDbContext();
            return context.Set<Tablo>().Find(id);

        }

        public void Update(Tablo tablo)
        {
            using var context = new CleaningProjectDbContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }
    }
}
