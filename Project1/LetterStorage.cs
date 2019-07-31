using System;
namespace Project1
{
    public class LetterStorage
    {
            public static Random RANDOM = new Random();
        public static string[] WORDSLEVEL1 = {"ACT", "AGE", "ACE", "ADD", "BAD", "BAR", "BED", "BIN", "CAR", "CAT","DIE", "DIG", "DOG", "DRY", "EGO", "FAR", "HER", "HIM", "HUB",
    "LAY", "LOW", "LIE", "MAD", "MAP", "ODD", "OFF", "PAD", "PAY", "PET", "PIG", "PEN", "PUT", "RED", "SAD", "SIN", "SIT", "SAY", "SEE", "WAX", "WIN", "YOU", "JAZZ", "FUZZ", "BUZZ", "QUIZ", "JACK", "JUMP", "JUNK", "COZY", "JOKE", "JOWL", "JIVE", "QUIP", "BOXY", "DOZY", "FLUX", "JAWS", "JEEP",
    "JOBS", "JUGS", "LAZY", "MAZE", "JURY", "QUAY", "BUCK", "FAUX", "JAGS", "YELL", "KICK", "LYNX", "QUID", "QUIN", "AQUA", "BECK", "BACK", "BUFF", "BUMP", "CUFF", "DOSE", "DOZE",
    "EXAM", "EXPO", "JAIL", "JEAN", "JOIN", "JOLT", "MOCK", "PACK", "PICK", "PUFF", "PUMP", "QUIT", "VAMP", "BOMB", "BULK", "CAMP", "CLUB", "COMB", "DUCK", "HACK", "HAWK", "HOAX",
    "JARS", "JETS", "LUCK", "WAVY", "WEEP", "WHIP", "WOMB", "ZERO", "BABY", "BANK", "CHEW", "CHIP", "CHOP", "COPY", "DECK", "DOCK", "KNOB", "KNOW", "NECK", "PINK", "WINK", "BARK",
    "BIKE", "BLEW", "BOWL", "CALF", "CALM", "CLAP", "CLAW", "CLIP", "CUBE", "CUBS", "DUNK", "ENVY", "FAKE", "FIVE", "FLAP", "FLAW", "FLEW", "FLOW", "FORK","FOWL", "HYPE", "LAMB", "LAMP",
    "MAKE","MARK", "MASK", "PEAK", "PLUG", "PORK", "PUBS", "ROCK", "RACK", "SICK", "SKIP", "SOCK", "WEAK", "WEEK", "WOLF", "ROSE", "BODY", "BUSH", "BUSY", "CABS", "COME", "CAME",
    "CRAB", "CRAP", "CREW", "CROP", "EGGS", "FACE", "FACT", "FAME", "FLAG", "FORM", "FUND", "FURY", "GIVE", "GEEK", "GLOW", "GUMS", "HIGH", "HIVE", "HIKE", "HOOK", "MANY", "MICE"};

        public static string[] WORDSLEVEL2 = {"JAZZY", "FUZZY", "MUZZY", "FIZZY", "DIZZY", "PIZZA", "QUICK", "ZAPPY", "ZIPPY", "JACKS", "JUMPS", "JERKY", "JUICY", "CRAZY", "FIELD",
    "BLAZE", "CHUCK", "JAPAN", "JELLY", "JERKS", "JOKER", "JOKES", "JUDGE", "JUICE", "CHECK", "CHICK", "ENJOY", "EJECT", "FROZE", "JEEPS", "JOLTY", "MAJOR", "MAZES", "PICKY", "PUPPY",
    "QUERY", "QUILL", "UNBOX", "WACKY", "ZEBRA", "BLOCK", "BLACK", "BOXED", "BUCKS", "CHAMP", "CHIMP", "CHEVY", "CHUNK", "CLICK", "CLOCK", "CLUMP", "COMFY", "DOZEN", "DUCK", "EQUAL",
    "HUBBY", "INBOX", "JELLS", "KICKS", "LUCKY", "MIXED", "MOMMY", "POPPY", "QUEEN", "QUILT", "SQUAD", "SQUID", "YUMMY", "BOXER", "BOXES", "BRICK", "CHALK", "CHEWY", "CLIMB", "CRACK",
    "CURVY", "EXACT", "EXAMS", "FOXES", "HAPPY", "HIPPY", "HOBBY", "JADES", "JEANS", "JOINT", "JOLTS", "MILKY", "PACKS", "QUIET", "QUOTE", "REMIX", "SAVVY", "SMASH", "TOXIC", "WRECK",
    "ZONES", "BAGGY", "BENCH", "BICEP", "BLANK", "BLINK", "BOMBS", "BULKS", "CHEEK", "COMBO", "COUCH", "DUCKS", "FANCY", "FINCH", "FLAWY", "FOGGY", "HACKS", "HAWKS", "MARVY", "NAPPY",
    "PEAKY", "PERKY", "SEIZE", "SIZES", "SMOKY", "SPUNK", "TACKY", "THUMB", "TUMMY", "VODKA", "WAVEY", "WIGGY", "AWFUL", "BAKED", "BANKS", "BEACH", "BEEFY", "BLOWN", "BUDDY", "BULLY",
    "CATCH", "CHARM", "CHEAP", "CHIPS", "CIVIL", "CLERK", "CLOAK", "COACH", "COUGH", "DETOX", "EMPTY", "FETCH", "FIFTY", "FIFTH", "FLAME", "FUNNY", "HEAVY", "HUNKS", "KNIFE", "MAGIC",
     "BUZZER", "QUEAZY", "SIZZLE", "JACKED", "JUMPED", "JACKET", "JAMMED", "JOKING", "JOYFUL", "JUMPER", "ZAPPED", "OBJECT", "PIJAMA", "BACKUP",
    "BREEZY", "GAZING", "JIGSAW", "JUDGED", "MOCKUP", "QWERTY", "AMAZED", "BLAZER", "BLAZES", "BOXING", "BRONZE", "CHOPPY", "CHUCKS", "DEJECT", "DUPLEX", "EQUIPS", "EXCEPT", "EXPECT",
    "FROZEN", "INJECT", "INJURY", "JEWELS", "JOGGER", "JOKERS", "JIUCER", "JUDGES", "PREFIX", "PREMIX", "WAXING", "WHIPPY", "WIZARD", "ZODIAC", "AMAZES", "BRAISE", "BRAZER",
    "BREEZE", "BUCKLE", "CHALKY", "CLIFFY", "EXPIRY", "FLAPPY", "FLOPPY", "FREEZE", "GLAZER", "HAZARD", "HICCUP", "JASPER", "KIMCHI", "LIQUID", "OBJECTS", "OXYGEN", "PROJET",
    "REJECT", "SNEEZY", "SNOOZY", "UNIQUE", "ADJUST", "BLOWUP", "BUCKET", "BUMPED", "CHEEKY", "CHEMIC", "CLOCKS", "CRAPPY", "DOZENS", "EQUALS", "EXCEED", "EXCELS", "EXCUSE", "FLICKS",
    "GLOBBY", "GRAZER", "HAWKEY", "HICKEY", "HOCKEY", "JEAGER", "JERSEY", "JUNIOR", "LIQUOR", "LIZARD", "MAKEUP", "MARKUP", "MUFFIN", "OXFORD", "PAYOFF", "PIXELS", "PUBLIC", "PUMPED", "QUEENS",
    "QUEUES", "QUOTED", "REFLEX", "SEQUEL", "SQUADS", "SQUIDS", "BAKING", "BOMBED", "BOUNCY", "BOXERS", "BRUNCH", "CATCHY", "CLUMSY", "CLUTCH", "CONVEY", "CORTEX", "CRACKS", "CURVEY",
    "CYPHER", "EMBARK", "EXCESS", "EXCITE", "EXOTIC", "EXPECT", "EXPERT", "EXPORT", "EXPIRE", "EXPOSE", "FACEUP", "FITCHY", "FLAGGY", "FLINCH", "GRIPPY", "HUMBLE", "IMBARK", "KEYPAD",
    "MATRIX", "MONKEY", "PACKET", "PHYSIC", "PICNIC", "PITCHY", "PSYCHE", "PSYCHO", "QUARTS", "SCRUVY", "SNEEZE", "SNOOZE", "SQUIRT", "AMBUSH", "BAKERY", "BECOME", "BECAME", "BEHALF", "BEHAVE",
    "BEHOLD", "BLEACH", "BOMBER", "BRANCH", "CHILLY", "CLICHE", "COFFEE"};

        /**
      randomWordLevel1:

      function that choose a Random word from an array of words above
      parameters: no parameters needed for this function
      Returns:
      return a String contains pseudorandom word from WORDLEVEL1 array

      */
        public string randomWordLevel1() { return WORDSLEVEL1[RANDOM.Next(WORDSLEVEL1.Length)]; }


        /**
         randomWordLevel2:

         function that choose a Random word from an array of words above
         parameters: no parameters needed for this function
         Returns:
         return a String contains pseudorandom word from WORDLEVEL2 array

         */
        public string randomWordLevel2() { return WORDSLEVEL2[RANDOM.Next(WORDSLEVEL2.Length)]; }

        /**
 shuffleWord:

 function that shuffles the chosen word

 Parameters:

 word - a string storing a word

 Returns:
 if word is not empty and the length is not space => converting word to a new character array
 then, shuffling the word

 */
        public string shuffleWord(String word)
        {
            if (word != null && !"".Equals(word))
            {
                char[] a = word.ToCharArray();

                for (int i = 0; i < a.Length; i++)
                {
                    int j = RANDOM.Next(a.Length);
                    char tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                }

                return new String(a);
            }

            return word;
        }

        /**
         compareWords (added by Phong 8/4/2019)
         function compare two given words

         parameters
         two words that need to be compared

         returns a boolean value indicating if two given words are match
         */
        public bool compareWords(String word1, String word2)
        {
            word1 = word1.ToLower();
            word2 = word2.ToLower();
            char[] a = word1.ToCharArray();
            char[] b = word2.ToCharArray();

            bool match = true;
            if (a.Length != b.Length || a.Length == 0 || b.Length == 0)
            {
                match = false;
                return match;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    match = false;
                return match;

            }
            return match;
        }

    }
}
