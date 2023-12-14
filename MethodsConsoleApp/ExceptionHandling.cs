using System.IO;
using System.IO.Pipes;

namespace MethodsConsoleApp
{
    internal class ExceptionHandling
    {
        /// <summary>
        /// A simple method used to test exception handling.
        /// </summary>
        public static void IntHandling()
        {
            Console.WriteLine("Insert a WHOLE NUMBER: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) when (e.GetType() != typeof(FormatException))
            //The "when" keyword is used to setup a condition to a "catch" block
            //The catch block will only execute if the condition is TRUE
            {

                Console.WriteLine("Good job! You failed miserably.");
                Console.WriteLine(e.ToString());
                return;
            }

            Console.WriteLine("Oh wow, you actually did it right...");

        }

        /// <summary>
        /// Any kind of OverFlow exceptions are overlooked by the compiler in order to save 
        /// processing time since it doesn't have to check every single aritmetic operation
        /// that we do. The use of the "checked" block will force the compiler to check them.
        /// These only work with "int" and "long"
        /// </summary>
        public static void CheckedKeyWord() 
        {
            checked
            {
                int num = int.MaxValue;
                Console.WriteLine(num + 20);
            }
            // This can also be done by going to the properties tab in the project settings
            // and tick the box in the "build" section that determines if the compiler
            // checks for overflow or not.

            /*
             * You can also do it doing the following:
             * 
             * int num = int.MaxValue;
             * Consolw.WriteLine(checked(num + 20));
             * 
             */
        }

        /// <summary>
        /// If we have activated the compiler checking every arithmetic operation we can use
        /// the "unchecked" keyword to specify code that we don't want to be checked.
        /// </summary>
        public static void UncheckedKeyWord() 
        {
            unchecked
            {
                int num = int.MaxValue;
                Console.WriteLine(num + 20);
            }

        }


        public static string ReturnMonth(int monthNum) 
        {
            switch (monthNum)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    throw new ArgumentOutOfRangeException(nameof(monthNum), "Only Int32 numbers between 1 and 12 allowed.");
            }
        }
        /// <summary>
        /// An example of the use of the "finally" block.
        /// In this case unnecesary, one can use the "using" keyword in the streams to indicate an automatic
        /// closing of the streams once we can't use them anymore:
        /// 
        /// using FileStream fileStream = new("C:\\Users\\agus-\\source\\repos\\FirstConsoleProj\\MethodsConsoleApp", FileMode.OpenOrCreate);
        /// using StreamReader streamReader = new(fileStream);
        /// 
        /// </summary>
        public static void ExampleUseFinally() 
        {

            FileStream fileStream = new("C:\\Users\\agus-\\source\\repos\\FirstConsoleProj\\MethodsConsoleApp\\Example.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new(fileStream);

            try
            {
                string text;
                
                while (streamReader.Peek() != -1) 
                {
                    text = streamReader.ReadLine()!; // "!" is a null forgiving operator.
                    Console.WriteLine(text);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist/was not found.");
            }
            catch (IOException) 
            {
                Console.WriteLine("An error has ocurred while trying to read the file.");
            }
            finally 
            {
                fileStream.Close();
                streamReader.Close();
                Console.WriteLine("The streams have been closed...");
            }
        }
    }
}
