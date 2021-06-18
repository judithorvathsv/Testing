using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First3;

namespace First3
{
   public class GradeStat
    {
    public  float Av;
    public  float High;
    public  float Low;

        public GradeStat()
        {
            High = 0;
            Low = float.MaxValue;
        }
   
    }
}
