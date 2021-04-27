using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Rene.Clases.Utils
{
    class Converts
    {
        public String convertDoubleToString(double value)
        {
            String ret = "";

            String[] values = value.ToString().Split(',', '.');
            String integers = values[0];

            if (integers.Length < 4)
            {
                if(integers == "0")
                {
                    values[0] = "0000";
                }
                switch (values[0].Length)
                {
                    case 1: values[0] = "000" + integers; break;
                    case 2: values[0] = "00" + integers; break;
                    case 3: values[0] = "0" + integers; break;
                }
            }
            if (values.Length > 1)
            {
                String decimals = values[1];
                if (decimals.Length > 2)
                {
                    values[1] = "0" + decimals;
                }
                /*if (values.Length > 1)
                {

                    ret += integers + "," + decimals;
                }
                else
                {
                    ret += value.ToString();
                }*/
                ret = values[0] + "." + values[1];
            }
            else
            {
                ret = values[0];
            }

            return ret;
        }
    }
}
