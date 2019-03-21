﻿using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = codeNumber;
        }
        public int CodeNumber { get; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + 
                $"Code Number: {this.CodeNumber}";
        }
    }
}
