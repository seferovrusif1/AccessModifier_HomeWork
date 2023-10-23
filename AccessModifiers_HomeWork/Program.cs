using AccessModifiers_HomeWork.Models;

namespace AccessModifiers_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many notebooks are there?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many dollaris computer?");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is this computer's model?");
            string model = Console.ReadLine();

            Notebook x001 = new Notebook(count,price,model);
            
            Console.WriteLine("What is this computer's brand?");
            x001.Brand = Console.ReadLine();
            Console.WriteLine("how much is the Storage of this computer");
            x001.Storage = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("how much is the ram of this computer");
            x001.Ram = Convert.ToByte(Console.ReadLine());
            x001.GetFullInfo();


        }
        
    }
}