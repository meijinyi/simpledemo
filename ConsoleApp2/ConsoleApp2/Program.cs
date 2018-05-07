using EFLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Z.EntityFramework.Plus;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                var q = db.Locations.Where(t => t.ID == "").Update(t => new Location { Level = LocationLevel.Area });

                Console.WriteLine();
            }
        }
    }
}