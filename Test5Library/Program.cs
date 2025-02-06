namespace Test5Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, new List<string> { "George Orwell" }); // list
            Book bookTwo = new Book("The Documents in the Case", 2002, new List<string> { "Dorothy Sayers", "Robert Eustace" }); // list
            Book bookThree = new Book("The Documents in the Case", 1930, new List<string>()); // list

            Library library = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
