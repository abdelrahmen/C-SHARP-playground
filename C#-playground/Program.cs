using C__playground;

namespace C_SHARP_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 1;
            var size = 10;
            Console.Write("results per page:");
            if (int.TryParse(Console.ReadLine(), out int resultsPerPage))
            {
                size= resultsPerPage;
            }

            Console.Write("page Number:");
            if (int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                page = pageNumber;
            }

            var employees = Repository.GetAllEmployees();

            var result = employees.Paginate(page, size);

            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
        }
    }
}