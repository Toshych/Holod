
using System.IO;
namespace Holodos
{
    public class Product
    {
        public string Name;
    }

        public abstract class Compartment
        {
        public int GetProducts()
        {
            return shelf.Count;
        }
        public string Name;

        protected List<Product> shelf = new List<Product>();

        public void SaveFile()
        {
            string holodilnik =  $"{ this.GetType().Name }.txt";

            using (StreamWriter writer = new StreamWriter(holodilnik))
            {
                foreach (Product product in shelf)
                {
                    writer.WriteLine(product.Name);
                }
            }
            Console.WriteLine("Продукты сохранены в файл");
        }



        public void LoadFile ()
        {
            string holodilnik = $"{this.GetType().Name}.txt";

            if (File.Exists(holodilnik))
            {
                shelf.Clear();

                string[] lines = File.ReadAllLines(holodilnik);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Product eda = new Product(); 
                        eda.Name = line.Trim();
                        shelf.Add(eda);
                    }
                }
                Console.WriteLine("Продукты загружены из файла");
            }
            else
            {
                Console.WriteLine("Файл не найден, начинаем с пустым отсеком");
            }
        }
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
