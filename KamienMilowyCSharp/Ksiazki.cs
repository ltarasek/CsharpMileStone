using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamienMilowyCSharp
{
    class Ksiazki
    {
        private string _tytul;
        private string _autor;
        private Typ _typ;
        private string _opis;
        private int _iloscStron;
        private decimal _cenaKupna;
        private DateTime _dataWydania;
        private string _wydawca;
        private Dostepnosc _dostepnosc;


        public string Tytul
        {
            get { return _tytul; }
            set { _tytul = Tytul; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = Autor; }
        }

        public Typ Typp
        {
            get { return _typ; }
            set { _typ = Typp; }
        }

        public string Opis
        {
            get { return _opis; }
            set { _opis = Opis; }
        }

        public int IloscStron
        {
            get { return _iloscStron; }
            set { _iloscStron = IloscStron; }
        }

        public decimal CenaKupna
        {
            get { return _cenaKupna; }
            set { _cenaKupna = CenaKupna; }
        }

        public DateTime DataWydania
        {
            get { return _dataWydania; }
            set { _dataWydania = DataWydania; }
        }

        public string Wydawca
        {
            get { return _wydawca; }
            set { _wydawca = Wydawca; }
        }

        public Dostepnosc Dostepnosc
        {
            get { return _dostepnosc; }
            set { _dostepnosc = Dostepnosc; }
        }

        public Ksiazki(string tytul, string autor, Typ typ, string opis, int iloscStron, decimal cenaKupna, DateTime dataWydania, string wydawca, Dostepnosc dostepnosc)
        {
            _tytul = tytul;
            _autor = autor;
            _typ = typ;
            _opis = opis;
            _iloscStron = iloscStron;
            _cenaKupna = cenaKupna;
            _dataWydania = dataWydania;
            _wydawca = wydawca;
            _dostepnosc = dostepnosc;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Tytuł książki:  {Tytul} \nAutor: {Autor} \nTyp: {Typp} \nOpis: {Opis}\nIlość stron: {IloscStron}\nCena książki: {CenaKupna}\nData wydania: {DataWydania} \nWydawca: {Wydawca} \nDostępność: {Dostepnosc}");
        }


    }
}
