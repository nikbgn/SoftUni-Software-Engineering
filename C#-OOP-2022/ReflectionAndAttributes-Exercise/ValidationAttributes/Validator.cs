using System;
using System.Reflection;
using System.Linq;

namespace ValidationAttributes
{
    public class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propertyInfos = obj
                .GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttributes(typeof(MyValidationAttribute)).Any())
                .ToArray();

            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                var value = propertyInfo.GetValue(obj);
                var attribute = propertyInfo.GetCustomAttribute<MyValidationAttribute>();
                bool isValid = attribute.IsValid(value);
                if (!isValid) return false;
            }
            
            return true;
            
        }
    }
}