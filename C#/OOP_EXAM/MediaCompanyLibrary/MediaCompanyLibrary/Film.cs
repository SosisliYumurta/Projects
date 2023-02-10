using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCompanyLibrary
{
    public class Film : Media
    {
        public Film(string director, List<string> mainCharacters, string genre, double budget, string name, string author, string type, string theme, bool free, double price, string dateOfProduction) : base(name, author, type, theme, free, price, dateOfProduction)
        {
            Director = director;
            MainCharacters = mainCharacters;
            Genre = genre;
            Budget = budget;
        }

        public string Director { get; set; }
        public List<string> MainCharacters { get; set; }
        public string Genre { get; set; }
        public double Budget { get; set; }
    }


}
