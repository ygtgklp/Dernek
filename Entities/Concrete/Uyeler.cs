using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Uyeler : IEntity
    {
        public int uye_id {  get; set; }
        public string uye_name { get; set; }
        public string uye_surname {  get; set; }
        public string uye_country {  get; set; }
        public string uye_tc {  get; set; }
        public string uye_bloodtype {  get; set; }
        public bool uye_active { get; set; }


    }
}
