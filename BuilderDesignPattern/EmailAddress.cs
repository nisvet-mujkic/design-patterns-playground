using System;

namespace BuilderDesignPattern
{
    public class EmailAddress : IContact
    {
        private string Address { get; }

        public EmailAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException(nameof(address));
            }

            Address = address;
        }
    }
}