using System.Collections.Generic;
using SmartSchool.Domain.ValueObjects;

namespace SmartSchool.Domain.Entities
{
    public class Teacher : People
    {
        public Teacher(Name name,
                       string phoneNumber) 
            : base(name, phoneNumber)
        {
        }

        public IEnumerable<Class> Classes { get; private set; }
    }
}