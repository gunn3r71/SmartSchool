using System.Collections.Generic;

namespace SmartSchool.Domain.Entities
{
    public class Class : Entity
    {
        protected Class()
        {
        }

        public Class(string name,
                     int teacherId)
        {
            Name = name;
            TeacherId = teacherId;
        }

        public string Name { get; private set; }
        public int TeacherId { get; private set; }
        public Teacher Teacher { get; private set; }
        public IEnumerable<StudentClasses> StudentClasses { get; private set; }
    }
}