using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3_LunaClaraso.Models
{
    public class BDTemporal
    {
        public Cadeteria Cadeteria { get; set; }

        public BDTemporal()
        {
            Cadeteria = new Cadeteria();
        }
    }
}
