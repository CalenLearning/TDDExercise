using Moq;
using TDDExercise.Business;
using TDDExercise.Business.Interface;
using Xunit;

namespace TDDExercise.Tests
{
    public class AddUserTests
    {
        private readonly Mock<IRepository> mock;
        private readonly ValidateService validateService;

        public AddUserTests()
        {
            mock = new Mock<IRepository>();
            validateService = new ValidateService(mock.Object);
        }

        [Fact]
        public void Should_AddUserToRepository()
        {
            // I think this works as moq is intended.
            // Arrange
            User user = new User() { FirstName = "Voornaam", Email = "a@a.a", LastName = "Achternaam" };

            // Act
            mock.Object.Save(user);

            // Assert
            mock.Verify(x => x.Save(user), Times.Once);
        }

        [Fact]
        public void Should_Pass_When_LastNameIsNullOrWhiteSpaces()
        {
            // Arrange
            User emptyName = new User() { Email = "a@a.a", LastName = "          " };

            // Assert
            Assert.False(validateService.Validate(emptyName));
        }

        [Fact]
        public void Should_Pass_When_EmailIsNullOrWhiteSpace()
        {
            // Arrange
            User emptyEmail = new User() { LastName = "a", Email = "      " };

            // Assert
            Assert.False(validateService.Validate(emptyEmail));
        }

        [Theory]
        [InlineData("a", "aa.a")]
        [InlineData("a", "aa@a")]
        public void Should_Pass_When_AtOrPeriodIsMissingFromEmail(string a, string b)
        {
            User invalidEmail = new User(){ LastName = a, Email = b};
            // Assert
            Assert.False(validateService.Validate(invalidEmail));
        }

        [Fact]
        public void Should_GiveError_When_EmailIsAlreadyRegistered()
        {
            //TODO Use [Theory] and [InlineData] to have 3 email adresses, have it check if an email adress already exists?
            // Arrange
            Mock<IRepository> mock = new Mock<IRepository>();



        }
    }
}
