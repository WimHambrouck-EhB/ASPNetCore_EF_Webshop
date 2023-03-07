using System.ComponentModel.DataAnnotations;

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
    }
}