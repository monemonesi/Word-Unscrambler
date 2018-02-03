using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler.Data
{
    /* 
     * REMINDER
     * A structure is a value type so it is stored on the stack, but a class is a reference type and is stored on the heap.
     * A structure doesn't support inheritance, and polymorphism, but a class supports both
     */
    struct MatchedWord
    {
        public string ScrambledWord { get; set;}
        public string CorrectWord { get; set; }
    }
}
