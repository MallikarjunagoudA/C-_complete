using System;
using System.IO;

namespace KnowMoreExceptionHandle
{
    internal class Program
    {


        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader(@"E:\Kudvenkat tutorial\C#\Delegates\readMEe.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception exx)
            {
                Console.WriteLine(exx.Message);

            }
            finally
            {
                Console.WriteLine("something went wrong please try again");
                //sr.Close();

            }

        }
    }
}
