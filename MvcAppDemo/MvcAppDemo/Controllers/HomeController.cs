using Microsoft.AspNetCore.Mvc;
using MvcAppDemo.Models;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace MvcAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) //constructor based DI
        {
            _logger = logger;
        }

        public IActionResult Index() // html object IActionResult - it is a datatype
        {
            return View();
        }
        public IActionResult DoLogin(String txtUser, String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser} , {txtpwd} ";
            return View();

        }
        public IActionResult SayHello(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                ViewData["v1"] = "Your Data is Empty"; // dict [key] = "value" -> transportation of code(business logic) to the presentatin layer.
            }
            else
            {
                ViewData["v1"] = name;
            }
           
            return View();
        }
        public IActionResult Add(int x , int y)
        {
            int result = x + y;
            ViewData["Add result"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["Product"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["Divide"] = result;
            return View("Add");
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"c:\temp\book.txt";
            string content = $"{pBook.BookID} , {pBook.Title}, {pBook.AuthorName} , {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fName,true))
            {
                sw.WriteLine(content);
            }
            return View(pBook);

        }
        
        public IActionResult ListAllBook(int id)
        {
            String fName = @"c:\temp\book.txt";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book StringToBook(String[] data , Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }

        public IActionResult AddNewAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author pAuthor)
        {
            String fName = @"c:\temp\Author.txt";
            string content = $"{pAuthor.authorID} , {pAuthor.AuthorName}, {pAuthor.DateofBirth} , {pAuthor.Royalty}, {pAuthor.BookPublished}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(content);
            }
            return View(pAuthor);

        }
        public IActionResult ListAllAuthor(int id)
        {
            String fName = @"c:\temp\Author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName,true))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        private Author StringToAuthor(String[] data, Author author)
        {
            author.authorID = int.Parse(data[0]);
            author.AuthorName = data[1];
          author.DateofBirth = DateTime.Parse(data[2]) ;
            author.Royalty = data[3];
            author.BookPublished = int.Parse((String)data[4]);
            return author ;
        }

        public IActionResult DeleteAuthor(int id)
        {
            String fName = @"c:\temp\Author.csv";
            string[] lines = System.IO.File.ReadAllLines(fName);
            List<string> updatedLines = new List<string>();
            bool authorFound = false;
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data.Length >= 4)
                {
                    int authorID = int.Parse(data[0]);
                    if (authorID == id)
                    
                        authorFound = true;
                    
                    else
                        updatedLines.Add(line);
                }
            }
            System.IO.File.WriteAllLines(fName, updatedLines);
            return RedirectToAction("ListAllAuthor");
        }

        //public IActionResult Edit(int id)
        //{
        //    List<Author> authors = ReadAuthorsFromFile();
        //    Author authorToEdit = authors.FirstOrDefault(a => a.authorID == id);
        //    return View(authorToEdit);
        //}

        //public IActionResult EditAuthor(Author updatedAuthor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        List<Author> authors = ReadAuthorsFromFile();
        //        Author existingAuthor = authors.FirstOrDefault(a => a.authorID == updatedAuthor.authorID);
        //        if (existingAuthor != null)
        //        {
        //            existingAuthor.AuthorName = updatedAuthor.AuthorName;
        //            existingAuthor.DateofBirth = updatedAuthor.DateofBirth;
        //            existingAuthor.Royalty = updatedAuthor.Royalty;
        //            existingAuthor.BookPublished = updatedAuthor.BookPublished;
        //            WriteAuthorsToFile(authors);
        //            return RedirectToAction("ListAllAuthor");
        //        }
        //    }
        //    return View(updatedAuthor);
        //}

        //private List<Author> ReadAuthorsFromFile()
        //{
        //    String fName = @"c:\temp\Author.csv";
        //    List<Author> authors = new List<Author>();
        //    if (System.IO.File.Exists(fName))
        //    {
        //        string[] lines = System.IO.File.ReadAllLines(fName);
        //        foreach (string line in lines)
        //        {
        //            string[] data = line.Split(',');
        //            if (data.Length >= 4)
        //            {
        //                int authorID = int.Parse(data[0]);
        //                string authorName = data[1];
        //               string dateOfBirth = data[2];
        //                string royalty = data[3];
        //                int bookPublished = int.Parse(data[4]);

        //                authors.Add(new Author
        //                {
        //                    authorID = authorID,
        //                    AuthorName = authorName,
        //                    DateofBirth = dateOfBirth,
        //                    Royalty = royalty,
        //                    BookPublished = bookPublished
        //                }); ;
        //            }
        //        }
        //    }
        //    return authors;
        //}

        //private void WriteAuthorsToFile(List<Author> authors)
        //{
        //    String fName = @"c:\temp\Author.csv";
        //    List<string> lines = new List<string>();
        //    foreach (Author author in authors)
        //    {
        //        string line = $"{author.authorID} , {author.AuthorName}, {author.DateofBirth} , {author.Royalty}, {author.BookPublished}";
        //        lines.Add(line);
        //    }
        //    System.IO.File.WriteAllLines(fName, lines);
        //}
    }


}
