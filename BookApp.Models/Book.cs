namespace BookApp.Models
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string kitapadi, string kitapyazari, string basimevi, string basimyili, string fiyati)
        {
            KitapAdi = kitapadi;
            KitapYazari = kitapyazari;
            Basimevi = basimevi;
            BasimYili = basimyili;
            Fiyati = fiyati;
        }
        public Book(int kitapid, string kitapadi, string kitapyazari, string basimevi, string basimyili, string fiyati)
        {
            KitapId = kitapid;
            KitapAdi = kitapadi;
            KitapYazari = kitapyazari;
            Basimevi = basimevi;
            BasimYili = basimyili;
            Fiyati = fiyati;
        }


        public int KitapId { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public string Basimevi { get; set; }
        public string BasimYili { get; set; }
        public string Fiyati { get; set; }



    }
}
