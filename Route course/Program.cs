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
            //4- Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            int x = 0;
            int y = 10;
            try
            {
                int z = y / x;
                Console.WriteLine(z);
            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot divide by zero");
            }
            finally {
                Console.WriteLine("Done");
            }
            #endregion
        }
    }
}
