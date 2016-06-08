using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain
{
    public class TriviaDatabase
    {
        public static KeyValuePair<string, string> GetRandomQuestion()
        {
            return new KeyValuePair<string, string>(
                "What is the answer to the Ultimate Question of Life, The Universe, and Everything?",
                "42"
                );

        }
    }
}
