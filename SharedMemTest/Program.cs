using Draco.Coverage;

namespace SharedMemTest;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press any key to create shared memory!");
        Console.ReadLine();

        using var sharedMem = SharedMemory.CreateNew<int>("foo", 16);

        for (var i = 0; i < 16; i++)
        {
            sharedMem.Span[i] = i;
        }

        for (var i = 0; i < 16; i++)
        {
            Console.WriteLine(sharedMem.Span[i]);
        }

        Console.WriteLine("Shared memory created and written, press any key to dispose of it");
        Console.ReadLine();
    }
}
