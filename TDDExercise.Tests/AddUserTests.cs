using Xunit;
using Moq;
using TDDExercise.Business.Interface;
using TDDExercise.Business;

namespace TDDExercise.Tests
{
    public class AddUserTests
    {
        [Fact]
        public void Should_AddUserToRepository()
        {
            // I think this works as moq is intended.
            // Arrange
            Mock<UserRepository> mock = new Mock<UserRepository>();
            User user = new User() { Name = "Voornaam", Email = "a@a.a", LastName = "Achternaam" };

            // Act
            mock.Object.Save(user);

            // Assert
            mock.Verify(x => x.Save(user), Times.Once);
        }

        [Fact]
        public void Should_Fail_When_LastNameIsNullOrWhiteSpaces()
        {
            //TODO Somehow add code to AddUser.Save() that will produce an error. This should check for that error?
            // Arrange
            User user = new User() { LastName = "Achternaam" };

            // Assert
            Assert.NotEmpty(user.LastName);
            Assert.NotNull(user.LastName);
        }

        [Fact]
        public void Should_Fail_When_EmailIsNullOrWhiteSpace()
        {
            //TODO Somehow add code to AddUser.Save() that will produce an error. This should check for that error?
            // Arrange
            User user = new User() { Email = "a@a.a" };

            // Assert
            Assert.NotEmpty(user.Email);
            Assert.NotNull(user.Email);
        }

        [Fact]
        public void Should_GiveError_When_EmailIsAlreadyRegistered()
        {
            //TODO Use [Theory] and [InlineData] to have 3 email adresses, have it check if an email adress already exists?
            // Arrange
            Mock<UserRepository> mock = new Mock<UserRepository>();



        }
    }
}
