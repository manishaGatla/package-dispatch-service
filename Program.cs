using package_dispatch_service.src;

namespace package_dispatch_service
{
    public class Program
    {
        static void Main()
        {
            var result = Sorter.Sort(100, 100, 100, 10);
            Console.WriteLine($"Dispatch Type: {result}");
        }
    }
}
