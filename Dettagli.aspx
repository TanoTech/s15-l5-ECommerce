<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="WonkaShop.Dettagli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dettagli Prodotto</title>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet" />
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
                <a href="Carrello.aspx" class="text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium">Carrello</a>
            </div>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container mx-auto">
            <h1 class="text-3xl font-semibold mt-8 mb-4">Dettagli Prodotto</h1>
            <div class="grid place-items-center">
                <asp:Image ID="imgProdotto" runat="server" CssClass="h-70 object-cover" />
            </div>
            <div class="px-6 py-4 grid place-items-center">
                <div class="font-bold text-xl mb-2">
                    <asp:Label ID="lblNomeProdotto" runat="server" Text=""></asp:Label></div>
                <p class="text-gray-700 text-base">
                    <asp:Label ID="lblDescrizione" runat="server" Text=""></asp:Label></p>
                <asp:Label ID="lblPrezzo" runat="server" CssClass="text-gray-700 text-base"></asp:Label>
                <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al carrello" OnClick="BtnAggiungiAlCarrello_Click" />
            </div>
        </div>
    </form>
</body>
</html>