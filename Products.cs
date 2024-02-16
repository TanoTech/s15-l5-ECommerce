using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WonkaShopProdotti
{
    public class Prodotto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Categoria { get; set; }
        public string Immagine { get; set; }
    }

    public class Prodotti
    {
        private List<Prodotto> _prodotti;

        public Prodotti()
        {
            _prodotti = new List<Prodotto>();
        }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            _prodotti.Add(prodotto);
        }

        public Prodotto RimuoviProdotto(int id)
        {
            var prodotto = _prodotti.Find(p => p.Id == id);
            _prodotti.Remove(prodotto);
            return prodotto;
        }

        public Prodotto TrovaProdotto(int id)
        {
            return _prodotti.Find(p => p.Id == id);
        }

        public IEnumerable<Prodotto> GetProdotti()
        {
            return _prodotti;
        }
    }


    public class ListaProdotti
    {
        private Prodotti _prodotti;


        public ListaProdotti()
        {
            _prodotti = new Prodotti();

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 1,
                Nome = "Jellydrilli",
                Descrizione = "Coccodrilli gommosi di varie forme e gusti, per colorare le tue feste!.",
                Prezzo = 10,
                Categoria = "Caramelle",
                Immagine = "https://m.media-amazon.com/images/I/51EADJuHgAL._AC_UF1000,1000_QL80_.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 2,
                Nome = "Orsetti gommosi",
                Descrizione = "I famosissimi orsetti gommosi, personaggi principali del tuo party.",
                Prezzo = 12,
                Categoria = "Caramelle",
                Immagine = "https://www.pianetacaramelle.com/10726-thickbox_default/orsetti-gommosi-colorati.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 3,
                Nome = "Cuori gommosi",
                Descrizione = "Da regalare alla tua dolce metà, o per addolcire la tua giornata.",
                Prezzo = 8,
                Categoria = "Caramelle",
                Immagine = "https://www.pianetacaramelle.com/11268-thickbox_default/haribo-cuore.jpg"
            }) ;

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 4,
                Nome = "Marshmellow",
                Descrizione = "Il campeggio non lo fai se il marshmellow non ce l'hai.",
                Prezzo = 6,
                Categoria = "Caramelle",
                Immagine = "https://m.media-amazon.com/images/I/41TaQAH2neL.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 5,
                Nome = "Lollipop",
                Descrizione = "Non facciamo battute inopportune.",
                Prezzo = 3,
                Categoria = "Caramelle",
                Immagine = "https://i.ebayimg.com/images/g/UMwAAOSwXI5kbujf/s-l1600.png"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 6,
                Nome = "Cioccolato bianco",
                Descrizione = "Per tutti i palati, addolcisce la tua vita",
                Prezzo = 20,
                Categoria = "Cioccolato",
                Immagine = "https://domori.com/3640-large_default/pastiglie-cioccolato-bianco-35-1-kg.jpg"
            });


            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 7,
                Nome = "Cioccolato al latte",
                Descrizione = "Per tutti i palati, addolcisce la tua vita",
                Prezzo = 20,
                Categoria = "Cioccolato",
                Immagine = "https://domori.com/3178-large_default/pastiglie-cioccolato-al-latte-38-vidama-costa-d-avorio-1-kg-.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 8,
                Nome = "Cioccolato rosa",
                Descrizione = "Come la pantera, ma più goloso!",
                Prezzo = 25,
                Categoria = "Cioccolato",
                Immagine = "https://i.ebayimg.com/images/g/5pYAAOSw2S1juq5c/s-l1600.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 9,
                Nome = "Crema al pistacchio",
                Descrizione = "Dai tempi antichi, dalle terre di Bronte, la nostra crema Brontesauro",
                Prezzo = 35,
                Categoria = "Creme",
                Immagine = "https://i.ebayimg.com/images/g/-hsAAOSwJhFh7Ecc/s-l1600.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 10,
                Nome = "Crema alle nocciole",
                Descrizione = "Siamo più buoni della nut***a(per questioni di copyright ci censuriamo)",
                Prezzo = 28,
                Categoria = "Creme",
                Immagine = "https://coffeeandsweets.it/wp-content/uploads/2023/04/2894827568-595x760.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 11,
                Nome = "Crema alle mandorle",
                Descrizione = "Super proteica, i tuoi squat non saranno più gli stessi!",
                Prezzo = 26,
                Categoria = "Creme",
                Immagine = "https://www.bulk.com/media/catalog/product/cache/1440x1440/t/r/triple-nut-butter_bpf-tnut-smoo_main.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 12,
                Nome = "Marmellata di fichi",
                Descrizione = "Perché così lo sei di più!",
                Prezzo = 6,
                Categoria = "Confetture",
                Immagine = "https://i.ebayimg.com/images/g/6~sAAOSwku5lxzNN/s-l500.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 13,
                Nome = "Caccao in polvere",
                Descrizione = "Per sporcare tutto il piano cottura.",
                Prezzo = 2,
                Categoria = "Cioccolato",
                Immagine = "https://cibobenessere.com/cdn/shop/products/Cacao.jpg?v=1647788070"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 14,
                Nome = "Burro di arachidi",
                Descrizione = "Con la marmellata è tutta un'altra storia.",
                Prezzo = 4,
                Categoria = "Creme",
                Immagine = "https://media-assets.lacucinaitaliana.it/photos/620fbeeee7e738246399909a/4:3/w_1332,h_999,c_limit/empty"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 15,
                Nome = "Confettura di fragole",
                Descrizione = "Dai nostri giardini, le migliori fragole.",
                Prezzo = 4,
                Categoria = "Confetture",
                Immagine = "https://www.giallozafferano.it/images/1-186/Confettura-di-fragole_780x520_wm.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 16,
                Nome = "Confettura di Cipolle di Tropea",
                Descrizione = "I tuoi colleghi ti ameranno dopo la colazione!",
                Prezzo = 3,
                Categoria = "Confetture",
                Immagine = "https://m.media-amazon.com/images/I/71v27ow7VnL.__AC_SX300_SY300_QL70_ML2_.jpg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 17,
                Nome = "Omini di zenzero",
                Descrizione = "E' stato l'uomo focaccina!",
                Prezzo = 5,
                Categoria = "Cioccolato",
                Immagine = "https://staticcookist.akamaized.net/wp-content/uploads/sites/21/2021/12/266110804_412230987161909_6313084509569524014_n-1200x675.jpeg"
            });

            _prodotti.AggiungiProdotto(new Prodotto
            {
                Id = 18,
                Nome = "Caramelle seltz",
                Descrizione = "Frizza che è tutto un brio!",
                Prezzo = 4,
                Categoria = "Caramelle",
                Immagine = "https://m.media-amazon.com/images/I/71mrUgPc5pL.__AC_SX300_SY300_QL70_ML2_.jpg"
            });
        }

        public Prodotti GetProdotti()
        {
            return _prodotti;
        }
    }
}
