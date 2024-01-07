using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Aidat : IEntity
    {
        public int aidat_id {  get; set; }
        public string aidat_month { get; set; }
        public string aidat_price { get; set; }
    }
}
