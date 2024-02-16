using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WonkaShopProdotti;

namespace WonkaShopCarrello
{
    public partial class Carrello : System.Web.UI.Page
    {
        public class ProdottoCarrello
        {
            public int Id { get; set; }
            public Prodotto Prodotto { get; set; }
            public int Quantita { get; set; }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataToRepeater();
                TotaleCarrello();
            }
        }

        private void BindDataToRepeater()
        {
            HttpCookie cookieCarrello = Request.Cookies["Carrello"];

            if (cookieCarrello != null)
            {
                List<ProdottoCarrello> prodottiNelCarrello = new List<ProdottoCarrello>();

                ListaProdotti listaProdotti = new ListaProdotti();
                Prodotti prodottiDisponibili = listaProdotti.GetProdotti();

                foreach (string idProdotto in cookieCarrello.Values.AllKeys)
                {
                    int id = int.Parse(idProdotto);
                    int quantita = int.Parse(cookieCarrello[idProdotto]); 
                    Prodotto prodotto = prodottiDisponibili.TrovaProdotto(id);
                    if (prodotto != null)
                    {
                        ProdottoCarrello prodottoCarrello = prodottiNelCarrello.FirstOrDefault(p => p.Id == id);
                        if (prodottoCarrello != null)
                        {
                            prodottoCarrello.Quantita += quantita;
                        }
                        else
                        {
                            prodottiNelCarrello.Add(new ProdottoCarrello { Id = id, Prodotto = prodotto, Quantita = quantita });
                        }
                    }
                }

                ProdottiNelCarrelloRepeater.DataSource = prodottiNelCarrello;
                ProdottiNelCarrelloRepeater.DataBind();
            }
            else
            {
                ProdottiNelCarrelloRepeater.Visible = false;
            }
        }

        protected void ProdottiNelCarrelloRepeater_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

            }
        }

        protected void RimuoviOggetto_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Rimuovi")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                RimuoviDalCarrello(productId);

                BindDataToRepeater();
            }
        }

        private void RimuoviDalCarrello(int productId)
        {
            HttpCookie cartCookie = Request.Cookies["Carrello"];

            if (cartCookie != null)
            {
                if (cartCookie[productId.ToString()] != null)
                {
                    cartCookie.Values.Remove(productId.ToString());

                    cartCookie.Expires = DateTime.Now.AddDays(1);

                    Response.Cookies.Set(cartCookie);
                    Response.Redirect(Request.RawUrl);
                }
            }
        }

        protected void AggiornaQuantita_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Aggiorna")
            {
                int productId = Convert.ToInt32(e.CommandArgument);
                int nuovaQuantita = Convert.ToInt32(((TextBox)((Button)sender).Parent.FindControl("QuantitaTextBox")).Text);

                AggiornaQuantitaNelCarrello(productId, nuovaQuantita);

                BindDataToRepeater();
            }
        }

        private void AggiornaQuantitaNelCarrello(int productId, int nuovaQuantita)
        {
            HttpCookie cartCookie = Request.Cookies["Carrello"];

            if (cartCookie != null)
            {
                if (cartCookie[productId.ToString()] != null)
                {
                    cartCookie.Values[productId.ToString()] = nuovaQuantita.ToString();

                    cartCookie.Expires = DateTime.Now.AddDays(1);

                    Response.Cookies.Set(cartCookie);
                    Response.Redirect(Request.RawUrl);
                }

                if (nuovaQuantita == 0)
                {
                    RimuoviDalCarrello(productId);
                    return;
                }
            }
        }
        protected void SvoutaCarrello_Click(object sender, EventArgs e)
        {

            HttpCookie cartCookie = Request.Cookies["Carrello"];
            if (cartCookie != null)
            {
                cartCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Set(cartCookie);
            }

            BindDataToRepeater();
            Response.Redirect(Request.RawUrl);
        }

        protected void TotaleCarrello()
        {
            HttpCookie cartCookie = Request.Cookies["Carrello"];
            decimal totale = 0;

            if (cartCookie != null)
            {
                List<ProdottoCarrello> prodottiNelCarrello = new List<ProdottoCarrello>();
                ListaProdotti listaProdotti = new ListaProdotti();
                Prodotti prodottiDisponibili = listaProdotti.GetProdotti();

                foreach (string idProdotto in cartCookie.Values.AllKeys)
                {
                    int id = int.Parse(idProdotto);
                    int quantita = int.Parse(cartCookie[idProdotto]);
                    Prodotto prodotto = prodottiDisponibili.TrovaProdotto(id);

                    if (prodotto != null)
                    {
                        totale += prodotto.Prezzo * quantita;
                    }
                }
            }

            TotaleCarrelloLabel.Text = totale.ToString("C");
        }
    }
}
