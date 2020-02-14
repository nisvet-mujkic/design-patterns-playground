using BuilderDesignPattern.Builder;

namespace BuilderDesignPattern.Expectation
{
    public interface IExpectOtherContactsPersonBuilder
    {
        IExpectOtherContactsPersonBuilder WithOtherContact(IContact contact);

        IPersonBuilder WithNoMoreContacts();
    }
}