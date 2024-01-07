using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UyelerService
    {
        IUyelerDal uyelerDal;

        public UyelerService(IUyelerDal uyelerDal)
        {
            this.uyelerDal = uyelerDal;
        }

        public List<Uyeler> GetAllUyeler()
        {
           return uyelerDal.GetAll();
        }

        public void Add(Uyeler uyeler)
        {
            uyelerDal.Add(uyeler);
        }

        public List<Uyeler> GetAllByCountry(string country) 
        { 
            return uyelerDal.GetAllByCountry(country);
        }

        public List<Uyeler> GetAllByBlood(string blood)
        {
            return uyelerDal.GetAllByBlood(blood);
        }

        public List<Uyeler> GetAllByActive(bool active)
        {
            return uyelerDal.GetAllByActive(active);
        }
    }
}
