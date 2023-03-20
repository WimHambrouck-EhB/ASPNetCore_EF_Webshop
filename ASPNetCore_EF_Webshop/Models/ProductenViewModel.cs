namespace Webshop.Models
{
    /// <summary>
    /// ViewModel voor /Home/Producten, omdat we aan deze Viez zowel de Categorie als de lijst van Producten willen doorgeven
    /// </summary>
    public class ProductenViewModel
    {
        public Categorie Categorie { get; set; }
        public IEnumerable<Product> Producten { get; set; }
    }
}
