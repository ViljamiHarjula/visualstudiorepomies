using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konsulttiryhmä;



namespace Konsulttitoikea
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] Konsultit =
           {
            "Nina Puhakka", "Riikka Valjakka",
            "Oscar Storbacka", "Jere Mörsky",
            "Lotta Järvinen", "Katri Kolehmainen",
            "Tuomas Tuominen", "Olli Piilonen",
            "Okku Toivola", "Mikko Kairesalo",
            "Anni Kaivola", "Mikko Keino",
            "Viljami Harjula", "Roman Tcharni",
            "Henni Marjomaa", "Vesa Anttila",
            "Ville Immonen", "Hanna-Mari Lapp",
            "Sara Seunavaara", "Oona Kangas",
            "Elli Salo", "Jussi Ojala",
            "Tatu Vahteri", "Silja Fagerholm ",
            "Sari Paavilainen", "Erika Laamanen",
            "Tero Tuovinen", "Aarni Koskelainen",
            "Riku Kuusinen", "Jukka Peltola"};

            Array.Sort(Konsultit);

            foreach (string k in Konsultit)
            {
               // Console.WriteLine(k);
            }

            List<KonsulttiLista> KonsulttiLista = new List<KonsulttiLista>();
            string[] nimenOsat;
            foreach (var k in Konsultit)
            {
                nimenOsat = k.Split(' ');
                KonsulttiLista ko = new KonsulttiLista() { Etunimi = nimenOsat[0], Sukunimi = nimenOsat[1] };


                KonsulttiLista.Add(ko);
            }

            var o = from å in KonsulttiLista
                    where å.Sukunimi.Contains("nen")
                    select å;

            foreach (var å in o)
                {
                Console.WriteLine(å.Etunimi + " " + å.Sukunimi);
            }

            Console.ReadLine();
            Console.Clear();

            var p = from i in KonsulttiLista
                    orderby i.Sukunimi ascending
                    select i;

            foreach (var i in p)
            {
                Console.WriteLine(i.Sukunimi + " " + i.Etunimi);
            }

            Console.ReadLine();
            Console.Clear();

            var y = from z in KonsulttiLista
                    orderby z.Etunimi descending
                    select z;

            foreach (var z in y)
            {
                Console.WriteLine(z.Etunimi + " " + z.Sukunimi);
            }

            Console.ReadLine();
            Console.Clear();

            var yp = from zp in KonsulttiLista
                     orderby zp.Etunimi.Length + zp.Sukunimi.Length descending
                     select zp;

           
            Console.WriteLine(yp.First());

            Console.ReadLine();
            Console.Clear();

            var tp = from er in KonsulttiLista
                     orderby er.Sukunimi.Count(f => f == 'a' || f == 'e' || f == 'i' || f == 'y' || f == 'u' || f == 'o' || f == 'å' || f == 'ä' || f == 'ö') ascending
                     select er;

            Console.WriteLine(tp.First());

            Console.ReadLine();
            Console.Clear();


            Random rand = new Random(DateTime.Now.ToString().GetHashCode());

            int RyhmäKoko;

            Console.WriteLine("Anna ryhmäkoko");
            string input = Console.ReadLine();
            Int32.TryParse(input, out RyhmäKoko);

            int RyhmienLkm = KonsulttiLista.Count / RyhmäKoko;

            Random rnd = new Random();




            for (int i = 0; i < RyhmienLkm; i++)
            {
                Console.WriteLine($"Ryhmä {i + 1}:");
                for (int j = 0; j < RyhmäKoko; j++)
                {
                    int sl = rnd.Next(0, KonsulttiLista.Count);
                    Console.WriteLine(KonsulttiLista[sl].Sukunimi + "," + KonsulttiLista[sl].Etunimi);

                    KonsulttiLista.RemoveAt(sl);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
            // testi
        }
    }

}
