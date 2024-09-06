using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice_1_Dedok
{
    //for task 1
    class Tovar
    {
        public string Name { get; set; }
        public string PlaceOfSale { get; set; }
        public float Price { get; set; }
        public Tovar(string name, string placeOfSale, float price)
        {
            Name = name;
            PlaceOfSale = placeOfSale;
            Price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Назва товару: {Name}");
            Console.WriteLine($"Місце продажу: {PlaceOfSale}");
            Console.WriteLine($"Ціна: {Price} грн");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ PlaceOfSale.GetHashCode() ^ Price.GetHashCode();
        }
    }
    class Igrashka : Tovar
    {
        public string AgeCategory { get; set; }
        public string PlaceOfManufacture { get; set; }
        public Igrashka(string name, string placeOfSale, float price, string ageCategory, string placeOfManufacture)
            : base(name, placeOfSale, price)
        {
            AgeCategory = ageCategory;
            PlaceOfManufacture = placeOfManufacture;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Назва іграшки: {Name}");
            Console.WriteLine($"Місце продажу: {PlaceOfSale}");
            Console.WriteLine($"Ціна: {Price} грн");
            Console.WriteLine($"Вікова категорія: {AgeCategory}");
            Console.WriteLine($"Місце виготовлення: {PlaceOfManufacture}");
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ PlaceOfSale.GetHashCode() ^ Price.GetHashCode() ^ AgeCategory.GetHashCode() ^ PlaceOfManufacture.GetHashCode();
        }
    }
}
