using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        //Common Fields
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        //Common Constructors
        public JobField()
        {
            Id = nextId;
            nextId++;
        }
        public JobField(string value) : this()
        {
            Value = value;
        }

        //Common Methods
        public override bool Equals(object obj)
        {
            return obj is JobField jobField &&
                   Id == jobField.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Value))
            {
                Value = "Data Not Available";
            }
            return Value;
        }
    }
}
