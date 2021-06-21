using KTB.Uygulama.Bll.Abstract;
using KTB.Uygulama.Dal.Abstract;
using KTB.Uygulama.Dal.Concrete;
using KTB.Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTB.Uygulama.Bll.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private IPersonelRepository _personelRepository;

        public PersonelManager()
        {
            _personelRepository = new PersonelRepository();
        }

        public Personel Add(Personel personel)
        {
            return _personelRepository.Add(personel);
        }

        public List<Personel> GetAll()
        {
            return _personelRepository.GetAll();
        }
    }
}
