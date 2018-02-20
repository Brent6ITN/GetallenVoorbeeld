using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetalLibrary
{
    class Getallen
    {
        //private variables
        private int _g1;
        private int _g2;

        //public properties
        public int Getal1
        {
            set { _g1 = value; }
            get { return _g1; }
        }

        public int Getal2
        {
            set { _g2 = value; }
            get { return _g2; }
        }

        //methods
        public int ZoekGGD()
        {
            int kleinste;
            int oplossing=1;

            if (_g1<_g2)
            {
                kleinste = _g1;
            }
            else
            {
                kleinste = _g2;
            }

            for (int i = kleinste; i>=1; i--)
            {
                if ((_g1%i==0)&&(_g2%i==0))
                {
                    oplossing = i;
                    break;
                }
            }

            return oplossing;
        }
    }
}
