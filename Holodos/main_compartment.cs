

namespace Holodos
{
    public class Product
    {
        public string Name;
    }

        public abstract class Compartment
        {
        public string Name;

        protected List<Product> shelf = new List<Product>();
            public void PutProduct(Product Eda)
            {
                shelf.Add(Eda);
            }
        public bool TakeProduct(string name)
        {
            var Product = shelf.Find(p => p.Name == name);
            if (Product != null)
            {
                shelf.Remove(Product);
                return true;
            }
            return false;
        }
        public void ShowProducts()
        {
            if (shelf.Count == 0)
            {
                Console.WriteLine("Отсек пуст!");
                return;
            }

            Console.WriteLine("В отсеке:");
            shelf.ForEach(p => Console.WriteLine($"- {p.Name}"));
        }
        }
    public class MainCompartment : Compartment;
    public class Freezer : Compartment;
    public class DoorShelf : Compartment;
}
