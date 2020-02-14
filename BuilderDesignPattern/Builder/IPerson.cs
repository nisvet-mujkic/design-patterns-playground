namespace BuilderDesignPattern.Builder
{
    public interface IPerson
    {
        void SetPrimaryContact(IContact primaryContact);

        void AddContact(IContact contact);
    }
}