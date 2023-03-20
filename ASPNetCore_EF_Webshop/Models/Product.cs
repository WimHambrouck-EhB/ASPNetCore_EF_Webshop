using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webshop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Naam { get; set; } = string.Empty;
        public string Beschrijving { get; set; } = string.Empty;
        public Categorie Categorie { get; set; }
        [DataType(DataType.Currency)]
        public decimal Prijs { get; set; }
        [NotMapped]
        public int Aantal { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Naam={Naam}, Beschrijving={Beschrijving}, Categorie={Categorie}, Prijs={Prijs}, Aantal={Aantal}";
        }


    }
}