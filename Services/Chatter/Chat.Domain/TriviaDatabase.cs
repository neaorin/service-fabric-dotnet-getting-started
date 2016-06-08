using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain
{
    public class TriviaDatabase
    {
        static Random random = new Random();
        public static KeyValuePair<string, string> GetRandomQuestion()
        {
            return TriviaDb.ElementAt(random.Next(TriviaDb.Count));
        }


















        static Dictionary<string, string> TriviaDb = new Dictionary<string, string>()
        {
            { "What is the answer to the Ultimate Question of Life, The Universe, and Everything?" ,"42" },
            { "What Chinese dynasty was overthrown in 1911?","Manchu" },
            { "What age preceded the Iron Age? (The ~ Age)" ,"Bronze" },
            { "What first name did presidents Madison, Monroe, Polk, and Garfield have in common?", "James"},
            { "What group landed in America in 1620? (The ~)","Pilgrims" },
            { "What is the Roman numeral for fifty?","L" },
            { "What volcano destroyed Pompeii?","Vesuvius" },
            { "What was the instrument of execution during the 'Reign of Terror'?","Guillotine" },
            { "What was the name of the B-29 used at Hiroshima to drop the bomb? (~ Gay)","Enola" },
            { "Which U.S. president said, 'The buck stops here'? (Harry ~)","Truman" },
            { "Which nation was led by Genghis Khan?","Mongols" },
            { "Which military battle took place in 1815?","Waterloo" },
            { "Which president was responsible for the Louisiana Purchase?","Jefferson" },
            { "Who is 'The Iron Lady'? (Margaret ~)","Thatcher" },
            { "Who said 'Veni, vidi, vici' (I came, I saw, I conquered)? (Julius ~)","Caesar" },
            { "Who said: 'Let them eat cake'? (Marie ~)","Antoinette" },
            { "Who sang Happy Birthday to John F. Kennedy for his 45th? (Marilyn ~)","Monroe" },
            { "Who succeeded Churchill when he resigned in 1955? (Sir Anthony ~)","Eden" },
            { "Who was the first chancellor of West Germany after WW II? (Konrad ~","Adenauer" },
            { "Who was the second man to set foot on the moon? (Edwin 'Buzz' ~)","Aldrin" },
            { "Who was, 'First in war, first in peace and first in the hearts of his countrymen'? (George ~)","Washington" }
        };
    }
}
