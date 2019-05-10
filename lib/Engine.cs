using System;
using System.Linq;

namespace Ratcow.PasswordGenerator
{
    /// <summary>
    /// Vaguely English password generator
    /// </summary>
    public class Engine
    {
        enum CharType : byte { None, Vowel, Const }
        Random randomizer = new Random(DateTime.Now.Millisecond); // TODO - make this better


        string GetAFollow()
        {
            var result = string.Empty;
            var r = randomizer.Next(10);
            if (r > 0)
            {
                switch (r)
                {
                    case 1:
                        result = "i";
                        break;
                    case 2:
                        result = "y";
                        break;
                    case 3:
                        result = "o";
                        break;

                    case 4:
                        result = "u";
                        break;
                }
            }

            return result;
        }

        string GetEFollow()
        {
            var result = string.Empty;
            var r = randomizer.Next(10);
            if (r > 0)
            {
                switch (r)
                {
                    case 1:
                        result = "e";
                        break;
                    case 2:
                        result = "i";
                        break;
                    case 3:
                        result = "y";
                        break;
                    case 4:
                        result = "a";
                        break;
                }
            }

            return result;
        }

        string GetOFollow()
        {
            var result = string.Empty;
            var r = randomizer.Next(10);
            if (r > 0)
            {
                switch (r)
                {
                    case 1:
                        result = "i";
                        break;
                    case 2:
                        result = "y";
                        break;
                    case 3:
                        result = "a";
                        break;
                    case 4:
                        result = "o";
                        break;
                    case 5:
                        result = "u";
                        break;
                }
            }

            return result;
        }

        string GetCFollow()
        {
            var result = string.Empty;
            var r = randomizer.Next(10);
            if (r > 0)
            {
                switch (r)
                {
                    case 1:
                        result = "h";
                        break;
                    case 2:
                        result = "k";
                        break;
                }
            }

            return result;
        }

        string GetHPostfix()
        {
            return randomizer.Next(10) % 2 == 0 ? "h" : string.Empty;
        }

        char[] c = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
        char[] v = { 'a', 'e', 'i', 'o', 'u', 'y' };
        string Next(string lastchars, ref CharType lastGenerated, bool final)
        {

            switch (lastGenerated)
            {
                case CharType.None:
                    lastGenerated = randomizer.Next(10) % 2 == 0 ? CharType.Const : CharType.Vowel;
                    return Next(lastchars, ref lastGenerated, false);


                case CharType.Vowel:
                    {
                        lastGenerated = CharType.Const;
                        var i = randomizer.Next(c.Length - 1);
                        var x = c[i];
                        var result = x.ToString();

                        if (!final)
                        {
                            switch (x)
                            {
                                case 's':
                                case 't':
                                    result += GetHPostfix();
                                    break;
                                case 'c':
                                    if(!string.IsNullOrEmpty(lastchars))
                                    {
                                        result += GetCFollow();
                                    }

                                    break;
                                case 'q':
                                    result += 'u';
                                    break;
                            }
                        }


                        return result;
                    }
                case CharType.Const:
                    {

                        lastGenerated = CharType.Vowel;                        
                        var i = lastchars.LastOrDefault() == 'u' ? 
                            randomizer.Next(4) : 
                            randomizer.Next(v.Length - 1);

                        var x = v[i];
                        var result = x.ToString();
                        if (!final)
                        {
                            switch (x)
                            {
                                case 'a':
                                    result += GetAFollow();
                                    break;
                                case 'e':
                                    result += GetEFollow();
                                    break;
                                case 'o':
                                    result += GetOFollow();
                                    break;
                            }
                        }

                        return result;
                    }
            }

            return string.Empty;
        }

        public string Generate(int length)
        {
            var result = string.Empty;
            var lastGenerated = CharType.None;
            var generated = string.Empty;

            while (result.Length < length)
            {
                generated = Next(generated, ref lastGenerated, (result.Length - length > 1));
                result += generated;
            }

            return result;
        }
    }
}
