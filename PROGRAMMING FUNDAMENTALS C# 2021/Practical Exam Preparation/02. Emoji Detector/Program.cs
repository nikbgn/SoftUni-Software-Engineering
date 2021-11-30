using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ulong threshold = findThreshold(input,false);
            Console.WriteLine($"Cool threshold: {threshold}");
            string pattern = @"(?<emojiWithSymbols>(\:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1)";
            MatchCollection matches = Regex.Matches(input, pattern);
            int emojiCount = 0;
            List<String> emojiList = new List<string>();
            foreach (Match match in matches)
            {
                emojiCount++;
                string currEmojiName = match.Groups["emojiName"].Value;
                string currEmojiWithSymbols = match.Groups["emojiWithSymbols"].Value;
                ulong currEmojiTreshold = findThreshold(currEmojiName,true);
                if (currEmojiTreshold > threshold)
                {
                    if (emojiList.Contains(currEmojiWithSymbols) == false)
                    {
                        emojiList.Add(currEmojiWithSymbols);
                    }
                }

            }

            Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");

            foreach (var item in emojiList)
            {
                Console.WriteLine(item);
            }


        }

        public static ulong findThreshold(string input, bool flagEmojiOrNo)
        {
            ulong result = 1;

            if(flagEmojiOrNo == false) //Calculate treshold of input
            {
                foreach (char elem in input)
                {
                    if (char.IsDigit(elem)) { result *= ulong.Parse(elem.ToString()); }
                }
            }
            else //Else, the flagEmojiOrNo = true -> calculate emoji treshold
            {
                foreach (char elem in input)
                {
                    result += elem;
                }
            }

            return result;
        }
    }
}
