using P1.DataContext;
using P1.Domain;
using System;

namespace P1
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (MyDataContext myDataContext = new MyDataContext())
            {
                foreach (Product product in myDataContext.Products)
                {
                    Console.WriteLine(product.Title);
                }

                Console.ReadKey();
            }
        }
    }
}