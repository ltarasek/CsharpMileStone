using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Czy na pewno chce Pan Kod po polsku??
            //Klient to klient, nic nie poradze

            Ksiazki book1 = new Ksiazki("Pana", "James Honor", Typ.Horror, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Dostępna);
            Ksiazki book2 = new Ksiazki("Kot", "Bob Marley", Typ.Dramat, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Nie_dostepna);
            Ksiazki book3 = new Ksiazki("Bannan", "Ktośor", Typ.Nowela, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Dostępna);
            Ksiazki book4 = new Ksiazki("Pies", "James Honor", Typ.Nowela, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Nie_dostepna);
            Ksiazki book5 = new Ksiazki("Sztuka wojny", "Polak", Typ.Dramat, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Dostępna);
            Ksiazki book6 = new Ksiazki("Kot", "James Honor", Typ.Horror, "Krótkie ale fajne, mogło by być lepsze\n za dużo wody i trzeba pływac", 7, 24.98m, new DateTime(1987, 12, 31), "Popierdzieli ten świat", Dostepnosc.Dostępna);

            List<Ksiazki> bookList = new List<Ksiazki>();

            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
            bookList.Add(book6);


            SearchBooks search = new SearchBooks();

            Console.WriteLine("Podaj tytuł szukanej ksiażki:");
            string bookTitleSearch = Console.ReadLine();
            search.SearchTitle(bookList, bookTitleSearch);


            Console.WriteLine("Podaj typ szukanej ksiażki:");
            string bookTypSearch = Console.ReadLine();
            search.SearchTyp(bookList, bookTypSearch);


            Console.WriteLine("czy chcesz wyszukać dostępne książki: t/n");
            string bookAvailableSearch = Console.ReadLine();
            search.SearchAvailable(bookList, bookAvailableSearch);


            Console.ReadLine();

        }
    }
}
