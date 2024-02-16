using System;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WonkaShopProdotti;

namespace WonkaShop
{
    public partial class VetrinaProdotti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Prodotti();
            }
        }

        private void Prodotti()
        {
            ListaProdotti listaProdotti = new ListaProdotti();
            Prodotti prodotti = listaProdotti.GetProdotti();

            ProdottiRepeater.DataSource = prodotti.GetProdotti();
            ProdottiRepeater.DataBind();
        }

        protected void AggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            Button btnAggiungiAlCarrello = (Button)sender;
            RepeaterItem item = (RepeaterItem)btnAggiungiAlCarrello.NamingContainer;
            int idProdotto = Convert.ToInt32(((HiddenField)item.FindControl("IdProdotto")).Value);
            AggiungiProdottoAlCarrello(idProdotto);

        }
        private void AggiungiProdottoAlCarrello(int idProdotto)
        {
            HttpCookie cookieCarrello = Request.Cookies["Carrello"];

            if (cookieCarrello == null)
            {
                cookieCarrello = new HttpCookie("Carrello");
            }

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

        protected void Dettagli(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Dettagli")
            {
                int idProdotto = Convert.ToInt32(e.CommandArgument);

                Response.Redirect($"Dettagli.aspx?id={idProdotto}");
            }
        }
        protected void DropDownListGenere_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genereSelezionato = DropDownListGenere.SelectedValue;

            if (string.IsNullOrEmpty(genereSelezionato))
            {
                Prodotti();
            }
            else
            {
                ListaProdotti listaProdotti = new ListaProdotti();
                Prodotti prodotti = listaProdotti.GetProdotti();

                var prodottiFiltrati = prodotti.GetProdotti().Where(p => p.Categoria == genereSelezionato);

                ProdottiRepeater.DataSource = prodottiFiltrati;
                ProdottiRepeater.DataBind();
            }
        }
    }
}