using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetalLibrary
{
    public class controller
    {
        Getallen _getallen = new Getallen();

        public void setGetal1(int g1)
        {
            _getallen.Getal1 = g1;
        }

        public void setGetal2(int g2)
        {
            _getallen.Getal2 = g2;
        }

        public int zoekGGD()
        {
            return _getallen.ZoekGGD();
        }
    }
}
