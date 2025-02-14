using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class IntExtension
    {
        //Extension Method must be inside static and non-generic class.
        public static void ReverseInt(this ref int num)// this => refer to the caller of the method
                                                       // say that the parameter will be the caller of the method
        {
            int reversedNum = 0;

            while (num != 0)
            {
                reversedNum = reversedNum * 10 + num % 10;
                num = num / 10;
            }
            num = reversedNum;
        }

    }
}
