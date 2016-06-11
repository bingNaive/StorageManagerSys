using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageDbContext dbContext = new StorageDbContext();
            dbContext.Database.CreateIfNotExists();
            Console.WriteLine("ok");
        }
    }
}
