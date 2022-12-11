using System;

namespace TMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char[] tape = { '1', ' ', ' ', '0', ' ', ' ', '0', ' ', ' ', ' ', ' ', ' ', '0', ' ', ' ', '_' };

            TuringMachine turingMachine = new TuringMachine(-5, 0, tape, Functions.Test1());
            turingMachine.Run();
        }
    }
}
