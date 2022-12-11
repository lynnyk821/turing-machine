using System;
using System.Collections.Generic;
using System.Text;

namespace TMachine
{
    public class TransitionRow
    {
        public char Symbol { get; set; }
        public Transition[] transitions;
        public TransitionRow(char symbol, Transition[] transitions)
        {
            Symbol = symbol;
            this.transitions = transitions;
        }
        public int Length => transitions.Length;
        public Transition this[int state] => transitions[state];
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int state = 0; state < Length; state++)
                stringBuilder.Append(transitions[state] + "\t");
            return stringBuilder.ToString();
        }
    }
}
