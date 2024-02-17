<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VetrinaProdotti.aspx.cs" Inherits="WonkaShop.VetrinaProdotti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vetrina Prodotti</title>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet" />
    <link href="Stile.css" rel="stylesheet" />
    <script src="contatore.js" defer="defer"></script>
</head>
<body>
    <nav class="bg-gray-800 p-6">
        <div class="container mx-auto flex items-center justify-between">
            <div class="flex items-center flex-shrink-0 text-white mr-6">
                <img class="h-16 w-auto mr-2" src="https://i.pinimg.com/originals/60/a6/d4/60a6d4eb6c46e97cae44a3663ad91030.png" alt="Logo" />
                <span class="font-semibold text-xl">WonkaShop</span>
            </div>
            <div class="flex">
                <a href="VetrinaProdotti.aspx" class="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium">Vetrina Prodotti</a>
                <a href="Carrello.aspx" class="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium">Carrello(<span id="counterCarrelloLabel" runat="server">0</span>)</a>
            </div>
        </div>
    </nav>
    <div class="grid place-items-center">
        <h1 class="font-bold text-6xl m-5 text-white h1Capo">I nostri prodotti</h1>
    </div>
    <form id="form1" runat="server">
        <div class="container mx-auto">
            <div class="flex m-8">
                <p class="text-white">Filtra i prodotti per categoria:</p>
                <asp:DropDownList ID="DropDownListGenere" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListGenere_SelectedIndexChanged">
                    <asp:ListItem Text="Tutti i prodotti" Value=""></asp:ListItem>
                    <asp:ListItem Text="Caramelle" Value="Caramelle"></asp:ListItem>
                    <asp:ListItem Text="Cioccolato" Value="Cioccolato"></asp:ListItem>
                    <asp:ListItem Text="Creme" Value="Creme"></asp:ListItem>
                    <asp:ListItem Text="Confetture" Value="Confetture"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
                <asp:Repeater ID="ProdottiRepeater" runat="server">
                    <ItemTemplate>
                        <div class="max-w-sm rounded overflow-hidden shadow-lg">
                            <div class="grid place-items-center">
                                <img class="h-60" src='<%# Eval("Immagine") %>' alt='<%# Eval("Nome") %>' />
                            </div>
                            <div class="px-6 py-4 blur-20">
                                <div class="font-bold text-2xl mb-2 text-white"><%# Eval("Nome") %></div>
                                <p class=" text-base m-1 text-white">Prezzo: <%# Eval("Prezzo") %> €/KG</p>
                                <p class=" text-base m-1 text-white  ">Categoria: <%# Eval("Categoria") %></p>
                                <asp:HiddenField ID="IdProdotto" runat="server" Value='<%# Eval("Id") %>' />
                                <div class="flex">
                                    <asp:Button runat="server" Text="Aggiungi al carrello" OnClick="AggiungiAlCarrello_Click" class="btnAggiungiCarrello" />
                                    <asp:Button ID="btnDettagli" runat="server" Text="Visualizza Dettagli" OnCommand="Dettagli" CommandName="Dettagli" CommandArgument='<%# Eval("Id") %>' class="btnDet" />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
