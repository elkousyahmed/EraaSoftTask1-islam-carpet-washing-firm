namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // carpet washing firm
            Console.WriteLine("welcome to our carpet wash firm");
            Console.WriteLine("Mr. Islam welcoming you ");
            // asking how many carpets
            Console.WriteLine("Please answer the next questions");
            Console.WriteLine("how many small carpets do you have?");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("how many large carpets do you have?");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());
            // calculate the total cost
            int totalSmallCarpetsCost = smallCarpets * 25;
            int totalLargeCarpetsCost = largeCarpets * 35;


            Console.WriteLine("================================================================");
            Console.WriteLine("thank you for your answers");
            Console.WriteLine("================================================================");
            Console.WriteLine(" ");

            Console.WriteLine("------------------------------------------------");
            // small carpets cost
            Console.WriteLine("the price for washing the small carpet is 25$");
            Console.WriteLine($"you have {smallCarpets} small carpet/s \n" +
                $"with total cost {totalSmallCarpetsCost}");
            Console.WriteLine("------------------------------------------------");
            // large carpets cost
            Console.WriteLine("the price for washing the large carpet is 35$");
            Console.WriteLine($"you have {largeCarpets} large carpet/s \n" +
                $"with total cost {totalLargeCarpetsCost} ");
            Console.WriteLine("------------------------------------------------");

            // total cost before tax
            int totalCost = totalSmallCarpetsCost + totalLargeCarpetsCost;


            Console.WriteLine("total price before tax is " + totalCost);

            Console.WriteLine("------------------------------------------------");

            // calculate tax
            int tax = totalCost * 6 / 100;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("tax is " + tax + "    (6%)");

            int finalCost = totalCost + tax;

            // final cost after tax - the amount to be payed by customer 
            Console.WriteLine("================================================================");
            Console.WriteLine("    ");
            Console.WriteLine("total price after tax is " + finalCost);
            Console.WriteLine("    ");
            Console.WriteLine("================================================================");

            // thank you message
            Console.WriteLine("thank you for using our service, waiting for you in our place)");
            Console.WriteLine("for more details, call 010 000 000 ");
            Console.WriteLine("================================================================");

            // end of the application
            //-----------------------------------
            // created by (ahmed m ibrahim) - back end course - eraasoft academy
            Console.ReadLine();


            // done
        }
    }
}
