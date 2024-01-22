
namespace Ispit.Model
{
    public class Ucenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public double Prosjek {  get; set; }

        public string Starost()
        {
            DateTime datumDanas = DateTime.Now;
            DateTime datumRodjenja = DatumRodjenja;
            TimeSpan starostUcenika = datumDanas - datumRodjenja;
            return $"Starost učenika je {starostUcenika} godina";
        }

        public void IspisProsjeka()
        {
            if (Prosjek >= 1 && Prosjek < 1.5)
            {
                Console.WriteLine("Nedovoljan");
            }
            else if (Prosjek >= 1.5 && Prosjek < 2.5)
            {
                Console.WriteLine("Dovoljan");
            }
            else if (Prosjek >= 2.5 && Prosjek < 3.5)
            {
                Console.WriteLine("Dobar");
            }
            else if (Prosjek >= 3.5 && Prosjek < 4.5)
            {
                Console.WriteLine("Vrlo dobar");
            }
            else if (Prosjek >= 4.5 && Prosjek <= 5)
            {
                Console.WriteLine("Odličan");
            }
            else
            {
                Console.WriteLine("Nepoznat unos!!");
            }
        }



    }




}

