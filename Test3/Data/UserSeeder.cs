using Test3.Entities;

namespace Test3.Data;

public static class UserSeeder
{
    public static List<User> SeedUsers() => new()
    {
        new User
        {
            Id = Guid.Parse("018F0E79-5F10-7000-8B55-B2F01B93A100"),
            FirstName = "USER A",
            MailingAddress = new Address { Address1 = "123 Ave A", Zipcode = "00901" },
            BillingAddress = new Address { Address1 = "321 Blvd Z", Zipcode = "00901" }
        },
        new User
        {
            Id = Guid.Parse("018F0E79-5F11-7000-97A7-2F0D45D5A200"),
            FirstName = "USER B",
            MailingAddress = new Address { Address1 = "456 Calle B", Zipcode = "00902" },
            BillingAddress = new Address { Address1 = "654 Calle Y", Zipcode = "00902" }
        },
        new User
        {
            Id = Guid.Parse("018F0E79-5F12-7000-95F1-1C2A56E4A300"),
            FirstName = "USER C",
            MailingAddress = new Address { Address1 = "789 Street C", Zipcode = "00903" },
            BillingAddress = new Address { Address1 = "987 Ave X", Zipcode = "00903" }
        },
        new User
        {
            Id = Guid.Parse("018F0E79-5F13-7000-9A6B-9420A1D2A400"),
            FirstName = "USER D",
            MailingAddress = new Address { Address1 = "159 Camino D", Zipcode = "00904" },
            BillingAddress = new Address { Address1 = "951 Trail W", Zipcode = "00904" }
        },
        new User
        {
            Id = Guid.Parse("018F0E79-5F14-7000-847F-FD23C3B0A500"),
            FirstName = "SYSTEM USER",
            MailingAddress = new Address { Address1 = "753 Main System Way", Zipcode = "00905" },
            BillingAddress = new Address { Address1 = "357 Admin St", Zipcode = "00905" }
        }
    };
}
