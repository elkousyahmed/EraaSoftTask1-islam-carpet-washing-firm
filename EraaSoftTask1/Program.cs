namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------- carpet washing firm ----------------------------

            Console.WriteLine("welcome to our carpet cleaning service");
            Console.WriteLine("Mr. Islam welcoming you ");
            // asking how many carpets
            Console.WriteLine("Please answer the next questions");

            // small carpets
            Console.WriteLine("how many small carpets do you have?");
            // waiting costumer input
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            // large carpets
            Console.WriteLine("how many large carpets do you have?");
            // waiting costumer input
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            // calculate the total cost
            int totalSmallCarpetsCost = smallCarpets * 25;
            int totalLargeCarpetsCost = largeCarpets * 35;

            // separator
            Console.WriteLine("================================================================");
            Console.WriteLine(" ");

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
            Console.WriteLine("tax is " + tax + "       (6%)");

            int finalCost = totalCost + tax;

            // final cost after tax - the amount to be payed by customer 
            Console.WriteLine("================================================================");
            Console.WriteLine("    ");
            Console.WriteLine("total price after tax is " + finalCost);
            Console.WriteLine("    ");
            Console.WriteLine("================================================================");

            // thank you message
            Console.WriteLine("thank you for using our service");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("================================================================");

            Console.ReadLine();

            // ---------------- end of the application -------------------------------

        }
    }
}
