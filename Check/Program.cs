using Check;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCheck
{
    internal class Program
    {
        static void Main()
        {      
            ArrayList list = new ArrayList();
            Check check = new Check("Сильпо", "Мирного неба над головой", "Королёва 24", 2022, 10, 23, 17, 44, 35.3, list);

            Choice prod1 = new Choice("Икра", 4.3, 2, 5);
            prod1.Calculation();
            check.AddProduct(prod1);
            
            check.PrintCheck();
        }
    }
}
