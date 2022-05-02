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

            //Sans linq, avec une boucle
            foreach(var album in maListe)
            {
                if (album.Title.Contains("ba"))
                {
                    Console.WriteLine(album.Title);
                }
            }


        }
    }
}
