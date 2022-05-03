using DataSources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Album> maListe = ListAlbumsData.ListAlbums;

            //Ecrire tous les éléments de ma liste qui comporte les lettres ba

            //Avec Linq en syntaxe requête
            var malisteQuery = from album in maListe
                               where album.Title.Contains("ba")
                               select album;


            //Avec Linq en syntaxe méthode
            var malisteMethode = maListe.Where(album => album.Title.Contains("ba"));



            //SOMME  

            //Sans linq, avec une boucle
            int sommeIdentifiants = 0;
            foreach (var album in maListe)
            {
                sommeIdentifiants += album.AlbumId;
            }
            Console.WriteLine("Sans linq" + sommeIdentifiants);

            //Fonctions de statistiques
            Console.WriteLine("Somme : " + maListe.Sum(album => album.AlbumId));
            Console.WriteLine("Moyenne : " + maListe.Average(album => album.AlbumId));
            Console.WriteLine("Maximum : " + maListe.Max(album => album.AlbumId));
            Console.WriteLine("Minimum : " + maListe.Min(album => album.AlbumId));
            Console.WriteLine("Nombre d'éléments : " + maListe.Count());

            //Je veux savoir si ma liste a au moins un élément
            bool elleAAuMoinsUnElement = maListe.Any();

            //Je veux savoir si ma liste a au moins un élément qui correspond à cette condition : AlbumId == 350
            bool auMoinsUnElementAvecLaCondition = maListe.Any(album => album.AlbumId == 350);

            var maListeDalbumValide = maListe.Where(album => album.AlbumId == 350);
            bool valide = maListeDalbumValide.Any();

            if (maListe.Any(album => album.AlbumId == 350))
            {
                ///faire qqchose
            }


            var enumeration = Enumerable.Repeat(8, 30);
            foreach (var e in enumeration)
            {
                Console.Write($"{e} ");
            }




            // Delegue Func
            var ints = Enumerable.Range(0, 10);
            Func<int, bool> GreaterThanTwo = (i) =>
            {
                return i > 2;
            };
            IEnumerable<int> intsGreaterThanTwo = ints.Where(GreaterThanTwo);
            foreach (int i in intsGreaterThanTwo)
            {
                Console.WriteLine(i);
            }


            string toto = "6541065 46054 6350463 4063 54065 4";
            toto = MaskifyByMethodSyntax(toto);
            Console.WriteLine(toto);



            var listeGroupee = maListe.GroupBy(album => album.Title.Substring(0, 1));

            //Une liste des éléments groupées
            //a, b, c, d
            // b => une liste d'albums

            foreach(var lettre in listeGroupee)
            {
                Console.WriteLine("Lettre : "+lettre.Key);

                foreach (var mesalbums in lettre)
                {
                    Console.WriteLine(mesalbums.Title);
                }
            }
        }
        public static bool GreaterThanTwoFonction(int i)
        {
            return i > 2;
        }


        public static string MaskifyByMethodSyntax(string cardNumber)
        {
            //Découpe le string en tableau de char
            var monStringEnCharArray = cardNumber.Trim().ToCharArray();

            //On transforme notre tableau en tableau de char avec les premiers char en *
            var request = monStringEnCharArray.Select((monChar, index) => { 
                if(index < cardNumber.Length - 4)
                {
                    return '*';
                }
                else
                {
                    return monChar;
                }
            });

            //Execute la requête LINQ
            var monTableauFini = request.ToArray();

            // On transforme le tableau de char en string
            string leRetour = new string(monTableauFini);
            return leRetour;
        }


        public static void GetMinimumNumberCurrencyBills(int amount)
        {
            int[] currenciesValues = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            Dictionary<int, int> map = new Dictionary<int, int>();

            currenciesValues.OrderByDescending(c => c)
                .ToList()
                .ForEach(c =>
                {
                    map.Add(c, amount / c);
                    amount %= c;
                });

            map.Where(m => m.Value != 0);

            foreach (var element in map)
            {
                Console.WriteLine($"Nombre de billets de {element.Key} : {element.Value}");
            }
        }
    }
}
