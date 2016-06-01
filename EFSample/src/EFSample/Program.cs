using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            try
            {
                using (BooksContext data = new BooksContext())
                {
                    data.Database.EnsureCreated();

                    data.Books.Add(new Book { Title = "Professional C# 6", Publisher = "Wrox PRess" });
                    int changed = data.SaveChanges();
                    Console.WriteLine($"changed {changed} records");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
