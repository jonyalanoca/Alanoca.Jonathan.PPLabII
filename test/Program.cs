using Entidades;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Dueño dueño1 = new Dueño("jonathan", "Alanoca", 373777700, "jonyalanoca2@gmail.com", "fsaf,");
            foreach(var i in Negocio.Vendedores)
            {
                Console.WriteLine(i.Nombre);
            }
        }
    }
}