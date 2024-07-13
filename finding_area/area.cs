using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_area
{
    public class area
    {
        public int sq_area = 0;
        public int rct_area = 0;
        public double cir_area = 0;
        public void sum(int l)
        {
            sq_area = l * l;
            Console.WriteLine(sq_area);
        }
        public void sum(int x, int y)
        {
            rct_area = x * y;
            Console.WriteLine(rct_area);
        }
        public void sum(double a)
        {
            cir_area = (22/7) * a;
            Console.WriteLine(cir_area);
        }
    }
}
