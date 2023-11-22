
namespace WEMA.BIT.Array
{
    public class Array
    {
        public static void Main(string[] args)
        {
            string[] students = new string[10] { "Chibuzor", "Timmy", "Rita", "Tbams", "Esther", "Frank", "Grace", "Hannah", "Jane", "Jide" };

            List<int> studentAges = new List<int> { 20, 18, 22, 19, 18, 21, 23, 20, 18, 24 };

            bool isEighteen = studentAges.Contains(18);

            // isEighteen = studentAges.Any(age => age == 18);

            if (isEighteen)
            {
                Console.WriteLine("There is at least one student whose age is 18 in the list.");
            }
            else
            {
                Console.WriteLine("No student with age 18 found in the list.");
            }
        }
    }
}