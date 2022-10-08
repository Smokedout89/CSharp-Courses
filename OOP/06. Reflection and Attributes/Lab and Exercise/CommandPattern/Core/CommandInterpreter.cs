﻿namespace CommandPattern.Core
{
    using System;
    using Contracts;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] input = args.Split();

            string commandName = input[0];
            string[] value = input.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type type = assembly
                .GetTypes()
                .FirstOrDefault(n => n.Name == $"{commandName}Command");

            if (type == null)
            {
                throw new InvalidOperationException("Missing command");
            }

            Type commandInterface = type.GetInterface("ICommand");

            if (commandInterface == null)
            {
                throw new InvalidOperationException("Not a command");
            }

            ICommand command = Activator.CreateInstance(type) as ICommand;

            string result = command.Execute(value);

            return result;
        }
    }
}