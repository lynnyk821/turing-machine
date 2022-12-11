using System;
using System.Collections.Generic;
using System.Text;

namespace TMachine
{
    public static class Test
    {
        public static void Test1()
        {
            int index = -3; 
            char[] tape = {' ', '0', '0', '0', '1', ' ', '_'};
            Print(tape);
            Console.WriteLine(tape.Length);
            List<char> tape2 = new List<char>();
            for(int i = 0; i < Math.Abs(index); i++) tape2.Add(' ');
            for (int i = 0; i < tape.Length; i++) tape2.Add(tape[i]);
            Console.WriteLine(tape2.Count);
            Print(tape2.ToArray());
        }
        private static void Print(char[] tape)
        {
            for (int i = 0; i < tape.Length; i++)
                Console.Write("[" + tape[i] + "] ");
            Console.WriteLine();
        }
    }
}
