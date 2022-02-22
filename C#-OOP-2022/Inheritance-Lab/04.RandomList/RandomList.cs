using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            Random rand = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

    }
}
