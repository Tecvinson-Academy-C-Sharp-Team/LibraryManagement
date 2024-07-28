using System.Threading.Channels;
using LibraryManagement.BusinessLogic.Service;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;

Console.WriteLine("Welcome to C# group Library Management System!");
Console.WriteLine("How can I be of service?");

Book book = new Book()
{
    Id = 1,
    Title = "Things fall apart"
};

//ILibraryService libraryService = new LibraryService(new());
//libraryService.AddBookToLibrary(book);

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 5, 6, 3, 7, 7, 8, 9, 8, 10 };
var evenNumbs = new List<int>();
for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] == 0)
        return;

    bool isEven = i % 2 == 0;
    if (isEven)
    {
        evenNumbs.Add(i);
        Console.WriteLine($"This is an even number: {i}");
    }
}

numbers.Where(e => e % 2 == 0).ToList().ForEach(num => Console.WriteLine($"This is from Linq: {num}"));
var groups = numbers.GroupBy(e => e % 2 == 0);
//Console.WriteLine(numbers.First());
//Console.WriteLine(numbers.Last());
numbers.Select(num => num * num).Distinct().ToList().ForEach(i => Console.WriteLine(i));
Console.WriteLine(numbers.Any());
var response = new List<Book>();
response.Add(book);
if (response is not null)
{
}

var isValidBook = from bookObj in response
                  where bookObj.Title.Equals("Things fall apart")
                  select bookObj;