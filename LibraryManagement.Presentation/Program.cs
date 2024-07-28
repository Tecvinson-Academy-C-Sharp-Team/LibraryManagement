using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using LibraryManagement.BusinessLogic.Service;
using LibraryManagement.Data.Service;


var libraryContext = new LibraryContext();
var libraryService = new LibraryService(libraryContext);
var userService = new MemberService(libraryContext);

libraryService.OnBookAdded += message => Console.WriteLine($"Event: {message}");
libraryService.OnBookRemoved += message => Console.WriteLine($"Event: {message}");
libraryService.OnBorrowLibraryItem += message => Console.WriteLine($"Event: {message}");
libraryService.OnReturnLibraryItem += message => Console.WriteLine($"Event: {message}");

bool running = true;

while (running)
{
    Console.WriteLine("Library Management System");
    Console.WriteLine("Are you a new user or an old user?");
    Console.WriteLine("1. New User");
    Console.WriteLine("2. Old User");
    Console.WriteLine("3. Exit");

    Console.Write("Choose an option: ");
    string userChoice = Console.ReadLine();

    if (userChoice == "1")
    {
        // New user registration
        await RegisterNewUser(userService);
    }
    else if (userChoice == "2")
    {
        // Existing user operations
        Console.Write("Enter MemberID: ");
        if (long.TryParse(Console.ReadLine(), out long memberId))
        {
            var member = await userService.GetUserById(memberId);
            if (member != null)
            {
                Console.WriteLine($"Welcome back, {member.Name}!");
                await PerformUserOperations(libraryService, userService);
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid MemberID.");
        }
    }
    else if (userChoice == "3")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}
        

        static async Task RegisterNewUser(MemberService userService)
{
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter Email: ");
    string email = Console.ReadLine();

    var newMember = new Member
    {
        Id = new Random().Next(1, 1000), // Generate a random ID
        Name = name,
        Email = email,
        IsAdmin = false,
        IsActive = true,
        CreatedOn = DateTime.Now,
        UpdatedOn = DateTime.Now
    };

    bool result = await userService.AddNewUser(newMember);
    if (result)
    {
        Console.WriteLine("Registration successful. Welcome!");
    }
    else
    {
        Console.WriteLine("Registration failed. Please try again.");
    }
}

static async Task PerformUserOperations(LibraryService libraryService, MemberService userService)
{
    bool userOperationRunning = true;

    while (userOperationRunning)
    {
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Add DVD");
        Console.WriteLine("3. Add Magazine");
        Console.WriteLine("4. Borrow Item");
        Console.WriteLine("5. Return Item");
        Console.WriteLine("6. Update Member");
        Console.WriteLine("7. Delete Member");
        Console.WriteLine("8. List Members");
        Console.WriteLine("9. Exit");

        Console.Write("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                await AddBook(libraryService);
                break;
            case "2":
                await AddDVD(libraryService);
                break;
            case "3":
                await AddMagazine(libraryService);
                break;
            case "4":
                await BorrowItem(libraryService);
                break;
            case "5":
                await ReturnItem(libraryService);
                break;
            case "6":
                await UpdateMember(userService);
                break;
            case "7":
                await DeleteMember(userService);
                break;
            case "8":
                await ListMembers(userService);
                break;
            case "9":
                userOperationRunning = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}

static async Task AddBook(LibraryService libraryService)
{
    Console.Write("Enter Book Title: ");
    string title = Console.ReadLine();
    Console.Write("Enter Author: ");
    string author = Console.ReadLine();
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();

    var book = new Book
    {
        Id = new Random().Next(1, 1000), // Generate a random ID
        Title = title,
        Author = author,
        ISBN = isbn,
        CreatedOn = DateTime.Now,
        UpdatedOn = DateTime.Now
    };

    await libraryService.AddBookToLibrary(book);
}

static async Task AddDVD(LibraryService libraryService)
{
    Console.Write("Enter DVD Title: ");
    string title = Console.ReadLine();
    Console.Write("Enter Director: ");
    string director = Console.ReadLine();
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();

    var dvd = new DVD
    {
        Id = new Random().Next(1, 1000), // Generate a random ID
        Title = title,
        Author = director,
        ISBN = isbn,
        CreatedOn = DateTime.Now,
        UpdatedOn = DateTime.Now
    };

    await libraryService.AddDVDToLibrary(dvd);
}

static async Task AddMagazine(LibraryService libraryService)
{
    Console.Write("Enter Magazine Title: ");
    string title = Console.ReadLine();
    Console.Write("Enter Publisher: ");
    string publisher = Console.ReadLine();
    Console.Write("Enter ISBN: ");
    string isbn = Console.ReadLine();

    var magazine = new Magazine
    {
        Id = new Random().Next(1, 1000), // Generate a random ID
        Title = title,
        Author = publisher,
        ISBN = isbn,
        CreatedOn = DateTime.Now,
        UpdatedOn = DateTime.Now
    };

    await libraryService.AddMagazineToLibrary(magazine);
}

static async Task BorrowItem(LibraryService libraryService)
{
    Console.Write("Enter Item Title to Borrow: ");
    string title = Console.ReadLine();

    var item = await libraryService.BorrowLibraryItem(title);
    if (item != null)
    {
        Console.WriteLine($"Borrowed Item: {item}");
    }
    else
    {
        Console.WriteLine("Item not found.");
    }
}

static async Task ReturnItem(LibraryService libraryService)
{
    Console.Write("Enter Item Title to Return: ");
    string title = Console.ReadLine();

    var item = new LibraryItem(); // Create a LibraryItem instance for returning
                                  // You should set the item details here (fetch from the libraryService if needed)

    await libraryService.ReturnLibraryItem(item);
    Console.WriteLine($"Returned Item: {title}");
}

static async Task UpdateMember(MemberService userService)
{
    Console.Write("Enter MemberID to Update: ");
    if (long.TryParse(Console.ReadLine(), out long memberId))
    {
        var member = await userService.GetUserById(memberId);
        if (member != null)
        {
            Console.Write("Enter New Name (leave blank to keep unchanged): ");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name)) member.Name = name;

            Console.Write("Enter New Email (leave blank to keep unchanged): ");
            string email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email)) member.Email = email;

            // You can update other fields if needed here

            await userService.UpdateUser(member);
            Console.WriteLine("Member updated successfully.");
        }
        else
        {
            Console.WriteLine("Member not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid MemberID.");
    }
}

static async Task DeleteMember(MemberService userService)
{
    Console.Write("Enter MemberID to Delete: ");
    if (long.TryParse(Console.ReadLine(), out long memberId))
    {
        var member = await userService.GetUserById(memberId);
        if (member != null)
        {
            await userService.DeleteUser(member);
            Console.WriteLine("Member deleted successfully.");
        }
        else
        {
            Console.WriteLine("Member not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid MemberID.");
    }
}

static async Task ListMembers(MemberService userService)
{
    Console.WriteLine("Listing all members...");
    // This method assumes that GetUserById can return a list or similar. Adjust according to your actual method.
    // If you need to list all members, you might need to implement a new method in IUserService and UserService.

    // Example:
    // var members = await userService.GetAllUsers();
    // foreach (var member in members)
    // {
    //     Console.WriteLine($"{member.Id}: {member.Name} ({member.Email})");
    // }
}


