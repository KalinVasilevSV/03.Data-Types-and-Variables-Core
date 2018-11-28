using System;

namespace _19.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            // I am really happy with this solution. Programming is AWESOME!!

            string inputNum = Console.ReadLine();

            string viableFormats = string.Empty; //viableFormats can also be set to null
            
            for (int i = 0; i < 7; i++)
            {

                switch (i)
                {
                    case 0:
                        try
                        {
                            sbyte sByte = sbyte.Parse(inputNum);
                            viableFormats += "* sbyte \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 1:
                        try
                        {
                            byte uByte = byte.Parse(inputNum);
                            viableFormats += "* byte \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 2:
                        try
                        {
                            short sShort = short.Parse(inputNum);
                            viableFormats += "* short \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 3:
                        try
                        {
                            ushort uShort = ushort.Parse(inputNum);
                            viableFormats += "* ushort \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 4:
                        try
                        {
                            int sInt = int.Parse(inputNum);
                            viableFormats += "* int \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 5:
                        try
                        {
                            uint uInt = uint.Parse(inputNum);
                            viableFormats += "* uint \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    case 6:
                        try
                        {
                            long uLong = long.Parse(inputNum);
                            viableFormats += "* long \n";
                        }
                        catch (Exception) { continue; }
                        break;
                    default:
                        break;
                }
            }

            if (viableFormats!=string.Empty) //can compare with null if initialized with value of null
            {
                Console.WriteLine($"{inputNum} can fit in:");
                Console.WriteLine(viableFormats);
            }
            else
            {
                Console.WriteLine($"{inputNum} can't fit in any type");
            }
        }
    }
}




