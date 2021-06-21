using KTB.Uygulama.Dal.Abstract;
using KTB.Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KTB.Uygulama.Dal.Concrete
{
    public class PersonelRepository : IPersonelRepository
    {
        public Personel Add(Personel personel)
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                personelDbContext.Add(personel);
                personelDbContext.SaveChanges();
                return personel;
            }
        }

        public List<Personel> GetAll()
        {
            using (var personelDbContext = new PersonelDbContext())
            {
                return personelDbContext.Personel.ToList();
            }
        }
    }
}
