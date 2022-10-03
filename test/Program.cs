using Entidades;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Enum.GetValues(typeof(ECategoria))){
                Console.WriteLine(i);
                ECategoria cat1 = (ECategoria)i;
            }


        }
    }
}