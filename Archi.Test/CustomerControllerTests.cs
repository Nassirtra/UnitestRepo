using Archi.API.Controllers;
using Archi.API.Models;
using Archi.Library.Models;
using Archi.Test.data;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Archi.Test
{
    public class CustomerControllerTests
    {
        private CustomersController _controller;
        private MockDbContext _context;

        [SetUp]
        public void Setup()
        {
            _context = MockDbContext.GetDbContext();
            _controller = new CustomersController(_context);
        }

        [Test]
        public async Task TestGetAll()
        {
            var actionResult = await _controller.GetAll(new Params());
            var values = actionResult.Value as IEnumerable<Customer>;

            Assert.IsNotNull(values);
            Assert.AreEqual(_context.Customers.Count(), values.Count());
        }


        [Test]
        public void TestPost()
        {
            _controller.Bob();
            Assert.Pass();
        }

        [Test]
        public async Task Task_GetPostById_Return_OkResult()
        {
            int id = 1;
            //Arrange  
            var actionResult = await _controller.GetById(id);

            var values = actionResult.Value as IEnumerable<Customer>;

            //Assert.AreEqual((int)HttpStatusCode.OK.result.StatusCode);
            //Assert.IsNotNull(values);
            //Assert.AreEqual(_context.Customers.Count(), values.Count());
        }


        [Test]
        [Fact(DisplayName = "Si le userId egal a 1 le name egal a first")]
        public void Si_le_userId_egal_a_1_le_name_egal_a_first()
        {
            //Given
            HomeTest home = new HomeTest();

            //When
            string result = home.GetUserName(1);

            //Then
            result.Should().Be("first");
        }


        //[Fact(DisplayName = "On peut créer un Customer")]
        [Test]
        public void on_peut_creer_un_customer()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "stev", "jm@gmail.com", "0948736364");

            //Then
            resultCreation.IsSuccess.Should().BeTrue();


        }

        [Test]
        public void On_ne_peut_pas_creer_un_customer_si_champs_invalides()
        {
            //Given

            //When
            var resultCreation = Customer.Create(null, "stev", "jm@gmail.com", "0948736364");

            //Then
            resultCreation.IsFailure.Should().BeTrue();
            resultCreation.Error.Should().Be("Le champ lastname est obligatoire !");


        }

       
        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_firstname_null()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche",null, "jm@gmail.com", "0948736364");

            //Then
            resultCreation.IsFailure.Should().BeTrue();

        }

        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_firstname_vide()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "", "jm@gmail.com", "0948736364");

            //Then
            resultCreation.IsFailure.Should().BeTrue();


        }

        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_email_null()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "stev", null, "0948736364");

            //Then
            resultCreation.IsFailure.Should().BeTrue();

        }

        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_email_vide()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "stev", "", "0948736364");

            //Then
            resultCreation.IsFailure.Should().BeTrue();
            resultCreation.Error.Should().Be("Le champ email est obligatoire !");


        }

        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_phone_null()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "stev", "test@gmail.com", null);

            //Then
            resultCreation.IsFailure.Should().BeTrue();
            resultCreation.Error.Should().Be("Le champ phone est obligatoire !");


        }

        [Test]
        public void on_ne_peut_pas_avoir_un_customer_avec_phone_vide()
        {
            //Given

            //When
            var resultCreation = Customer.Create("jean miche", "stev", "test@gmail.com", "");

            //Then
            resultCreation.IsFailure.Should().BeTrue();
            resultCreation.Error.Should().Be("Le champ phone est obligatoire !");


        }

    }
}
