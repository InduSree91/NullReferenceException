using System;

namespace NullReferenceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                string name = "Indu";
                //string name = null; // Name should not be given null as the value

                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Input string is Null");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("This line will run only when the error is handled.");

        }
    }
}