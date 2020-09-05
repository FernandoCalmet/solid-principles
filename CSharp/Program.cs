using CSharp.src.example2;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            ProgrammExample1 example1 = new ProgrammExample1();
            example1.srpExample();
            //Example 2
            ProgramExample2 example2 = new ProgramExample2();
            example2.srpExample();
            example2.ocpExample();
            example2.lspExample();
            example2.ispExample();
            example2.dipExample();
        }
    }
}
