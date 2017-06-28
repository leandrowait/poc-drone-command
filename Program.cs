using System;
using System.Text;
using System.Text.RegularExpressions;

namespace drone_command
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "S5555";
            string b = "SSS5555";

            Console.WriteLine("nextDirectionWithMult => {0}", nextDirectionWithMult(a));
        }

        public static string nextDirectionWithMult(string input)
        {
            var match = Regex.Match(input, @"^[N,S,L,O]\d+", RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                return null;
            }

            return match.Value;
        }

        public static string nextDirectionMult()
        {

            return "";
        }

        public static string nextCancel()
        {
            return "";
        }
    }

    class Command
    {
        public char Text { get; set; }
        public int Value { get; set; }
        public bool IsMult { get; set; }

        public Command(char text, int value, bool isMult)
        {
            this.Text = text;
            this.Value = value;
            this.IsMult = isMult;
        }
    }
}
