using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Expectation
{
    public interface IExpectPrimaryContactPersonBuilder
    {
        IExpectOtherContactsPersonBuilder WithPrimaryContact(IContact contact);
    }
}
