namespace CS120_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hoang Khoi Gia Nguyen
            // Computer Programming 1 CSI 120
            // Assignment 2
        }

        public static void Problem1()
        {
            Console.Write("Enter decimal number 1:");

            decimal userDecimal1 = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput = Console.ReadLine();

                isValid1 = decimal.TryParse(userInput, out userDecimal1);
                if (decimal.TryParse(userInput, out userDecimal1))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }

            Console.Write("Enter decimal number 2:");

            decimal userDecimal2 = 0;
            bool isValid2 = false;

            while (!isValid2)
            {
                string userInput = Console.ReadLine();

                isValid2 = decimal.TryParse(userInput, out userDecimal2);
                if (decimal.TryParse(userInput, out userDecimal2))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }
            Console.Write("Enter decimal number 3:");

            decimal userDecimal3 = 0;
            bool isValid3 = false;

            while (!isValid3)
            {
                string userInput = Console.ReadLine();

                isValid3 = decimal.TryParse(userInput, out userDecimal3);
                if (decimal.TryParse(userInput, out userDecimal3))
                {
                    isValid3 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }
            Console.Write("Enter decimal number 4:");

            decimal userDecimal4 = 0;
            bool isValid4 = false;

            while (!isValid4)
            {
                string userInput = Console.ReadLine();

                isValid4 = decimal.TryParse(userInput, out userDecimal4);
                if (decimal.TryParse(userInput, out userDecimal4))
                {
                    isValid4 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }
            Console.Write("Enter decimal number 5:");

            decimal userDecimal5 = 0;
            bool isValid5 = false;

            while (!isValid5)
            {
                string userInput = Console.ReadLine();

                isValid5 = decimal.TryParse(userInput, out userDecimal5);
                if (decimal.TryParse(userInput, out userDecimal5))
                {
                    isValid5 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }
            }

            decimal userDecimalSum = userDecimal1 + userDecimal2 + userDecimal3 + userDecimal4 + userDecimal5;
            decimal userDecimalAvg = userDecimalSum / 5;

            Console.WriteLine($"The five numbers you chose are: {userDecimal1}, {userDecimal2}, {userDecimal3}, {userDecimal4}, {userDecimal5}");
            Console.WriteLine($"The sum of the numbers you chose is: {userDecimalSum}");
            Console.WriteLine($"The average of the numbers you chose is:{userDecimalAvg}");

        }
        public static void Problem2()
        {
            Console.Write("Enter automobile's fuel capacity (gallon):");

            decimal userFuel = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput1 = Console.ReadLine();

                isValid1 = decimal.TryParse(userInput1, out userFuel);
                if (decimal.TryParse(userInput1, out userFuel))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            Console.Write("Enter automobile's mileage per gallon of fuel (mile):");

            decimal userMileage = 0;
            bool isValid2 = false;

            while (!isValid2)
            {
                string userInput2 = Console.ReadLine();

                isValid2 = decimal.TryParse(userInput2, out userMileage);
                if (decimal.TryParse(userInput2, out userMileage))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }

            }
            decimal vehicleMileage = userFuel * userMileage;
            Console.WriteLine($"Fuel capacity: {userFuel} gallon(s), Mileage per gallon: {userMileage} mile(s), Vehicle mileage: {vehicleMileage} mile(s)");
        }

        public static void Problem3()
        {
            Console.Write("Enter event's duration (second):");

            int userTime = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput = Console.ReadLine();

                isValid1 = int.TryParse(userInput, out userTime);
                if (int.TryParse(userInput, out userTime))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            int eventHour = userTime / 3600;
            int hourLeft = userTime % 3600;
            int eventMinute = hourLeft / 60;
            int eventSecond = hourLeft % 60;
            
            
            Console.WriteLine($"The duration you chose is: {userTime} second(s), estimated to be around {eventHour}:{eventMinute}:{eventSecond} long");
        }
        public static void Problem4()
        {
            Console.Write("Enter the hour(s) of the event's duration:");

            int userHour = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput = Console.ReadLine();

                isValid1 = int.TryParse(userInput, out userHour);
                if (int.TryParse(userInput, out userHour))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            Console.Write("Enter the minute(s) of the event's duration:");

            int userMinute = 0;
            bool isValid2 = false;

            while (!isValid2)
            {
                string userInput = Console.ReadLine();

                isValid2 = int.TryParse(userInput, out userMinute);
                if (int.TryParse(userInput, out userMinute))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            Console.Write("Enter the second(s) of the event's duration:");

            int userSecond = 0;
            bool isValid3 = false;

            while (!isValid3)
            {
                string userInput = Console.ReadLine();

                isValid3 = int.TryParse(userInput, out userSecond);
                if (int.TryParse(userInput, out userSecond))
                {
                    isValid3 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            int eventHourSecond = userHour * 3600;
            int eventMinuteSecond = userMinute * 60;
            int eventSecond = eventHourSecond + eventMinuteSecond + userSecond;

            Console.WriteLine($"Your event duration is: {userHour} hour(s) {userMinute} minute(s) {userSecond} second(s), estimated to be around {eventSecond} second(s) ");
        }

        public static void Problem5()
        {
            Console.Write("Enter the original price of the products:");

            double productOriginalPrice = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput = Console.ReadLine();

                isValid1 = double.TryParse(userInput, out productOriginalPrice);
                if (double.TryParse(userInput, out productOriginalPrice))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            Console.Write("Enter the mark up percentage (X%):");

            double percentMarkUp = 0;
            bool isValid2 = false;

            while (!isValid2)
            {
                string userInput = Console.ReadLine();

                isValid1 = double.TryParse(userInput, out percentMarkUp);
                if (double.TryParse(userInput, out percentMarkUp))
                {
                    isValid2 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }

            Console.Write("Enter the sale tax rate (Y%):");

            double saleTaxRate = 0;
            bool isValid3 = false;

            while (!isValid3)
            {
                string userInput = Console.ReadLine();

                isValid1 = double.TryParse(userInput, out saleTaxRate);
                if (double.TryParse(userInput, out saleTaxRate))
                {
                    isValid3 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }


            Console.WriteLine($"Your input was as follows: Original price ({productOriginalPrice}); Mark up rate ({percentMarkUp}%); Sale tax rate: ({saleTaxRate}%)");

            double calculateMarkUp = percentMarkUp / 100;
            double amountMarkUp = productOriginalPrice * calculateMarkUp;
            double productSellingPrice = productOriginalPrice + amountMarkUp;
            double calculateTax = saleTaxRate / 100;
            double saleTax = productSellingPrice * calculateTax;
            double productFinalPrice = productSellingPrice + saleTax;

            Console.WriteLine($"Product's original price: {productOriginalPrice}");
            Console.WriteLine($"Mark up percentage: {percentMarkUp}");
            Console.WriteLine($"Product's selling price: {productSellingPrice}");
            Console.WriteLine($"Sale tax rate: {saleTaxRate}");
            Console.WriteLine($"Sale tax amount: {saleTax}");
            Console.WriteLine($"Product's final price: {productFinalPrice}");


        }

        public static void Problem6()
        {
            Console.Write("Enter length (cm):");

            int userLength = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput1 = Console.ReadLine();

                isValid1 = int.TryParse(userInput1, out userLength);
                if (int.TryParse(userInput1, out userLength))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }
            Console.WriteLine($"The length you chose is: {userLength} (cm)");
            
            decimal userInch = Math.Round(userLength / (decimal)2.54);
            int convertYard = (int)userInch / 36;
            int yardLeft = (int)userInch % 36;
            int convertFeet = yardLeft / 12;
            int convertInch = yardLeft % 12;

            Console.WriteLine($"Your length after conversion is: {convertYard} yard(s), {convertFeet} feet (foot), and {convertInch} inch(es)");


        }

        public static void Problem7()
        {
            Console.WriteLine("A milk carton can hold 3.78 liters of milk. Each morning, a dairy farm ships cartons of milk to a local grocery store. The cost of producing one liter of milk is $0.38, and the profit of each carton of milk is $0.27");
            Console.WriteLine("");

            Console.Write("Enter the desired amount of milk produced in the morning (liter):");

            double milkAmount = 0;
            bool isValid1 = false;

            while (!isValid1)
            {
                string userInput = Console.ReadLine();

                isValid1 = double.TryParse(userInput, out milkAmount);
                if (double.TryParse(userInput, out milkAmount))
                {
                    isValid1 = true;
                }
                else
                {
                    Console.Write("Enter a valid number: ");
                }


            }
            int cartonAmount = (int)Math.Round(milkAmount / 3.78);
            double milkCost = milkAmount * 0.38;
            double milkProfit = cartonAmount * 0.27;

            Console.WriteLine($"a. Total amount of milk produced in the morning: {milkAmount} liter(s)");
            Console.WriteLine($"b. The number of milk cartons needed to hold milk is around: {cartonAmount} carton(s)");
            Console.WriteLine($"c. Cost of producing milk: {milkCost.ToString("c")}");
            Console.WriteLine($"d. Profit for producing milk: {milkProfit.ToString("c")}");
        }
    }
}
