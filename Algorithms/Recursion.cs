using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    static class  RecursionFamilyExample
    {
        public class Family
        {

            public List<Child> children { get; set; } = new List<Child>();
        }

        public class Child
        {
            public string sex { get; set; }
            public Family family { get; set; }

        }

        public static int CountNumberofMaleChild(Family family)
        {
            //variable to hold the number of male children
            //base case.
            if (family.children == null) return 0;
           
            int countMale = 0;

            //loop through all children of a family
            foreach (Child child in family.children)
            {
                if(child.sex == "Male")
                {
                    countMale++;
                }
                //check if the child aslo has a family
                if (child.family != null)
                {
                        countMale += CountNumberofMaleChild(child.family);                  
                }
            }
            return countMale;
        }
    }
}
