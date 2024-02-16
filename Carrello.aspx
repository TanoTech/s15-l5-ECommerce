﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="WonkaShopCarrello.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/tailwindcss@2.2.19/dist/tailwind.min.css" rel="stylesheet" defer="" />
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
           <div class="flex flex-col">
               <h1 class="text-3xl font-semibold mt-8 mb-4">Prodotti nel Carrello</h1>
               <asp:Button runat="server" Text="Svuota Carrello" OnClick="SvoutaCarrello_Click"></asp:Button>
           </div>
           <div class="w-full flex">
               <div class="flex-grow">
                   <asp:Repeater ID="ProdottiNelCarrelloRepeater" runat="server" OnItemDataBound="ProdottiNelCarrelloRepeater_ItemDataBound">
                       <ItemTemplate>
                           <div class="max-w-screen-xl mx-auto rounded overflow-hidden shadow-lg">
                               <div class="px-6 py-4 flex">
                                   <div class="h-20 w-40">
                                       <img class="object-fit" src='<%# DataBinder.Eval(Container.DataItem, "Prodotto.Immagine") %>' alt='<%# DataBinder.Eval(Container.DataItem, "Prodotto.Nome") %>'>
                                   </div>
                                   <div class="ml-4">
                                       <div class="font-bold text-xl mb-2"><%# DataBinder.Eval(Container.DataItem, "Prodotto.Nome") %></div>
                                       <p class="text-gray-700 text-base">Prezzo: <%# DataBinder.Eval(Container.DataItem, "Prodotto.Prezzo") %> €/KG</p>
                                       <p>Quantità: </p>
                                       <asp:TextBox runat="server" ID="QuantitaTextBox" Text='<%# DataBinder.Eval(Container.DataItem, "Quantita") %>' Width="50"></asp:TextBox>
                                       <asp:Button runat="server" Text="Aggiorna" CommandName="Aggiorna" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' OnCommand="AggiornaQuantita_Click" />
                                       <asp:Button runat="server" Text="Rimuovi dal Carrello" CommandName="Rimuovi" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' OnCommand="RimuoviOggetto_Click" />
                                   </div>
                               </div>
                           </div>
                       </ItemTemplate>
                   </asp:Repeater>
               </div>
               <div id="totaleCarrello" runat="server" class="flex-grow-0 flex-basis-1/4">
                   <p>Totale:</p>
                   <asp:Label runat="server" ID="TotaleCarrelloLabel"></asp:Label>
               </div>
           </div>
       </div>

    </form>
</body>
</html>
