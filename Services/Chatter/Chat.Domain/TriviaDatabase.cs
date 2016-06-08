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
            { "Who was, 'First in war, first in peace and first in the hearts of his countrymen'? (George ~)","Washington" },
            { "What city was the setting for 'Gone With the Wind'?","Atlanta" },
            { "What color does the bride wear in China?","Red" },
            { "What continent is the home to the greatest number of countries?","Africa" },
            { "What country are the Islands of Quemoy and Matsu part of?","Taiwan" },
            { "What country borders Egypt on the west?","Lybia" },
            { "What country borders Egypt to the south?","Sudan" },
            { "What country does the island of Mykonos belong to?","Greece" },
            { "What country formed the union of Tanganyika and Zanzibar?","Tanzania" },
            { "What country has the world's most southerly city?","Chile" },
            { "What country is Phnom Penh the capital of?","Cambodia" },
            { "What country is Santo Domingo the capital of? (~ Republic)","Dominican" },
            { "What country is directly north of Israel?","Lebanon" },
            { "What country is directly north of the continental United States?","Canada" },
            { "What is the capital of New Zealand?","Wellington" },
            { "What is the capital of Washington state?","Olympia" },
            { "What is the capital of West Virginia?","Charleston" },
            { "What is the capital of Zimbabwe?","Harare" },
            { "What is the current name for south-west Africa?","Namibia" },
            { "What is the largest city in Australia, in terms of population?","Sydney" },
            { "What is the largest city in China?","Shanghai" },
            { "What is the largest of the countries in Central America?","Nicaragua" },
            { "Which Central American country extends furthest north?","Belize" },
            { "Which European country has the highest population density?","Monaco" },
            { "Which European country has the lowest population density?","Iceland" },
            { "Which U.S. city is known as Beantown?","Boston" },
            { "Which U.S. city is known as the Biggest Little City in the World?","Reno" },
            { "Which U.S. state borders a Canadian territory?","Alaska" },
            { "Which U.S. state has the least rainfall?","Nevada" },
            { "What is a sorcerer who deals in black magic called?","Necromancer" },
            { "Who invented dynamite? (Alfred ~)","Nobel" },
            { "In which city is the Hockey Hall of Fame located?","Toronto" },
            { "In which game or sport is a 'Zamboni' used?","hockey" },
            { "In which sport is a 'hole-in-one' possible?","golf" },
            { "In which sport is the America's Cup awarded?","sailing" },
            { "In which sport is the Cy Young Trophy awarded?","baseball" },
            { "Which U.S. state receives the most rainfall?","Hawaii" },
            { "Which capital is known as the Glass Capital of the World?","Toledo" },
            { "Which city has the largest rodeo in the world?","Calgary" },
            { "Which city is known as Motown?","Detroit" },
            { "Which city is known as the Windy City?","Chicago" },
            { "Which city is on the east side of San Francisco Bay?","Oakland" },
            { "Which country administers Christmas Island?","Australia" },
            { "What is measured by a Geiger counter?","radioactivity" },
            { "Who was elected President of France, in 1981? (Francois ~)","Mitterrand" },
            { "The Kelvin scale is used to measure...","Temperature" },
            { "This Russian scientist used dogs to study conditioned reflexes. (Ivan ~)","Pavlov" },
            { "What reading system is used by the blind?","Braille" }
        };
    }
}


