using BuilderDesignPattern.Builder;
using System;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    public class Person: IPerson
    {
        private string Name { get; }

        private string Surname { get; }

        private IContact PrimaryContact { get; set; }

        private IList<IContact> AllContacts { get; }

        public Person(string name, string surname, IContact primaryContact)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(nameof(name));
            }

            if (string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException(nameof(surname));
            }

            Name = name;
            Surname = surname;
            AllContacts = new List<IContact>();
        }

        public void SetPrimaryContact(IContact contact)
        {
            AddContact(contact);
            PrimaryContact = contact;
        }

        public void AddContact(IContact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }

            AllContacts.Add(contact);
        }
    }
}
