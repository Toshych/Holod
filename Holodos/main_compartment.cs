

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
            public void PutProduct(Product Product)
            {
                shelf.Add(Product);
            }
            public void TakeProduct(string name)
            {
                var Product = shelf.Find(p => p.Name == name);
                shelf.Remove(Product);
            }
        public void ShowProducts()
        {
            if (shelf.Count == 0)
            {
                Console.WriteLine("Полка пуста!");
                return;
            }

            Console.WriteLine("На полке:");
            foreach (Product p in shelf)
            {
                Console.WriteLine($"- {p.Name}");
            }
        }
        }
    public class MainCompartment : Compartment;
    public class Freezer : Compartment;
    public class DoorShelf : Compartment;
}
