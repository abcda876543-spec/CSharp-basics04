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

        }
    }
}
