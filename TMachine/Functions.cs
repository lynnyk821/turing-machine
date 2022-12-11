using System;
using System.Collections.Generic;
using System.Text;

namespace TMachine
{
    public static class Functions
    {
        public static TransitionTable Test2() => new TransitionTable(new TransitionRow[]
        {
            new TransitionRow('0', new Transition[] {new Transition('1', '>', 1), new Transition('1', '>', 0) }),
            new TransitionRow('1', new Transition[] {new Transition('0', '>', 1), new Transition('0', '>', 0) }),
            new TransitionRow(' ', new Transition[] {new Transition(' ', '>', 1), new Transition(' ', '>', 0) }),
            new TransitionRow('_', new Transition[] {new Transition('_', '=', -1), new Transition('1', '>', -1) }),
        });
        public static TransitionTable Test1() => new TransitionTable(new TransitionRow[]
        {
            new TransitionRow('0', new Transition[] {new Transition('1', '>', 0), new Transition('1', '>', 0)}),
            new TransitionRow('1', new Transition[] {new Transition('0', '>', 0), new Transition('0', '>', 0) }),
            new TransitionRow(' ', new Transition[] {new Transition(',', '>', 1), new Transition(' ', '>', 1) }),
            new TransitionRow('_', new Transition[] {new Transition('_', '=', -1)}),
        });
    }
}
