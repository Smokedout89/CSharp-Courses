﻿namespace MilitaryElite.Contracts
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}