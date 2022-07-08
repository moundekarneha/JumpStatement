using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStatement
{
    internal class Program
    {
        //jump statement
        static void Main(string[] args)
        {
            for(int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    break;
                }
            //if(i==2)
            //{
            //    continue;
            //}

            abc:
                Console.WriteLine("I am label");
                if (i == 2)
                {
                    goto abc;
                  
                }
                if (i == 3)
                {
                    return;
                }
            }
        }
    }
}
