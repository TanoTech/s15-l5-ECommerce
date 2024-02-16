using System;
using System.Web;
using WonkaShopProdotti;

namespace WonkaShop
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaDettagliProdotto();
            }
        }
        private void CaricaDettagliProdotto()
        {
            if (Request.QueryString["id"] != null)
            {
                int idProdotto = Convert.ToInt32(Request.QueryString["id"]);

                ListaProdotti listaProdotti = new ListaProdotti();
                Prodotti prodotti = listaProdotti.GetProdotti();

                Prodotto dettagliProdotto = prodotti.TrovaProdotto(idProdotto);

                if (dettagliProdotto != null)
                {
                    imgProdotto.ImageUrl = dettagliProdotto.Immagine;
                    lblNomeProdotto.Text = dettagliProdotto.Nome;
                    lblDescrizione.Text = dettagliProdotto.Descrizione;
                    lblPrezzo.Text = "Prezzo: " + dettagliProdotto.Prezzo.ToString("C");
                }
            }
        }

        protected void BtnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int idProdotto = Convert.ToInt32(Request.QueryString["id"]);
                AggiungiProdottoAlCarrello(idProdotto);
                Response.Redirect(Request.RawUrl);
            }
        }

        private void AggiungiProdottoAlCarrello(int idProdotto)
        {
            HttpCookie cookieCarrello = Request.Cookies["Carrello"] ?? new HttpCookie("Carrello");

            if (cookieCarrello[idProdotto.ToString()] == null)
            {
                cookieCarrello[idProdotto.ToString()] = "1";
            }
            else
            {
                int quantitaAttuale = Convert.ToInt32(cookieCarrello[idProdotto.ToString()]);
                cookieCarrello[idProdotto.ToString()] = (quantitaAttuale + 1).ToString();
            }

            cookieCarrello.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookieCarrello);
        }
    }
}
