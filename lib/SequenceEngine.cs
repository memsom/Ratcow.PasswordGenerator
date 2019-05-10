using System;

namespace Ratcow.PasswordGenerator
{
    public class SequenceEngine
    {
        Random randomizer = new Random(DateTime.Now.Millisecond); // TODO - make this better
        char ProcessA(int clen, int maxlen, int vowelcount)
        {
            var chars = new char[] { 'i', 'b', 'c', 'd', 'f', 'g', 'n', 'u', 's', 't', 'l', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            if (IsVowel(result) && vowelcount > 1)
            {
                result = ProcessA(clen, maxlen, vowelcount);
            }
            return result;
        }
        char ProcessE(int clen, int maxlen, int vowelcount)
        {
            var chars = new char[] { 'a', 'i', 'b', 'c', 'd', 'f', 'g', 'n', 'u', 's', 't', 'w', 'l' };
            var result = chars[randomizer.Next(chars.Length)];
            if (IsVowel(result) && vowelcount > 1)
            {
                result = ProcessE(clen, maxlen, vowelcount);
            }
            return result;
        }

        char ProcessI(int clen, int maxlen, int vowelcount)
        {
            var chars = new char[] { 'a', 'e', 'b', 'c', 'd', 'f', 'g', 'n', 'u', 's', 't', 'w', 'l' };
            var result = chars[randomizer.Next(chars.Length)];
            if (IsVowel(result) && vowelcount > 1)
            {
                result = ProcessI(clen, maxlen, vowelcount);
            }
            return result;
        }

        char ProcessO(int clen, int maxlen, int vowelcount)
        {
            var chars = new char[] { 'a', 'i', 'b', 'c', 'd', 'f', 'g', 'n', 'u', 's', 't', 'w', 'l' };
            var result = chars[randomizer.Next(chars.Length)];
            if (IsVowel(result) && vowelcount > 1)
            {
                result = ProcessO(clen, maxlen, vowelcount);
            }
            return result;
        }

        char ProcessU(int clen, int maxlen, int vowelcount)
        {
            var chars = new char[] { 'b', 'c', 'd', 'f', 'g', 'n', 's', 'd','k', 't', 'w', 'l' };
            var result = chars[randomizer.Next(chars.Length)];
            if (IsVowel(result) && vowelcount > 1)
            {
                result = ProcessU(clen, maxlen, vowelcount);
            }
            return result;
        }

        char ProcessBP(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'r', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessS(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 't', 'h', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }



        char ProcessYVW(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessC(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'r', 'y', 'k' };
            var result = (clen == 0) ?
                chars[randomizer.Next(chars.Length - 2)] : //Skip 'k' for initial
                chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessH(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessK(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'r', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessD(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'r', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }
        char ProcessGF(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'r', 'y', 'l' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessZ(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessJ(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessR(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            var result = chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessM(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'b'};
            var result = (clen == 0) ?
                chars[randomizer.Next(chars.Length - 1)] : //Skip 'm' for initial
                chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessN(int clen, int maxlen)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'd', 'g', 't' };
            var result = (clen == 0) ?
                chars[randomizer.Next(chars.Length - 3)] : //Skip 'd', 'g', 't' for initial
                chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessL(int clen, int maxlen, bool doublel)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'd', 't', 'y', 'l' };
            var result = doublel ?
                chars[randomizer.Next(chars.Length - 1)] : //Skip 'k' for initial
                chars[randomizer.Next(chars.Length)];
            return result;
        }

        char ProcessT(int clen, int maxlen, bool doublet)
        {
            var chars = new char[] { 'a', 'e', 'i', 'o', 'u', 'r', 'h', 'y', 't' };
            var result = doublet ?
                chars[randomizer.Next(chars.Length - 1)] : //Skip 'k' for initial
                chars[randomizer.Next(chars.Length)];
            return result;
        }


        bool IsVowel(char x)
        {
            return x == 'a' || x == 'i' || x == 'e' || x == 'o' || x == 'u';
        }

        public string Generate(int length)
        {
            var result = string.Empty;

            var seed = GetSeed();
            result += seed;

            var constcount = 0;
            var vowelcount = 0;
            var lcount = 0;
            var tcount = 0;
            while (result.Length < length)
            {
                var x = ' ';
                switch (seed)
                {
                    case 'a':
                        x = ProcessA(result.Length, length, vowelcount);
                        break;
                    case 'e':
                        x = ProcessE(result.Length, length, vowelcount);
                        break;
                    case 'i':
                        x = ProcessI(result.Length, length, vowelcount);
                        break;
                    case 'o':
                        x = ProcessO(result.Length, length, vowelcount);
                        break;
                    case 'u':
                        x = ProcessU(result.Length, length, vowelcount);
                        break;
                    case 'b':
                    case 'p':
                        x = ProcessBP(result.Length, length);
                        break;
                    case 't':
                        x = ProcessT(result.Length, length,tcount > 1 || (tcount == 0 && constcount > 0));
                        break;
                    case 's':
                        x = ProcessS(result.Length, length);
                        break;
                    case 'y':
                    case 'v':
                    case 'w':
                        x = ProcessYVW(result.Length, length);
                        break;

                    case 'c':
                        x = ProcessC(result.Length, length);
                        break;
                    case 'k':
                        x = ProcessK(result.Length, length);
                        break;
                    case 'h':
                        x = ProcessH(result.Length, length);
                        break;
                    case 'l':
                        x = ProcessL(result.Length, length, lcount > 1 || (lcount == 0 && constcount > 0));
                        break;
                    case 'm':
                        x = ProcessM(result.Length, length);
                        break;
                    case 'n':
                        x = ProcessN(result.Length, length);
                        break;

                    case 'r':
                        x = ProcessR(result.Length, length);
                        break;

                    case 'd':
                        x = ProcessD(result.Length, length);
                        break;

                    case 'f':
                    case 'g':
                        x = ProcessGF(result.Length, length);
                        break;

                    case 'j':
                        x = ProcessJ(result.Length, length);
                        break;

                    case 'z':
                        x = ProcessZ(result.Length, length);
                        break;

                    case 'q':
                        x = 'u';
                        break;


                }

                result += x;
                seed = x;

                var isv = IsVowel(x);
                if (isv)
                {
                    vowelcount++;
                    constcount = 0;
                }
                else
                {
                    constcount++;
                    vowelcount = 0;
                }
                if(x == 'l')
                {
                    lcount++;
                }
                else
                {
                    lcount = 0;
                }
                if (x == 't')
                {
                    lcount++;
                }
                else
                {
                    lcount = 0;
                }
            }


            return result;
        }

        char GetSeed()
        {

            var c = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'y', 'z', 'x' };

            return c[randomizer.Next(c.Length - 1)];
        }

    }
}
