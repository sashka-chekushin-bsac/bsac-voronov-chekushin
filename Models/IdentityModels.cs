using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BSAC_Voronov_Chekushin.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }


    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("ФИО")]
        public string Name { get; set; }

        [DisplayName("Адрес электронной почты")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Телефонный номер")]
        [Phone]
        [Required]
        public string Phone { get; set; }

        [DisplayName("Число мест")]
        [Required]
        public int? Seats { get; set; }

        [Required]
        [DisplayName("Дата")]
        public string Date { get; set; }

        [Required]
        [DisplayName("Время")]
        public string Time { get; set; }

        [DisplayName("Сообщение")]
        public string Message { get; set; }


    }

    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("ФИО")]
        public string Name { get; set; }


        [Required]
        [DisplayName("Адрес электронной почты")]
        [EmailAddress]
        public string Email { get; set; }


        [DisplayName("Телефонный номер")]
        [Phone]
        [Required]
        public string Phone { get; set; }

        [DisplayName("Сообщение")]
        public string Message { get; set; }
    }
}