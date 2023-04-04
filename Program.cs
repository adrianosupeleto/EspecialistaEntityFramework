using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso
{
    public class Program
    {
        static void Main(string[] args)
        {
           EnsureCreatedAndDeleted();
        }

        static void EnsureCreatedAndDeleted()
        {
            using var db = new Curso.Data.ApplicationContext();
            //db.Database.EnsureCreated();
            //db.Database.EnsureDeleted();
        }
    }
}