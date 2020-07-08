using System;
using System.Collections.Generic;
using static Algorithms.RecursionFamilyExample;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Child stephen = new Child();           Child Divine = new Child();
            stephen.sex = "Male";                   Divine.sex = "Male";
            
            Child Chidinma = new Child();        Child Child4 = new Child();
              Chidinma.sex = "Female";             Child4.sex = "Male";
                       
            List<Child> EmmanuelsChildren = new List<Child>();
            EmmanuelsChildren.Add(Divine);
            EmmanuelsChildren.Add(Chidinma);

            Family EmmanuelsFamily = new Family()
            {
                children = EmmanuelsChildren
            };
           
            List<Child> ChidinmaChildren = new List<Child>();
            ChidinmaChildren.Add(stephen);
            ChidinmaChildren.Add(Child4);

            Chidinma.family = new Family()
            {
                children = ChidinmaChildren
            };

            int noOfMaleChild = RecursionFamilyExample.CountNumberofMaleChild(EmmanuelsFamily);
            Console.WriteLine(noOfMaleChild);
            Console.ReadKey();
        }
    }
}
