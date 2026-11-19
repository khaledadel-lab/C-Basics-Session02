using System.Globalization;
using System.Linq.Expressions;

namespace Route_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //1- Create a Book class with a Title (string) and Pages (int). Create a Book object and store itin a variable of type object. Print it.
            object book01 = new Book() { Title = "c#", pages = 200 };
            //Console.WriteLine(book01);
            #endregion

            #region Question02
            ////2- Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Console.WriteLine(book01.ToString());
            //Console.WriteLine(book01.Equals(book01));
            //Console.WriteLine(book01.GetHashCode());
            //Console.WriteLine(book01.GetType());
            #endregion

            #region Question03
            ////3- Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it. int pages = "464";
            ////int pages = "464"; // compilation error
            //int pages = int.Parse("464");
            #endregion

            #region Question04
            ////4- Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //int x = 0;
            //int y = 10;
            //try
            //{
            //    int z = y / x;
            //    Console.WriteLine(z);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("cannot divide by zero");
            //}
            //finally {
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question05
            ////5- Declare an int pages = 300; then store it in a double variable without using a cast.
            //int Pages = 300;
            //double pages2 = Pages;
            //Console.WriteLine(pages2);
            #endregion

            #region Question06
            ////6- Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int price2 = (int)price; 
            //Console.WriteLine(price2);
            #endregion

            #region Q@uestion07
            ////7- Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pagesText2 = Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesText2);
            #endregion

            #region Question08
            ////8- Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int. TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int yearText2 = int.Parse(yearText);
            //Console.WriteLine(yearText2);
            //string badText = "abc";
            //bool isVaild = int.TryParse(badText, out int result);
            //if (!isVaild) {
            //    Console.WriteLine("invaild number");
            //}
            //else {
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Question09
            ////9- Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;
            //string pages2 = Convert.ToString(pages);
            //Console.WriteLine(pages2);
            //Console.WriteLine(pages2.GetType());
            #endregion

            #region Question10
            //10- Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            object obj;
            obj = 100;
            Console.WriteLine(obj);
            int copies2 = (int)obj;
            Console.WriteLine(copies2);
            #endregion
        }
    }
}
