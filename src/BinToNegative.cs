using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus
{
    partial class Binary
    {
        /// <summary>
        /// Converts positive binary to negative binary.
        /// </summary>
        /// <param name="s">Binary string to convert</param>
        /// <returns>Converted binary string</returns>
        private static String ToNegative(String s)
        {
            s = s.Replace('0', '1');
            int bin = Convert.ToInt32(s);
            char[] c = s.ToCharArray();
            if (Convert.ToInt32(c[s.Length - 1]) + 1 == 2)
            {
                c[s.Length - 1] = '0';
                int overflow = 1;
                for (int x = s.Length - 2; x != -1; x--)
                {
                    if(overflow == 1)
                    {
                        if(Convert.ToInt32(c[x]) + 1 == 2)
                        {
                            overflow = 1;
                            c[x] = '0';
                        }
                        else
                        {
                            overflow = 0;
                            c[x] = '1';
                        }
                    }
                }
            }
            else
            {
                c[s.Length - 1] = '1';
                s = c.ToString();
            }
            return s;
        }
    }
}
