using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Masalar
    {
        public Masalar()
        {
            siparisler = new List<Siparis>();
        }

        public int masaNo { get; set; }
        public List<Siparis> siparisler { get; set; }
    }
}

