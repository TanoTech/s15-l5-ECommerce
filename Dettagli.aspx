<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="WonkaShop.Dettagli" %>

<!DOCTYPE html>
<link href="Stile.css" rel="stylesheet" />

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dettagli Prodotto</title>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet" />
    <script src="contatore.js" defer></script>
</head>
<body>
    <nav class="bg-gray-800 p-6">
        <div class="container mx-auto flex items-center justify-between">
            <div class="flex items-center flex-shrink-0 text-white mr-6">
                <img class="h-16 w-auto mr-2" src="https://i.pinimg.com/originals/60/a6/d4/60a6d4eb6c46e97cae44a3663ad91030.png" alt="Logo">
                <span class="font-semibold text-xl">WonkaShop</span>
            </div>
            <div class="flex">
                <a href="VetrinaProdotti.aspx" class="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium">Vetrina Prodotti</a>
                <a href="Carrello.aspx" class="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium">Carrello(<span id="counterCarrelloLabel" runat="server">0</span>)</a>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container mx-auto mt-3">
            <div class="px-6 py-4 grid place-items-center mt-5">
                <div class="font-bold text-2xl mb-2 text-white">
                    <asp:Label ID="lblNomeProdotto" runat="server" Text=""></asp:Label>
                </div>
                <p class=" text-xl text-white m1">
                    <asp:Label ID="lblDescrizione" runat="server" Text=""></asp:Label>
                </p>
                <asp:Label ID="lblPrezzo" runat="server" CssClass="text-white text-xl m-3"></asp:Label>
                <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al carrello" OnClick="BtnAggiungiAlCarrello_Click" class="btnAggiungiCarrello mb-10" />
                <div class="grid place-items-center h-30">
                    <asp:Image ID="imgProdotto" runat="server" CssClass="w-full h-25  rounded-l" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
