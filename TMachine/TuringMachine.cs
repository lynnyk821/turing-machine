using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Transactions;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;

namespace TMachine
{
    public class TuringMachine
    {
        private char[] tape;
        private int head = 0, state = 0;
        private TransitionTable transitionTable;
        public TuringMachine(int head, int state, char[] tape, TransitionTable transitionTable)
        {
            if (head > tape.Length) throw new Exception("Exception");

            this.head = head < 0 ? 0 : head; 
            this.state = state;
            this.tape = GetTapeWith(head, tape);
            this.transitionTable = transitionTable;
        }
        public char[] GetTapeWith(int startIndex, char[] tape)
        {
            List<char> newTape = new List<char>();

            if(startIndex < 0)
                for (int i = 0; i < Math.Abs(startIndex); i++) newTape.Add(' ');
            
            for(int i = 0; i < tape.Length; i++) newTape.Add(tape[i]);

            return newTape.ToArray();
        }
        public void Animation()
        {
            Console.Write("Tape: ");
            Console.WriteLine(String.Join(" ", tape));
            for(int i = 0; i < transitionTable.Length; i++)
            {
                Console.Write(transitionTable[i].Symbol + "\t");
                for(int j = 0; j < transitionTable[i].Length; j++)
                {
                    if (state == j && transitionTable[i].Symbol == tape[head])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(transitionTable[i][j] + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(transitionTable[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(tape.Length);
            Console.ReadKey();
            Console.Clear();
        }
        public void Run()
        {
            while(state != -1)
            {
                Animation();
                Transition currentTransition = transitionTable[tape[head], state];
                tape[head] = currentTransition.Replace;
                switch (currentTransition.Move)
                {
                    case '>':
                        head++;
                        break;
                    case '<':
                        head--;
                        //tape = GetTape(head, tape);
                        break;
                    case '=':
                        break;
                    default:
                        throw new Exception("Exception");
                }
                state = currentTransition.NextState;
            }
        }
    }
}
