using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCompanyLibrary
{
    public class Media : BaseMediaService
    {
        public Media(string name, string author, string type, string theme, bool free, double price, string dateOfProduction)
        {
            Name = name;
            Author = author;
            Type = type;
            Theme = theme;
            Free = free;
            Price = price;
            DateOfProduction = dateOfProduction;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public string Theme { get; set; }
        public bool Free { get; set; }
        public double Price { get; set; }
        public string DateOfProduction { get; set; }
       

        public override void ChangeMediaFree()
        {
            if (Free)
                Free = false;
            else
                Free = true;
        }
    }
}
