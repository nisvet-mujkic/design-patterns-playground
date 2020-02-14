using System;

namespace BuilderDesignPattern
{
    public class PhoneNumber: IContact
    {
        private string AreaCode { get; }

        private string Number { get; }

        public PhoneNumber(string areaCode, string number)
        {
            if (string.IsNullOrEmpty(areaCode))
            {
                throw new ArgumentException(nameof(areaCode));
            }

            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentException(nameof(number));
            }

            AreaCode = areaCode;
            Number = number;
        }
    }
}
