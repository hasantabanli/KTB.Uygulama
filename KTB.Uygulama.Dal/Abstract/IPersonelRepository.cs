using KTB.Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTB.Uygulama.Dal.Abstract
{
    public interface IPersonelRepository
    {
        List<Personel> GetAll();
        Personel Add(Personel personel);
    }
}
