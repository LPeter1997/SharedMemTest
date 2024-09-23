using Draco.Coverage;

namespace SharedMemTestClient;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press any key to open shared memory!");
        Console.ReadLine();

        using var sharedMem = SharedMemory.OpenExisting<int>("foo", 16);

        Console.WriteLine("Press any key to read shared memory!");
        Console.ReadLine();

        for (var i = 0; i < 16; i++)
        {
            Console.WriteLine(sharedMem.Span[i]);
        }

        Console.WriteLine("Shared memory opened and read, press any key to dispose of it");
        Console.ReadLine();
    }
}
