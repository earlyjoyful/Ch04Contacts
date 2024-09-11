using Microsoft.EntityFrameworkCore;

namespace Ch04Contacts.Models
{
    public class ContactContext : DbContext 
    {
        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options) 
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        //name, phonenum, address, note

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "Ted Danson",
                    PhoneNum = "555-0123",
                    Address = "111 Test Avenue",
                    Note = "From Becker and The Good Place"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Joey Anderson",
                    PhoneNum = "555-0124",
                    Address = "166 Testing Street",
                    Note = "Brother"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Aaron",
                    PhoneNum = "555-0125",
                    Address = "103 Pretend Ave",
                    Note = "Boyfriend"
                },
                new Contact
                {
                    ContactId = 4,
                    Name = "Nick Turner",
                    PhoneNum = "555-0126",
                    Address = "201 Fake Boulevard",
                    Note = "Nephew"
                }
                );
        }

    }
}
