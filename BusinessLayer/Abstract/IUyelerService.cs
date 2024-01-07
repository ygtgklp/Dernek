using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUyelerService
    {
        void Add(Uyeler uyeler);
        void Update(Uyeler uyeler);

        void Delete(int uye_id);

        List<Uyeler> GetAll();

        List<Uyeler> GetAllByCountry(string country);

        List<Uyeler> GetAllByBlood(string blood);

        List<Uyeler> GetAllByActive(bool active);
    }
}
