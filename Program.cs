#define DEBUG // Define DEBUG symbol

using System;

class Program
{
    static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode is enabled.");
#else
        Console.WriteLine("Debug mode is not enabled.");
#endif

#if RELEASE
        Console.WriteLine("Release mode is enabled.");
#else
        Console.WriteLine("Release mode is not enabled.");
#endif

#if(DEBUG && RELEASE)
#error "Cannot have both DEBUG and RELEASE modes enabled."
#endif

#warning "This code may need optimization."

        // Your program logic here...
    }
}
