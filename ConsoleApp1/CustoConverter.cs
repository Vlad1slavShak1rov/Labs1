using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomConverter
    {
        public int Convertor(string num, out int res) 
        {
            return res = int.Parse(num);
        }
        public double Convertor(string num, out double res)
        {
            return res = double.Parse(num);
        }
        public bool Convertor(string num, out bool res)
        {
            return res = bool.Parse(num);
        }

    }
}
