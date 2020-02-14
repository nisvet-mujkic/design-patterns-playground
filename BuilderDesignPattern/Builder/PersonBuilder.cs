using BuilderDesignPattern.Expectation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Builder
{
    public class PersonBuilder: 
        IExpectSurnamePersonBuilder,
        IExpectPrimaryContactPersonBuilder,
        IExpectOtherContactsPersonBuilder,
        IPersonBuilder
    {
        private string Name { get; set; }
        private string Surname { get; set; }    
        private Person Person { get; set; }

        private PersonBuilder(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }

            Name = name;
        }
        
        public static IExpectSurnamePersonBuilder WithName(string name)
        {
            return new PersonBuilder(name);
        }

        public IExpectPrimaryContactPersonBuilder WithSurname(string surname)
        {
            if (string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException(surname);
            }

            Surname = surname;

            return this;
        }

        public IExpectOtherContactsPersonBuilder WithPrimaryContact(IContact contact)
        {
            if(contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            Person = new Person(Name, Surname, contact);

            return this;
        }

        public IExpectOtherContactsPersonBuilder WithOtherContact(IContact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            Person.AddContact(contact);

            return this;
        }

        public IPersonBuilder WithNoMoreContacts()
        {
            return this;
        }

        public IPerson Build()
        {
            return Person;
        }
    }
}
