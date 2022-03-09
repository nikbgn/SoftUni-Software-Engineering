namespace T03
{
    using System;
    using System.Linq;


    public class Smartphone : IBrowseable, ICallable
    {
        public string Browse(string url)
        {
            if (url.Any(c=>char.IsDigit(c))) 
            {
                throw new ArgumentException(ExceptionMessages.InvalidUrlException);
            }
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExceptionMessages.InvaludNumberException);
            }

            return number.Length > 7 
                ? $"Calling... {number}"
                : $"Dialing... {number}";
        }
    }
}
