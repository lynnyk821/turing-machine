using System;
using System.Collections.Generic;
using System.Text;

namespace TMachine
{
    public class Transition /*(1 > s0)*/
    {
        public char Replace { get; set; }
        public char Move { get; set; }
        public int NextState { get; set; }
        public Transition(char replace, char move, int nextState)
        {
            Replace = replace;
            Move = move;
            NextState = nextState;
        }
        public override string ToString() => $"{Replace}{Move}{NextState}";
    }
}
