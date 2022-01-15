using SmartSchool.Domain.ValueObjects;

namespace SmartSchool.Domain.Entities
{
    public abstract class People : Entity
    {
        protected People()
        {
        }

        protected People(Name name, 
                         string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public Name Name { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}