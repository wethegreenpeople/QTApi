using QTApi.DAL;
using QTApi.Models;
using QTApi.Models.Animals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QTApi.Helpers
{
    public class FactsDatabase
    {
        private readonly APIContext _context;
        public FactsDatabase(APIContext context)
        {
            _context = context;
        }

        public void FactsToDatabse()
        {
            string path = "dog.txt";
            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                DogFact dogFact = new DogFact()
                {
                    Fact = line,
                };
                _context.DogFacts.Add(dogFact);
            }
            _context.SaveChanges();
        }
    }
}
