using System;

namespace Aurum_Cafe_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mealChoice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tAURUM CAFE");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Chose your meal type:");
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. Snacks\n2. Breakfast\n3. Lunch\n4. Dinner\n5. Supper\n6. Beverages and drinks\n--->");
            Console.ResetColor();
            mealChoice = Convert.ToInt32(Console.ReadLine());
            if (mealChoice == 1)
            {
                Snacks();
                Console.WriteLine("View pricing? (Y/N)");
            }
            else if (mealChoice ==2)
            {
                Breakfast();
                Console.WriteLine("View pricing? (Y/N)");
            }
            else if (mealChoice==3)
            {
                Lunch();
                Console.WriteLine("View pricing? (Y/N)");
            }
            else if(mealChoice==4)
            {
               Dinner();
               Console.WriteLine("View pricing? (Y/N)");
            }
            else if(mealChoice==5)
            {
               Supper();
               Console.WriteLine("View pricing? (Y/N)");
            }
            else if(mealChoice==6)
            {
                BeveragesAndDrinks();
                Console.WriteLine("View pricing? (Y/N)");
                
            }
            else
            {
                
            Console.WriteLine("Please enter a valid parameter!!!");
            }

            var pricing = Console.ReadLine();
            if (pricing.Contains("Y") || pricing.Contains("y"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\tAURUM CAFE");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Chose your meal type:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Snacks\n2. Breakfast\n3. Lunch\n4. Dinner\n5. Supper\n6. Beverages and drinks\n--->");
                Console.ResetColor();
                mealChoice = Convert.ToInt32(Console.ReadLine());
                if (mealChoice == 1)
                {
                    Pricing.Snacks();
                }
                else if (mealChoice ==2)
                {
                    Pricing.Breakfast();
                }
                else if (mealChoice==3)
                {
                    Pricing.Lunch();
                }
                else if(mealChoice==4)
                {
                    Pricing.Dinner();
                }
                else if(mealChoice==5)
                {
                    Pricing.Supper();
                }
                else if(mealChoice==6)
                {
                    Pricing.BeveragesAndDrinks();
                }
                else
                {
                    Console.WriteLine("Please enter a valid parameter!!!");
                }
            }
            else if (pricing.Contains("N") || pricing.Contains("n"))
            {
                Console.WriteLine("Thank you for dining at Aurum Cafe, Welcome back again...");
            }
            else
            {
                Console.WriteLine("Invalid parameter!");
            }

            Console.ReadKey();
        }

        private static void Snacks()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tSNACKS\n1.Samosa\n2.Kebab\n3.Beef sausage\n4.Chapati\n5.Doughnuts\n6.Cake\n7.Sandwitch bread\n8.Pan-fried potatoes");
        }
        private static void Breakfast()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tBREAKFAST\n1.Black tea\n2.Black coffee\n3.White coffee\n4.Plain Milk\n5.Chai China\n6.Chai\n7.Fried Eggs\n8.Omelette");
        }
        private static void Lunch()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Pilau ngombe\n2.Pilau Mbuzi\n3.Karanga mbuzi\n4.Beans\n5.Beef soup\n6.Maini\n7.Chips\n8.Plain rice");
        }
        private static void Supper()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Pilau ngombe\n2.Pilau Mbuzi\n3.Karanga mbuzi\n4.Beans\n5.Beef soup\n6.Maini\n7.Chips\n8.Plain rice");
        }
        private static void Dinner()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Kachumbari\n2.Chips\n3.Spagheti\n4.Salads\n5.Beef soup\n6.Pilau\n7.Chips\n8.Plain rice");
        }
        private static void BeveragesAndDrinks()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tBEVERAGES AND DRINKS\n1.Mango juice\n2.Banana milk shake\n3.Orange juice\n4.Soda\n5.Water\n6.Tamarine juice\n7.Avocado juice\n8.Beetroot juice");
        }

    }

    class Pricing
    {
        public static void Snacks()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tSNACKS\n1.Samosa\t\t\t30/=\n2.Kebab\t\t\t30/=\n3.Beef sausage\t\t\t40/=\n4.Chapati\t\t\t15/=\n5.Doughnuts\t\t\t20/=\n6.Cake\t\t\t40/=\n7.Sandwitch bread\t\t\t40/=\n8.Pan-fried potatoes\t\t\t35/=");
        }
        public static void Breakfast()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tBREAKFAST\n1.Black tea\t\t\t30/=\n2.Black coffee\t\t\t30/=\n3.White coffee\t\t\t30/=\n4.Plain Milk\t\t\t30/=\n5.Chai China\t\t\t30/=\n6.Chai\t\t\t30/=\n7.Fried Eggs\t\t\t30/=\n8.Omelette\t\t\t30/=");
        }
        public static void Lunch()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Pilau ngombe\t\t\t30/=\n2.Pilau Mbuzi\t\t\t30/=\n3.Karanga mbuzi\t\t\t30/=\n4.Beans\t\t\t30/=\n5.Beef soup\t\t\t30/=\n6.Maini\t\t\t30/=\n7.Chips\t\t\t30/=\n8.Plain rice\t\t\t30/=");
        }
        public static void Supper()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Pilau ngombe\t\t\t30/=\n2.Pilau Mbuzi\t\t\t30/=\n3.Karanga mbuzi\t\t\t30/=\n4.Beans\t\t\t30/=\n5.Beef soup\t\t\t30/=\n6.Maini\t\t\t30/=\n7.Chips\t\t\t\t30/=\n8.Plain rice\t\t\t30/=");
        }
        public static void Dinner()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tMAIN DISHES\n1.Kachumbari\t\t\t30/=\n2.Chips\t\t\t30/=\n3.Spagheti\t\t\t30/=\n4.Salads\t\t\t30/=\n5.Beef soup\t\t\t30/=\n6.Pilau\t\t\t30/=\n7.Chips\t\t\t30/=\n8.Plain rice\t\t\t30/=");
        }
        public static void BeveragesAndDrinks()
        {
            //Console.WriteLine();
            Console.WriteLine("\t\tBEVERAGES AND DRINKS\n1.Mango juice\t\t\t30/=\n2.Banana milk shake\t\t\t30/=\n3.Orange juice\t\t\t30/=\n4.Soda\t\t\t30/=\n5.Water\t\t\t30/=\n6.Tamarine juice\t\t\t30/=\n7.Avocado juice\t\t\t30/=\n8.Beetroot juice\t\t\t30/=");
        }
    }
}