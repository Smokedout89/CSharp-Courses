﻿namespace MilitaryElite.Contracts
{
    public interface IRepair
    {
        public string PartName { get; set; }

        public int HoursWorked { get; set; }
    }
}