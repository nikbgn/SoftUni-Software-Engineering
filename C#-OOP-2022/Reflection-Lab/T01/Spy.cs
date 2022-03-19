namespace Stealer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] fields = classType.GetFields(
                BindingFlags.Instance | 
                BindingFlags.Public |
                BindingFlags.Static|
                BindingFlags.NonPublic);
            StringBuilder output = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });
            output.AppendLine($"Class under investigation: {investigatedClass}");
            foreach (FieldInfo field in fields.Where(x => requestedFields.Contains(x.Name)))
            {
                output.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return output.ToString().Trim();
        }
    }
}
