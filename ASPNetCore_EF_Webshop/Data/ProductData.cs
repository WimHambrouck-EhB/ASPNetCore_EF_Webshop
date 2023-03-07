using Webshop.Models;

namespace Webshop.Data
{
    public static class ProductData
    {
        public static IEnumerable<Product> Producten { get; private set; }

        static ProductData()
        {
            Producten = new List<Product>
            {
                new Product { Naam =  "PS5", Beschrijving = "PlayStation 5 + Sony PlayStation 5 DualSense draadloze controller. Aan een veel te hoge prijs, wegens overal uitverkocht.", Categorie = Categorie.Consoles, Prijs = 799.99M},
                new Product { Naam =  "XBox", Beschrijving = "Xbox Series X", Categorie = Categorie.Consoles, Prijs = 499.99M},
                new Product { Naam =  "Console: The Console", Beschrijving = "Supermegasnelle console met graphics en hardware en meer van dat lekkers", Categorie = Categorie.Consoles, Prijs = 9999.99M},
                new Product { Naam =  "KFConsole", Beschrijving = "Forged from the fires of the KFC ovens, there has never been a tastier way to experience the latest titles in stunning 4k, 240fps.", Categorie = Categorie.Consoles, Prijs = 499.99M},
                new Product { Naam =  "Game: The Game", Beschrijving = "Super leuk spelletje", Categorie = Categorie.Games, Prijs = 999.99M},
                new Product { Naam =  "Aging Wreath", Beschrijving = "Top 10 game of 2022", Categorie = Categorie.Games, Prijs = 44.44M},
                new Product { Naam =  "Deity of Strife Gotterdammerung", Beschrijving = "Top 10 game of 2022", Categorie = Categorie.Games, Prijs = 55.55M},
                new Product { Naam =  "Skyline Prohibited Occident", Beschrijving = "Top 10 game of 2022", Categorie = Categorie.Games, Prijs = 33.33M},
                new Product { Naam =  "Request of Assignment: Innovative Military Action", Beschrijving = "Top 10 game of 2022", Categorie = Categorie.Games, Prijs = 66.66M},
                new Product { Naam =  "Blade Runner Whiskey Glasses", Beschrijving = "The perfect gift for booze-loving Blade Runner fans", Categorie = Categorie.Gadgets, Prijs = 138.99M},
                new Product { Naam =  "PlayStation Alarm Clock", Beschrijving = "Alarm clock in the shape of a PS4 controller. Better then using your phone's alarm anyway...", Categorie = Categorie.Gadgets, Prijs = 28.99M},
                new Product { Naam =  "Tetris Stackable Toy Light", Beschrijving = "Multicoloured novelty lamp featuring seven different Tetromino shapes which light up once they come into contact with each other.", Categorie = Categorie.Gadgets, Prijs = 37.98M},
                new Product { Naam =  "Gaming head set", Beschrijving = "Look! Is it a headphone? Is it a microphone? Nope... it's BOTH!", Categorie = Categorie.Gear, Prijs = 149.99M},
                new Product { Naam =  "HyperX Keyboard", Beschrijving = "The keys are made of solid tritanium. Featuring a completely useless \"calculator\" button.", Categorie = Categorie.Gear, Prijs = 83.99M},
                new Product { Naam =  "PDMLV55 Wireless Mouse", Beschrijving = "Featuring over 254 detachable buttons, it will turn (you) into the ultimate gaming tool.", Categorie = Categorie.Gear, Prijs = 255.99M},
                new Product { Naam =  "Aceus HAL PG051651XXQ Monitor", Beschrijving = "A 65K 69inch 360° 5D monitor with a resolution up to 51000p and a 840hz refresh rate.  Will make your games come to life... literally. VGA cable included.", Categorie = Categorie.Gear, Prijs = 9999.99M}
            };
        }

    }
}
