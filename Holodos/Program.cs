

namespace Holodos
{
    class Program
    {
        static MainCompartment main = new MainCompartment();
        static DoorShelf door = new DoorShelf();
        static Freezer freezer = new Freezer();


        static void Main()
        {
            main.LoadFile();
            door.LoadFile();
            freezer.LoadFile();
            Thread.Sleep(1000);
            Console.Clear();

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
                        ShowMain();
                        break;
                        case "2":
                        ShowDoor();
                        break;
                        case "3":
                        ShowFreezer();
                        break;
                    case "0":
                        main.SaveFile();
                        door.SaveFile();
                        freezer.SaveFile();
                        isRunning = false;
                        break;
                        default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
        static void ShowMain()
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

                        Console.WriteLine("\nДоступные продукты:");
                        if (main.GetProducts() == 0)
                        {
                            Console.WriteLine("В отсеке нет продуктов!");
                            break;
                        }

                        main.ShowProducts();

                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        if (main.TakeProduct(productName))
                        {
                            Console.WriteLine("Продукт взят :))");
                            main.SaveFile();
                        }
                        else
                        {
                            Console.WriteLine("Продукта нет в отсеке :((");
                        }

                        break;

                    case "3":
                        string newProductName = "";
                        do
                        {
                            Console.Write("Введите название продукта (макс. 30 символов): ");
                            newProductName = Console.ReadLine()?.Trim() ?? "";

                            if (newProductName.Length > 30)
                            {
                                Console.WriteLine("Ошибка! Максимум 30 символов");
                            }
                        } while (newProductName.Length > 30);

                        Product eda = new Product();
                        eda.Name = newProductName;
                        main.PutProduct(eda);
                        main.SaveFile();

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

        static void ShowDoor()
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
                        Console.WriteLine("\nДоступные продукты:");
                        if (door.GetProducts() == 0)
                        {
                            Console.WriteLine("В отсеке нет продуктов!");
                            break;
                        }
                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        if (door.TakeProduct(productName))
                        {
                            Console.WriteLine("Продукт взят :))");
                            door.SaveFile();
                        }
                        else
                        {
                            Console.WriteLine("Продукта нет в отсеке :((");
                        }
                        break;
                    case "3":
                        string newProductName = "";
                        do
                        {
                            Console.Write("Введите название продукта (макс. 30 символов): ");
                            newProductName = Console.ReadLine()?.Trim() ?? "";

                            if (newProductName.Length > 30)
                            {
                                Console.WriteLine("Ошибка! Максимум 30 символов");
                            }
                        } while (newProductName.Length > 30);

                        Product eda = new Product();
                        eda.Name = newProductName;
                        door.PutProduct(eda);
                        door.SaveFile();

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

        static void ShowFreezer()
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
                        Console.WriteLine("\nДоступные продукты:");
                        if (freezer.GetProducts() == 0)
                        {
                            Console.WriteLine("В отсеке нет продуктов!");
                            break;
                        }
                        Console.Write("Какой продукт взять? ");
                        string productName = Console.ReadLine();
                        if (freezer.TakeProduct(productName))
                        {
                            Console.WriteLine("Продукт взят :))");
                            freezer.SaveFile();
                        }
                        else
                        {
                            Console.WriteLine("Продукта нет в отсеке :((");
                        }
                        break;
                    case "3":
                        string newProductName = "";
                        do
                        {
                            Console.Write("Введите название продукта (макс. 30 символов): ");
                            newProductName = Console.ReadLine()?.Trim() ?? "";

                            if (newProductName.Length > 30)
                            {
                                Console.WriteLine("Ошибка! Максимум 30 символов");
                            }
                        } while (newProductName.Length > 30);

                        Product eda = new Product();
                        eda.Name = newProductName;
                        freezer.PutProduct(eda);
                        freezer.SaveFile();

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

