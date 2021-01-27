using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class EmployeePromotion
    {
       
        static List<string> empList = new List<string>();

        public void AddEmployeePromotion()
        {
            bool f = true;
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            while (f)
            {
                string name = Console.ReadLine();
                if (name == string.Empty)
                    f = false;
                else
                {
                    empList.Add(name);
                }
            }

            //find his position in the promotion list

            Console.WriteLine("Please enter the name of the employee to check promotion position\n");
            string nameemp = Console.ReadLine();
            int a = empList.IndexOf(nameemp);
            int b = a + 1;
            Console.WriteLine(nameemp + " is the position " + b + " for promotion");

            //Now sorting the list

            empList.Sort();
            System.Console.WriteLine("\n" + "Promoted employee list:" + "\n");

            foreach (var ename in empList)
            {
                Console.WriteLine(ename);
            }

            Console.ReadLine();

        }
    }
}
