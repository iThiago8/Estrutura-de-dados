using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Product : IEquatable<Product>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public bool Equals(Product other)
        {
            if (other == null) return false;
            return this.Id == other.Id;
        }
        public override bool Equals(object obj)
        {
            if (obj is Product other)
                return Equals(other);
            else
                return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override string? ToString()
        {
            return $"{Id} - {Name}";
        }

	}
}