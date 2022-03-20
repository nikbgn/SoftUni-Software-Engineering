using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split();
            string cmdName = input[0];

            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == cmdName + "Command");

            if (type == null) throw new InvalidOperationException("Invalid command!");

            ICommand command = Activator.CreateInstance(type) as ICommand;

            var implementsICommand = command.GetType().GetInterface("ICommand");
            if (implementsICommand == null) throw new InvalidOperationException("Not a command!");

            string result = command.Execute(input.Skip(1).ToArray());
            return result;
           

        }
    }
}
