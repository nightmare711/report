using System;

namespace Register
{
    class Program
    {
        static void Main(string[] args)
        {
            var userBuilder = new UserConcreteBuilder()
                .setFirstName("Hoang")
                .setLastName("Tran")
                .setDayOfBirth("07/11/200");

            Console.WriteLine(userBuilder.build());
        }
    }
}
