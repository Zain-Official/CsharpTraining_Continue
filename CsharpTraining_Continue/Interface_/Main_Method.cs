using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpTraining_Continue.Interface_
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            IData[] arr = new IData[]
            {
                new Hafeez()
            };
            foreach(IData e in arr)
            {
                e.name();
                e.emai();
            }
        }
    }
}
