using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining_Continue.Abstract_Class
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            Demo[] arr = new Demo[]
            {

            new Zain_Sindhi(),new Haseeb()

            };

            foreach(Demo t in arr)
            {
            t.name();
            t.contacctNo();
            t.email();
            }


        }
    }
}
