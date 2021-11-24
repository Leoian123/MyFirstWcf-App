using Serialator;
using Serialator.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceOnDb.ServiceClient service = new ServiceOnDb.ServiceClient();
            List<Contatto> rubrica = service.GetAllContatti().ToList();
            foreach (var c in rubrica)
            {
                Console.WriteLine(c.Id + " " + c.Nome + " " + c.Cognome+ " "+ c.NumberPhone);
            }
            Console.WriteLine("Cosa vuoi modificare?");
            string show;
            int id;
            do
            {
                id = Convert.ToInt32(Console.ReadLine());
                show = service.GetContatto(id).ToString();
            } while (show == null);
            Console.WriteLine("{0}", show);
            Contatto cambio = new Contatto();
            Console.WriteLine(@"Insert:
                                Nome:");
            cambio.Nome= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cognome:");
            cambio.Cognome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Numero di Telefono:");
            cambio.NumberPhone = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Giorno");
            int day = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Mese");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anno");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime birth = new DateTime(year, month, day);
            cambio.BirthDay = birth;
            cambio.Id = id;
            service.UpdateContatto(cambio);
        }
    }
}
