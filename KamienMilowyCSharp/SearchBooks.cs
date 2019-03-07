using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowyCSharp
{
    class SearchBooks
    {
        public void SearchTitle(List<Ksiazki> book, string provided)
        {
            bool check = false;

            for (int i = 0; i < book.Count; i++)
            {
                Ksiazki boo = book[i];
                if (boo.Tytul == provided)
                {
                    Console.WriteLine("*********************\n");
                    Console.WriteLine("Szukana książka jest w systemie, poniżej zobacz szczegóły:");
                    boo.GetDetails();
                    Console.WriteLine("\n*********************\n\n ");
                    check = true;
                }

            }
            if (!check)
            {
                Console.WriteLine("Niestety nie ma takiej ksiażki");
            }
        }

        public void SearchTyp(List<Ksiazki> book, string provided)
        {
            bool check = false;

            for (int i = 0; i < book.Count; i++)
            {
                Ksiazki boo = book[i];
                if ((string)boo.Typp.ToString() == provided)
                {
                    Console.WriteLine("*********************\n");
                    Console.WriteLine("Szukana typ książki jest w systemie, poniżej zobacz szczegóły:");
                    boo.GetDetails();
                    Console.WriteLine("\n*********************\n\n ");
                    check = true;
                }

            }
            if (!check)
            {
                Console.WriteLine("Niestety nie ma takiego typu");
            }
        }

        public void SearchAvailable(List<Ksiazki> book, string provided)
        {
            bool check = false;
            if (provided == "t")
            {
                Console.WriteLine("Oto dostępne książki");
                for (int i = 0; i < book.Count; i++)
                {

                    Ksiazki boo = book[i];
                    if ((string)boo.Dostepnosc.ToString() == "Dostępna")
                    {

                        Console.WriteLine("*********************\n");
                        Console.WriteLine("Szukana typ książki jest w systemie, poniżej zobacz szczegóły:");
                        boo.GetDetails();
                        Console.WriteLine("\n*********************\n\n ");
                        check = true;
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Nie ma dostępnych ksiażek");
                }
            }
            else if (provided == "n")
            {
                Console.WriteLine("to nie wyświetlam");
            }

        }


    }
}
