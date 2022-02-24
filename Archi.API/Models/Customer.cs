using Archi.Library.Models;
using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations;

namespace Archi.API.Models
{
    //[Table("Client")]
    public class Customer : BaseModel
    {
        public Customer()
        {
        }

        public Customer(string lastname, string firstname, string email, string phone)
        {
            Lastname = lastname;
            Firstname = firstname;
            Email = email;
            Phone = phone;
        }



        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid ID { get; set; }

        //[StringLength(30)]
        public string Lastname { get; set; }
        //[Column("Prenom")]
        public string Firstname { get; set; }
        //[Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        //Les régles metiers
        public static Result<Customer> Create(string lastname, string firstname, string email, string phone)
        {
            if (lastname == null || lastname == "") return Result.Failure<Customer>("Le champ lastname est obligatoire !");
            if (firstname == null || firstname == "") return Result.Failure<Customer>("Le champ firstname est obligatoire !");
            if (email == null || email == "") return Result.Failure<Customer>("Le champ email est obligatoire !");
            if (phone == null || phone == "") return Result.Failure<Customer>("Le champ phone est obligatoire !");

            return Result.Success(new Customer(lastname, firstname, email, phone));
        }


    }
}
