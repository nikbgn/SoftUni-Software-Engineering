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
                BindingFlags.Static |
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

        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder output = new StringBuilder();
            Type currentClass = Type.GetType(className);
            FieldInfo[] classFields = currentClass.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] classPublicMethods = currentClass.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] classPrivateMethods = currentClass.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var classField in classFields)
            {
                output.AppendLine($"{classField.Name} must be private!");
            }
            foreach (var publicMethod in classPublicMethods.Where(x => x.Name.StartsWith("get")))
            {
                output.AppendLine($"{publicMethod.Name} have to be public!");
            }
            foreach (var nonPublic in classPublicMethods.Where(x => x.Name.StartsWith("set")))
            {
                output.AppendLine($"{nonPublic.Name} have to be private!");
            }




            return output.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            StringBuilder output = new StringBuilder();
            Type classType = Type.GetType(className);
            output.AppendLine($"All Private Methods of Class: {classType}");
            output.AppendLine($"Base Class: {classType.BaseType.Name}");
            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var method in privateMethods)
            {
                output.AppendLine(method.Name);
            }

            return output.ToString().Trim();
        }

    }
}
