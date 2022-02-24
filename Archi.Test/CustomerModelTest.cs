//using Archi.API.Models;
//using FluentAssertions;
//using Xunit;

//namespace Archi.Test
//{
//    public class CustomerModelTest
//    {

//        [Fact(DisplayName = "On peut créer un Customer")]
//        public void on_peut_creer_un_customer()
//        {
//            Given

//            When
//            var resultCreation = Customer.Create("jean miche", "stev", "jm@gmail.com", "0948736364");

//            Then
//            resultCreation.IsSuccess.Should().BeTrue();


//        }

//        [Fact(DisplayName = "On peut créer un Customer")]
//        public void On_ne_peut_pas_creer_un_customer_si_champs_invalides()
//        {
//            Given

//            When
//            var resultCreation = Customer.Create(null, "stev", "jm@gmail.com", "0948736364");

//            Then
//            resultCreation.IsFailure.Should().BeTrue();
//            resultCreation.Error.Should().Be("Le champ lastname est obligatoire !");


//        }
//    }
//}
