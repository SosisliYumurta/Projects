using MediaCompanyLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Media media1 = new Media("Media1","Oguz","movie","advantures",true,1500,"2023");
            Media media2 = new Media("Media2","Berk","videogame","gun fight",true,200,"2022");
            Media media3 = new Media("Media3","Aydin","audio","sadness",false,50,"1995");

            Film film1 = new Film("Director1", new List<string>() { "Paul Walker", "Dwayne jhanson" },"action",950000,"Fast and Frious","oguz","film","advantures",true,25,"2022");

            List<Media> medias = new List<Media> { media1, media2, media3, film1 };
            var sortedMedias = medias.OrderBy(m => m.Price);
            foreach (var media in sortedMedias)
            {
                
                    
                Console.WriteLine("Name: {0}, Price: {1}, Free status {2}", media.Name, media.Price, media.Free);
            }

            Console.WriteLine("------------------------------");
            film1.Withdraw(medias);
            media2.Withdraw(medias);

            foreach (var media in sortedMedias)
            {
                Console.WriteLine("Name: {0}, Price: {1}, Free status {2}", media.Name, media.Price, media.Free);
            }

            

            Console.WriteLine("------------------------------");
            media1.ChangeMediaFree();

            foreach (var media in sortedMedias)
            {
                Console.WriteLine("Name: {0}, Price: {1}, Free status {2}", media.Name, media.Price, media.Free);
            }

            Console.WriteLine("------------------------------");

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\Casper\\Desktop\\oopExam.txt");
                foreach (var media in sortedMedias)
                {
                    sw.WriteLine("Name: {0}, Price: {1}, Free status {2}", media.Name, media.Price, media.Free);
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            Console.ReadLine();









        }
    }                                  
}                                      
