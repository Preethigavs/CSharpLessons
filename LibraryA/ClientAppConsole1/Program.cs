using LibraryA;
using System;

Book book = new Book();
book.Title = "Twisted love";
book.Author = "Ana huang";
book.Genre = "social";
book.BookPrice = 300;
book.DateOfPublish = new DateTime(1995, 08, 01);
book.BookMarkPage(124);
Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addResult = calculator.Add(100, 20);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multipy(100, 20);
Console.WriteLine(multiplyResult);
int divideResult = calculator.Divide(100, 50);
Console.WriteLine(divideResult);