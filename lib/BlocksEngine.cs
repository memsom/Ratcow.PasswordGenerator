using System;
using System.Linq;

namespace Ratcow.PasswordGenerator
{
    public class BlocksEngine
    {
        Random randomizer = new Random(DateTime.Now.Millisecond); // TODO - make this better

        static readonly string[] sblocks = new string[]
        {
            "a", "e", "i", "o", "u", "ea",
            "oo", "ou", "oe", "oa", "ei", "ai",
            "ba", "be", "bi", "bo", "bu",
            "bla", "ble", "bli", "blo", "blu",
            "bra", "bre", "bri", "bro", "bru",
            "ra", "re", "ri", "ro", "ru",
            "pa", "pe", "pi", "po", "pu",
            "ma", "me", "mi", "mo", "mu",
            "na", "ne", "ni", "no", "nu",
            "pla", "ple", "pli", "plo", "plu",
            "pra", "pre", "pri", "pro", "pru",
            "sa", "se", "si", "so", "su",
            "sla", "sle", "sli", "slo", "slu",
            "sha", "she", "shi", "sho", "shu",
            "ta", "te", "ti", "to", "tu",
            "tha", "te", "thi", "tho", "thu",
            "tra", "tre", "tri", "tro", "tru",
            "ca", "ce", "ci", "co", "cu",
            "cla", "cle", "cli", "clo", "clu",
            "cra", "cre", "cri", "cro", "cru",
            "ka", "ke", "ki", "ko", "ku",
            "kla", "kle", "kli", "klo", "klu",
            "kra", "kre", "kri", "kro", "kru",
            "da", "de", "di", "do", "du",
            "dra", "dre", "dri", "dro", "dru",
            "ga", "ge", "gi", "go", "gu",
            "gra", "gre", "gri", "gro", "gru",
            "ha", "he", "hi", "ho", "hu",
            "la", "le", "li", "lo", "lu",
            "ja", "je", "ji", "jo", "ju",
            "za", "ze", "zi", "zo", "zu",
            "ya", "ye", "yi", "yo", "yu",
            "wa", "we", "wi", "wo", "wu",
            "va", "ve", "vi", "vo", "vu",
            "qua", "que", "qui", "quo",
        };

        static readonly string[] eblocks = new string[]
        {
            "x", "z", "s", "f", "n", "m",
            "t", "d", "l", "b", "g",
            "ff", "ss", "tt", "ck",
            "gh", "ch", "th", "sh",
            "ng", "nt", "nt", "mb", "mt", "md",
            "el", "em", "en", "le", "re", "er",
            "ay","al", "am", "an", "ar", "at",
            "oy", "ol", "om", "on", "or", "ot",
            "il", "im", "in", "ir", "it",
            "ul", "um", "un", "ur", "ut"
        };      



        public string Generate(int length, bool sanitise = false)
        {
            var result = string.Empty;

            

            while (result.Length < length)
            {
                result += sblocks[randomizer.Next(sblocks.Length)];
                result += eblocks[randomizer.Next(eblocks.Length)];

                if(result.Length - length == 1)
                {
                    result += result.Last() == 's' ? "e" : "s";
                }
            }

            if(sanitise)
            {
                return result.Replace("uu", "ou")
                         .Replace("uo", "oe")
                         .Replace("ao", "oy")
                         .Replace("ae", "ay")
                         .Replace("aa", "ai")
                         .Replace("ii", "ie")
                         .Replace("eo", "ei")
                         .Replace("oe", "oo");
            }
            else
            {
                return result;
            }
        }
    }
}
