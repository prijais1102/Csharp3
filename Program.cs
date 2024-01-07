using System.Diagnostics.CodeAnalysis;

namespace Assignment1c
{
    internal class Program
    {
        static double amount,sur;
        public static void Main()
        {
            //1
            Duplicate();
            //2
            Eligibility();
            //3
            Bill();
        }
        static void Duplicate()
        {
            int[] arr = { 1, 2, 3, 4, 5, 4, 4, 3, 1, 9 };
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int element in arr)
            {
                if (dict.ContainsKey(element))
                {
                    dict[element]++;
                }
                else
                {
                    dict[element] = 1;
                }
            }

            int duplicateCount = 0;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (pair.Value > 1)
                {
                    duplicateCount += pair.Value - 1;
                }
            }

            Console.WriteLine("The total number of duplicate elements in the array is " + duplicateCount + ".");
        }
        static void Eligibility()
        {
            Console.WriteLine("Enter Marks in Maths, Physics and Chemistry");
            int Maths=int.Parse(Console.ReadLine());
            int Phy = int.Parse(Console.ReadLine());
            int Chem = int.Parse(Console.ReadLine());
            int sum = Maths+Phy+Chem;
            int sum1 = Maths + Phy;

            if(Maths >=65 && Phy >=55 && Chem >=50 && sum>=180 || sum1>=140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
        static void Bill()
        {
            Console.WriteLine("Enter customer id, name, unit consumed");
            int id= int.Parse(Console.ReadLine()); 
            String name= Console.ReadLine();
            int unit = int.Parse(Console.ReadLine());
            Console.WriteLine("Customer IDNO :"+id);
            Console.WriteLine("Customer Name:"+name);
            Console.WriteLine("unit Consumed:"+ unit);



            if (unit<=199)
            {
                amount = 1.20 * unit;
                if(amount<100)
                {
                    amount= 100;
                }
                Console.WriteLine("Amount Charges @1.20 per unit :" + amount);
            }
            else 
            if(unit<=399 && unit >199)
            {
                amount= 1.50 * unit;
                Console.WriteLine("Amount Charges @1.50 per unit :" + amount);
            }
            else
            if(unit<=599 && unit>399)
            {
                amount = 1.80 * unit;
                Console.WriteLine("Amount Charges @1.80 per unit :" + amount);
            }
            else
            if(unit>=600)
            {
                amount= 2.00*unit;
                Console.WriteLine("Amount Charges @2.00 per unit :" + amount);
            }

            

            if(amount>400)
            {
                sur = 0.15 * amount;
                Console.WriteLine("Surchage Amount : " + sur);
                Console.WriteLine("Net Amount Paid By the Customer : "+ (amount + sur));
            }


        }
    }
}
