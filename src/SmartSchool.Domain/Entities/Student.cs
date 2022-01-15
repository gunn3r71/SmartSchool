using System.Collections.Generic;
using SmartSchool.Domain.ValueObjects;

namespace SmartSchool.Domain.Entities
{
    public class Student : People
    {
        public Student(Name name, 
                       string phoneNumber) 
            : base(name, phoneNumber)
        {
        }
    }
}