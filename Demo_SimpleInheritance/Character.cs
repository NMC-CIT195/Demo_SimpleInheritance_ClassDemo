using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleInheritance
{
    public abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Character()
        {

        }

        public Character(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            IsActive = isActive;
        }

        //public virtual string Greeting()
        //{
        //    if (IsActive)
        //    {
        //        return $"Hello! My name is {Name}";
        //    }
        //    else
        //    {
        //        return $"{Name} is no longer in the building.";
        //    }
        //}

        public abstract string Greeting();
    }
}
