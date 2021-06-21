using KTB.Uygulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KTB.Uygulama.Bll.Abstract
{
    public interface IPersonelService
    {
        List<Personel> GetAll();
        Personel Add(Personel personel);
    }
}
