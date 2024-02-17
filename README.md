[![Demo](https://img.youtube.com/vi/MM26W3Bd5lo/0.jpg)](https://youtu.be/MM26W3Bd5lo)
Clicca per guardare il demo video.

Piattaforma di E-commerce

# Funzionalità Principali
## 1. Vetrina Prodotti (VetrinaProdotti.aspx)
Mostra una lista di prodotti disponibili per l'acquisto.
Gli utenti possono filtrare i prodotti per categoria.
Ogni prodotto mostra il nome, il prezzo, la categoria e due pulsanti: "Aggiungi al carrello" e "Visualizza dettagli".
## 2. Dettagli Prodotto (Dettagli.aspx)
Visualizza i dettagli di un singolo prodotto selezionato.
Mostra l'immagine del prodotto, il nome, la descrizione, il prezzo e un pulsante "Aggiungi al carrello".
## 3. Carrello degli Acquisti (Carrello.aspx)
Visualizza i prodotti aggiunti al carrello dall'utente.
Per ogni prodotto nel carrello, mostra l'immagine, il nome, il prezzo, la quantità e i pulsanti per aggiornare la quantità o rimuovere il prodotto dal carrello.
Visualizza il totale del carrello.
Consente di svuotare completamente il carrello.
# Componenti del Progetto
### VetrinaProdotti.aspx - Pagina per visualizzare i prodotti disponibili e consentire agli utenti di aggiungerli al carrello.
### Dettagli.aspx - Pagina per visualizzare i dettagli di un singolo prodotto e consentire agli utenti di aggiungerlo al carrello. 
    Se l'utente cambia l'url inserendo qualsiasi stringa o id non esistente viene rimandato alla vetrina.
### Carrello.aspx - Pagina per gestire il carrello degli acquisti, visualizzare i prodotti aggiunti e completare l'acquisto.
### Stile.css - File CSS per la formattazione delle pagine HTML, con l'utilizzo di Tailwind CSS per semplificare lo sviluppo e migliorare la progettazione.
### contatore.js - Conta il numero di articoli nel carrello e lo rimanda alla navbar.
