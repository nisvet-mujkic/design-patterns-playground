using BuilderDesignPattern.Builder;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = PersonBuilder
                         .WithName("Nisvet")
                         .WithSurname("Mujkic")
                         .WithPrimaryContact(new EmailAddress("nisvet.mujkic@outlook.com"))
                         .WithNoMoreContacts()
                         .Build();


        }
    }
}
