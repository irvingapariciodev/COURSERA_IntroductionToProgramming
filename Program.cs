using System.ComponentModel.Design;

public class Program
{
    public static async Task Main(string[] args)
    {
        const string applicationName = "Welcome to Coursera - Introduction to Programming in C# module app.";
        const string application1Name = "Simulated single download";
        const string application2Name = "Simulated multiple download";
        const string application3Name = "Fetching Product Data Asynchronously";
        const string application4Name = "Fetching Product and Reviews Data Asynchronously";
        const string application5Name = "Perform Long Operation Async";
        const string application6Name = "Validate age with Copilot";
        const string application7Name = "Sort a list and get average with Copilot";
        const string application8Name = "Simple library management system";
        const string application9Name = "Loop to sum from 1 to 100 with Copilot";
        const string application10Name = "Exit";
        Console.WriteLine(applicationName);

        bool openMenubar = true;
        while (openMenubar)
        {
            Console.WriteLine("Please select one of the options in the main menu:");
            Console.WriteLine($"1 -{application1Name} ");
            Console.WriteLine($"2 -{application2Name} ");
            Console.WriteLine($"3 -{application3Name} ");
            Console.WriteLine($"4 -{application4Name} ");
            Console.WriteLine($"5 -{application5Name} ");
            Console.WriteLine($"6 -{application6Name} ");
            Console.WriteLine($"7 -{application7Name} ");
            Console.WriteLine($"8 -{application8Name} ");
            Console.WriteLine($"9 -{application9Name} ");
            Console.WriteLine($"10 -{application10Name} ");
            Console.WriteLine($"\n");

            string optionSelected = Console.ReadLine();
            int menuSelected = 0;
            openMenubar = int.TryParse(optionSelected, out menuSelected);

            switch (menuSelected)
            {
                /// <summary>
                /// Simulate a single asynchronous method using async and await.
                /// </summary>
                case 1:
                    try
                    {
                        Console.WriteLine($"You selected: {application1Name}");
                        Console.WriteLine("Starting process...");
                        await SimulatedSingleDownloadDataAsync();
                        Console.WriteLine("Finished process.\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }

                    break;
                /// <summary>
                /// Simulate a multiple asynchronous method using async and await.
                /// </summary>
                case 2:
                    Console.WriteLine($"You selected: {application2Name}");
                    try
                    {
                        await Task.WhenAll(SimulatedSingleDownloadDataAsync(), SimulatedMultipleDownloadDataAsync());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }

                    break;
                /// <summary>
                /// Show a simulated product list asynchronous.
                /// </summary>
                case 3:
                    Console.WriteLine($"You selected: {application3Name}");
                    Product productList = new Product();
                    await productList.ShowProductAsync();
                    break;
                /// <summary>
                /// Show a simulated product list and review list asynchronous.
                /// </summary>
                case 4:
                    Console.WriteLine($"You selected: {application4Name}");
                    Review reviewList = new Review();
                    Product productList2 = new Product();
                    await Task.WhenAll(reviewList.ShowReviewAsync(), productList2.ShowProductAsync());
                    break;
                /// <summary>
                /// Show a simulated delay response asynchronously.
                /// </summary>
                case 5:
                    Console.WriteLine($"You selected: {application5Name}");
                    Task.Run(async () => await PerformLongOperationAsync()).Wait();
                    Console.WriteLine("Completed.\n");
                    break;
                /// <summary>
                /// Request the user age and validate if it is between range, it was generated with Copilot.
                /// </summary>
                case 6:
                    Console.WriteLine($"You selected: {application6Name}");
                    int age = 0;
                    bool isValid = false;

                    while (!isValid)
                    {
                        Console.Write("Please enter your age (1–120): ");
                        string input = Console.ReadLine();

                        if (!int.TryParse(input, out age))
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                            continue;
                        }

                        if (age < 1 || age > 120)
                        {
                            Console.WriteLine("Age must be between 1 and 120.");
                            continue;
                        }

                        isValid = true;
                    }
                    Console.WriteLine($"Your age is: {age}\n");
                    break;
                /// <summary>
                /// Sort a simulated list, then sort and get average, it was generated with Copilot.
                /// </summary>
                case 7:
                    Console.WriteLine($"You selected: {application7Name}");
                    List<int> numbers = new List<int> { 12, 5, 8, 20, 3, 15 };

                    Console.WriteLine("Numbers to sort: :");
                    foreach (int number in numbers)
                    {
                        Console.Write(number + " ");
                    }

                    numbers.Sort();

                    double average = numbers.Average();

                    Console.WriteLine("\nSorted numbers:");
                    foreach (int number in numbers)
                    {
                        Console.Write(number + " ");
                    }

                    Console.WriteLine($"\nAverage value: {average:F2}\n");
                    break;
                /// <summary>
                /// Library management system, allows to add, remove, show and search books for a user.
                /// </summary>
                /// <param name="users">Collection of registered users.</param>
                /// <param name="library">Available books in the library.</param>
                case 8:
                    Console.WriteLine($"You selected: {application8Name}");
                    List<string> library = new List<string>();
                    const int MaxBooks = 5;
                    bool running = true;
                    List<User> users = new List<User>();
                    const int MaxBorrowLimit = 3;

                    while (running)
                    {
                        Console.WriteLine("\n--- Library Menu ---");
                        Console.WriteLine("1. Add a book");
                        Console.WriteLine("2. Remove a book");
                        Console.WriteLine("3. Show all books");
                        Console.WriteLine("4. Search for a book");
                        Console.WriteLine("5. Add user");
                        Console.WriteLine("6. Borrow a book");
                        Console.WriteLine("7. Return a book");
                        Console.WriteLine("8. Show users");
                        Console.WriteLine("9. Check in a book");
                        Console.WriteLine("10. Exit");
                        Console.Write("Choose an option: ");

                        string choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "1":
                                AddBook(library, MaxBooks);
                                break;

                            case "2":
                                RemoveBook(library);
                                break;

                            case "3":
                                ShowBooks(library);
                                break;

                            case "4":
                                SearchBook(library);
                                break;

                            case "5":
                                AddUser(users);
                                break;

                            case "6":
                                BorrowBook(users, library, MaxBorrowLimit);
                                break;

                            case "7":
                                ReturnBook(users,library);
                                break;

                            case "8":
                                ShowUsers(users);
                                break;

                            case "9":
                                CheckInBook(users, library);
                                break;

                            case "10":
                                running = false;
                                Console.WriteLine("Goodbye!\n");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Try again./n");
                                break;
                        }
                    }
                    break;
                /// <summary>
                /// Library management system, allows to add, remove, show and search books for a user.
                /// </summary>
                /// <param name="users">Collection of registered users.</param>
                /// <param name="library">Available books in the library.</param>
                case 9:
                    Console.WriteLine($"You selected: {application9Name}");
                    int sum = 0;

                    sum = 100 * 101 / 2;

                    Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}.\n");
                    break;
                /// <summary>
                /// Exit the main menu.
                /// </summary>
                case 10:
                    Console.WriteLine($"You selected: {application10Name}");
                    openMenubar = false;
                    break;
                /// <summary>
                /// Invalid selection user input to display the menu.
                /// </summary>
                default:
                    Console.WriteLine("Please enter a valid entry.\n");
                    openMenubar = true;
                    break;
            }
        }
    }

    public static async Task SimulatedSingleDownloadDataAsync()
    {
        Console.WriteLine("First download starting...");
        await Task.Delay(3000);
        Console.WriteLine("Download completed.");
    }

    public static async Task SimulatedMultipleDownloadDataAsync()
    {
        Console.WriteLine("Second download starting...");
        await Task.Delay(8000);
        Console.WriteLine("Download completed.");
    }

    public class Product
    {
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public Product()
        {
        }

        public async Task<List<Product>> FecthProductsListAsync()
        {
            await Task.Delay(2000);
            return new List<Product>
            {
                new Product ("PlayStation 5"),
                new Product ("Nintendo Switch")
            };
        }

        public async Task ShowProductAsync()
        {
            List<Product> products = await FecthProductsListAsync();

            foreach (var product in products)
            {
                Console.WriteLine($"Product name: {product.Name}\n");
            }
        }
    }

    public class Review
    {
        public string Content { get; set; }

        public Review() { }

        public Review(string content)
        {
            Content = content;
        }
        public async Task<List<Review>> FecthReviewListAsync()
        {
            await Task.Delay(3000);
            return new List<Review>
            {
                new Review ("Great product!"),
                new Review ("Good value for the money.")
            };
        }
        public async Task ShowReviewAsync()
        {
            List<Review> reviews = await FecthReviewListAsync();

            foreach (var review in reviews)
            {
                Console.WriteLine($"Review content: {review.Content}\n");
            }
        }
    }

    public static async Task PerformLongOperationAsync()
    {
        try
        {
            await Task.Delay(10000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing.{ex.Message}");
            throw;
        }
    }

    public static void AddBook(List<string> library, int maxBooks)
    {
        if (library.Count >= maxBooks)
        {
            Console.WriteLine("Library is full. You cannot add more than 5 books.");
            return;
        }

        Console.Write("Enter the book title: ");
        string title = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Book title cannot be empty.");
            return;
        }

        library.Add(title);
        Console.WriteLine("Book added successfully.");
    }

    static void RemoveBook(List<string> library)
    {
        if (library.Count == 0)
        {
            Console.WriteLine("Library is empty. Nothing to remove.");
            return;
        }

        ShowBooks(library);
        Console.Write("Enter the number of the book to remove: ");

        if (int.TryParse(Console.ReadLine(), out int index) &&
            index >= 1 && index <= library.Count)
        {
            library.RemoveAt(index - 1);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    static void ShowBooks(List<string> library)
    {
        if (library.Count == 0)
        {
            Console.WriteLine("No books in the library.");
            return;
        }

        Console.WriteLine("\nBooks in the library:");
        for (int i = 0; i < library.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {library[i]}");
        }
    }

    static void SearchBook(List<string> library)
    {
        if (library.Count == 0)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.Write("Enter book title to search: ");
        string searchTerm = Console.ReadLine();

        bool found = false;

        Console.WriteLine("\nSearch results:");

        for (int i = 0; i < library.Count; i++)
        {
            if (library[i].Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{i + 1}. {library[i]}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching books found.");
        }
    }

    public class User
    {
        public string Name { get; set; }
        public List<string> BorrowedBooks { get; set; }

        public User(string name)
        {
            Name = name;
            BorrowedBooks = new List<string>();
        }
    }

    public static void AddUser(List<User> users)
    {
        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("User name cannot be empty.");
            return;
        }

        users.Add(new User(name));
        Console.WriteLine("User added successfully.");
    }

    public static void BorrowBook(List<User> users, List<string> library, int maxLimit)
    {
        Console.Write("Enter user name: ");
        string userName = Console.ReadLine();

        User user = users.Find(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (user.BorrowedBooks.Count >= maxLimit)
        {
            Console.WriteLine("Borrow limit reached.");
            return;
        }

        if (library.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
            return;
        }

        ShowBooks(library);
        Console.Write("Enter book number to borrow: ");

        if (!int.TryParse(Console.ReadLine(), out int index) ||
            index < 1 || index > library.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        string book = library[index - 1];
        library.RemoveAt(index - 1);
        user.BorrowedBooks.Add(book);

        Console.WriteLine($"{user.Name} borrowed \"{book}\"");
    }

    public static void ReturnBook(List<User> users, List<string> library)
    {
        Console.Write("Enter user name: ");
        string userName = Console.ReadLine();

        User user = users.Find(u =>  u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (user.BorrowedBooks.Count == 0)
        {
            Console.WriteLine("This user has no borrowed books.");
            return;
        }

        Console.WriteLine("\nBorrowed books:");
        for (int i = 0; i < user.BorrowedBooks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {user.BorrowedBooks[i]}");
        }

        Console.Write("Select the book number to return: ");
        if (!int.TryParse(Console.ReadLine(), out int selection) ||
            selection < 1 || selection > user.BorrowedBooks.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        string returnedBook = user.BorrowedBooks[selection - 1];

        user.BorrowedBooks.RemoveAt(selection - 1);
        library.Add(returnedBook);

        Console.WriteLine($"\"{returnedBook}\" has been returned successfully.");
    }

    public static void ShowUsers(List<User> users)
    {
        if (users == null || users.Count == 0)
        {
            Console.WriteLine("No users available.");
            return;
        }

        Console.WriteLine("\nUsers:");
        Console.WriteLine("------");

        foreach (var user in users)
        {
            int borrowedCount = user.BorrowedBooks?.Count ?? 0;

            Console.WriteLine(
                $"{user.Name} | Borrowed books: {borrowedCount}");
        }
    }
    public static void CheckInBook(List<User> users, List<string> library)
    {
        Console.Write("Enter user name: ");
        string userName = Console.ReadLine();

        User user = users.Find(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        if (user.BorrowedBooks.Count == 0)
        {
            Console.WriteLine("User has no borrowed books.");
            return;
        }

        Console.WriteLine("\nBorrowed books:");
        for (int i = 0; i < user.BorrowedBooks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {user.BorrowedBooks[i]}");
        }

        Console.Write("Enter book number to check in: ");

        if (!int.TryParse(Console.ReadLine(), out int index) ||
            index < 1 || index > user.BorrowedBooks.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        string returnedBook = user.BorrowedBooks[index - 1];
        user.BorrowedBooks.RemoveAt(index - 1);
        library.Add(returnedBook);

        Console.WriteLine($"\"{returnedBook}\" has been checked in successfully.");
    }
}