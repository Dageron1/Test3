namespace Test3.Entities;

public class User
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }

    public required Address MailingAddress { get; set; }
    public required Address BillingAddress { get; set; }
}
