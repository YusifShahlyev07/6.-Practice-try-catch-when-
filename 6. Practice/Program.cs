using Microsoft.VisualBasic;

namespace _6._Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Fin: ");
                string? fin = Console.ReadLine();
                Console.WriteLine("Enter Year: ");
                int.TryParse(Console.ReadLine(), out int year);
                Console.WriteLine("Enter Month: ");
                int.TryParse(Console.ReadLine(), out int month);
                Console.WriteLine("Enter Day: ");
                int.TryParse(Console.ReadLine(), out int day);
            try
            {
                Passport passport = new Passport(fin, year, month, day);
                Console.WriteLine();
                passport.Show();
            }
            catch (Exception ex) when(year> DateTime.Now.Year)
            {
                Console.WriteLine("year ucun ayrilan catch");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally...");
            }
        }

    }
}
