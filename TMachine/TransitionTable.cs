using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TMachine
{
    public class TransitionTable
    {
        private TransitionRow[] transitionRows;
        public TransitionTable(TransitionRow[] transitionRows)
        {
            if (transitionRows == null)
                throw new Exception("exception");
            this.transitionRows = transitionRows;
        }
        public Transition this[char symbolOfAlphabet, int state]
        {
            get
            {
                for (int i = 0; i < transitionRows.Length; i++)
                    if (transitionRows[i].Symbol == symbolOfAlphabet)
                        return transitionRows[i][state];
                return null;
            }
        }
        public int Length => transitionRows.Length;
        public TransitionRow this[int i] => transitionRows[i];
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < transitionRows.Length; i++)
                stringBuilder.Append(transitionRows[i] + "\n");
            return stringBuilder.ToString();
        }
    }
}
