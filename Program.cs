using System.Text;
namespace C__Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            string title = "clean code";
            string upperTitle = "title.ToUpper()";
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion
            #region Question 2 
            string text1 = "clean code";
            string text2 = "clean code";
            Console.WriteLine(ReferenceEquals(text1, text2));
            #endregion
            #region Question 3
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("- Update");
            Console.WriteLine(sb);
            #endregion
            #region Question 4 
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion
            #region Question 5
            int pages = 464;
            string result = "Book:" + title + "pages:" + pages;

            #endregion
            #region Question 6
            Console.WriteLine($"Book:{ title},pages: { pages}");
            #endregion
            #region Question 7
            Console.WriteLine(string.Format("Book: {0}, pages:{1}", title, pages));
            #endregion

            #region Question 8
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");

            }
            #endregion
            #region Question 9
         bool isAvailable = true;
            if(pages>300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
            #region Question 10 
            string bookTitle = "Refactoring";
            switch (bookTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;
                default: 
                    Console.WriteLine("Never heard of it");
                    break;

            }
            #endregion
            #region Question 11
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            #endregion
            #region Question 12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion
            #region Question 13

            int x = 0;

            while (x < books.Length)
            {
                Console.WriteLine(books[x]);
                x++;
            }
            #endregion

            #region Question 14
            int j = 0;
            do
            {
                Console.WriteLine("Checking book...");
                j++;
            }
            while (j < 3);
            #endregion
            #region Question 15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
