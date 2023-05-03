namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Img { get; set; }

        public Pizza(long id, string nome, string descrizione, decimal prezzo, string img)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Img = img;
        }
    }
}
