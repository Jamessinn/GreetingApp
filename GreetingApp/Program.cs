namespace GreetingApp
{
    class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the total number of your enrolled courses: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double favoriteBook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Total enrolled courses: " + course);
            Console.WriteLine("Price of my favorite book: " +  favoriteBook);
            Console.WriteLine("Press any key to exit.......");
            Console.ReadKey();

        }
    }
}
    