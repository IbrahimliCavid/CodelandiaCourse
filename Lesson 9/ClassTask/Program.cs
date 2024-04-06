using System.Text;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Library library = new Library();


            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Enter a book \n" +
                    "2 - Delete a book \n" +
                    "3 - Show books list \n" +
                    "4 - Update book \n" +
                    "5 - Leave program");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Enter a book name: ");
                        string nameBook = Console.ReadLine();
                        Console.WriteLine("Enter author name: ");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter page size of book: ");
                        int pageSize = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter price of book: ");
                        double price =Convert.ToDouble( Console.ReadLine());
                        Console.WriteLine("Is the book in stock?: ");
                        bool isStock = Convert.ToBoolean( Console.ReadLine());

                        Book book = new Book()
                        {
                            Name = nameBook,
                            Author = author,
                            PageSize = pageSize,
                            Price = price,
                            IsStock = isStock,
                        };
                        library.AddBook(book);
                        

                        break;
                        case 2:
                        Console.WriteLine("Please enter the name of the book delete: ");
                        string deleteName = Console.ReadLine();
                        library.DeleteBook(deleteName);
                        break;
                    case 3:
                        List<Book> bookList = library.GetBookList();
                        foreach (var item in bookList)
                        {
                            Console.WriteLine($"Book name: {item.Name} \n" +
                                $"Author name: {item.Author} \n" +
                                $"Book price: {item.Price} \n" +
                                $"Is stock: {item.IsStock} \n" +
                                $"Page size: {item.PageSize}\n" +
                                $"-------------------------");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Please enter the name of the book update: ");
                        string updateBook = Console.ReadLine();

                        Console.WriteLine("Enter a book name: ");
                        string upNameBook = Console.ReadLine();
                        Console.WriteLine("Enter author name: ");
                        string upAuthor = Console.ReadLine();
                        Console.WriteLine("Enter page size of book: ");
                        int upPageSize = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter price of book: ");
                        double upPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Is the book in stock?: ");
                        bool upIsStock = Convert.ToBoolean(Console.ReadLine());

                        Book upBook = new Book()
                        {
                            Name = upNameBook,
                            Author = upAuthor,
                            PageSize = upPageSize,
                            Price = upPrice,
                            IsStock = upIsStock,
                        };

                        library.UpdateBook(updateBook, upBook);
                        break;
                    case 5:
                        Console.WriteLine("Leaving program...");
                        break;

                    default:
                        Console.WriteLine("Please enter a true button. (1 2 3 4 5)");
                        break;

                }
            }


        }
        public class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public int PageSize { get; set; }
            public bool IsStock { get; set; }
            public double Price { get; set; }

        }

        public class Library
        {
            
             List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
            }

            public List<Book> GetBookList()
            {
                return books;
            }

            public void DeleteBook(string deleteBook)
            {
               Book finded =  books.Find(x =>x.Name == deleteBook);
                books.Remove(finded);
            }

            public void UpdateBook(string updateBook, Book newBook)
            {
                Book finded = books.Find(x => x.Name == updateBook);
                int index =  books.IndexOf(finded);
                books.RemoveAt(index);
                books.Insert(index, newBook);
            }
        }
    }
}
