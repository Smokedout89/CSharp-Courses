﻿namespace ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }

        string GetName();
    }
}