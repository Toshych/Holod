

namespace Holodos
{
    class Program
    {
        static MainCompartment main = new MainCompartment();
        static DoorShelf door = new DoorShelf();
        static Freezer freezer = new Freezer();
        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("ХОЛОДИЛЬНИК");
                Console.WriteLine("1. Основной отсек");
                Console.WriteLine("2. Дверной отсек");
                Console.WriteLine("3. Морозилка");
                Console.WriteLine("0. Выход");
                Console.WriteLine("Выбор: ");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        ShowMainCompartmentMenu();
                        break;
                        case "2":
                        ShowDoorShelfMenu();
                        break;
                        case "3":
                        ShowFreezerMenu();
                        break;
                    case "0":
                        isRunning = false;
                        break;
                        default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
        static void ShowMainCompartmentMenu()
        {
            bool inCompartment = true;

            while (inCompartment)
            {
                Console.WriteLine("ОСНОВНОЙ ОТСЕК");
                Console.WriteLine("1. Посмотреть продукты");
                Console.WriteLine("2. Взять продукты");
                Console.WriteLine("3. Положить продукт");
                Console.WriteLine("0. Назад");
                Console.WriteLine("Выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nСодержимое основного отсека:");
                        main.ShowProducts();
                        break;
                    case "2":
                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        main.TakeProduct(productName);
                        break;
                    case "3":
                        Console.Write("Введите название продукта: ");
                        string newProductName = Console.ReadLine();

                        Product product = new Product();
                        product.Name = newProductName;
                        main.PutProduct(product);

                        Console.WriteLine($"Продукт '{newProductName}' добавлен");
                        break;
                    case "0":
                        inCompartment = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void ShowDoorShelfMenu()
        {
            bool inCompartment = true;

            while (inCompartment)
            {
                Console.WriteLine("ДВЕРНОЙ ОТСЕК");
                Console.WriteLine("1. Посмотреть продукты");
                Console.WriteLine("2. Взять продукты");
                Console.WriteLine("3. Положить продукт");
                Console.WriteLine("0. Назад");
                Console.WriteLine("Выбор: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nСодержимое дверного отсека:");
                        door.ShowProducts();
                        break;
                    case "2":
                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        door.TakeProduct(productName);
                        break;
                    case "3":
                        Console.Write("Введите название продукта: ");
                        string newProductName = Console.ReadLine();

                        Product product = new Product();
                        product.Name = newProductName;
                        door.PutProduct(product);

                        Console.WriteLine($"Продукт '{newProductName}' добавлен");
                        break;
                    case "0":
                        inCompartment = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void ShowFreezerMenu()
        {
            bool inCompartment = true;

            while (inCompartment)
            {
                Console.WriteLine("МОРОЗИЛКА");
                Console.WriteLine("1. Посмотреть продукты");
                Console.WriteLine("2. Взять продукты");
                Console.WriteLine("3. Положить продукт");
                Console.WriteLine("0. Назад");
                Console.WriteLine("Выбор: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\nСодержимое морозилки:");
                        freezer.ShowProducts();
                        break;
                    case "2":
                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        freezer.TakeProduct(productName);
                        break;
                    case "3":
                        Console.Write("Введите название продукта: ");
                        string newProductName = Console.ReadLine();

                        Product product = new Product();
                        product.Name = newProductName;
                        freezer.PutProduct(product);

                        Console.WriteLine($"Продукт '{newProductName}' добавлен");
                        break;
                    case "0":
                        inCompartment = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
       
    }
}

