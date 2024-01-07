using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AidatService
    {
        IAidatDal aidatDal;

        public AidatService(IAidatDal aidatDal)
        {
            this.aidatDal = aidatDal;
        }

        public List<Aidat> GetAllAidat()
        {
            return aidatDal.GetAll();
        }
    }
}
