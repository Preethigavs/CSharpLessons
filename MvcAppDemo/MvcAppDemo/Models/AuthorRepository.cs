namespace MvcAppDemo.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.authorID, author); // ensures the uniqiueness
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.authorID, author);
                            }

                        }
                    }

                }
            }
            return list;

        }

        private static Author StringToAuthor(String[] data, Author author)
        {
            author.authorID = int.Parse(data[0]);
            author.AuthorName = data[1];

            author.DateofBirth = DateTime.Parse(data[2]);
            author.Royalty = data[3];
            author.BookPublished = int.Parse((String)data[4]);
            return author;
        }


        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            return author;
        }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"c:\temp\Author.csv";
            string strAuthor = $"{pAuthor.authorID}, {pAuthor.AuthorName}, {pAuthor.DateofBirth}, {pAuthor.Royalty}, {pAuthor.BookPublished}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int , Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.authorID != id)
                        strAuthor = $"{author.authorID},{author.AuthorName},{author.DateofBirth}, {author.Royalty},{author.BookPublished}";

                    sw.WriteLine(strAuthor);
                }
            }

        }
        //public static void SaveAllAuthorsToFile(Dictionary<int, Author> pAuthorList)
        //{


        //}

        public static void updateAuthorToFile(Author pauthor)
        {
            String fName = @"c:\temp\Author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.authorID != pauthor.authorID)
                        strAuthor = $"{author.authorID},{author.AuthorName},{author.DateofBirth}, {author.Royalty},{author.BookPublished}";
                    else
                        strAuthor = $"{pauthor.authorID},{pauthor.AuthorName},{pauthor.DateofBirth}, {pauthor.Royalty},{pauthor.BookPublished}";
                    sw.WriteLine(strAuthor);
                }

            }


        }
      
    } 

}
