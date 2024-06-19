using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceis420FinalProject
{
    internal class Helper
    {
        public bool CheckInput(string input, string value)
        {
            if(input.ToLower() == value.ToLower())
                return true;

            return false;
        }


        public bool CheckNumber(string input)
        {
            try
            {
                double.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
