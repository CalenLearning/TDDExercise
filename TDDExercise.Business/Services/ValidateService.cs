using TDDExercise.Business.Interface;

namespace TDDExercise.Business
{
    public class ValidateService
    {
        private readonly IRepository repository;

        public ValidateService(IRepository repository)
        {
            this.repository = repository;
        }

        public bool Validate(User user)
        {
            bool userValid = false;

            user.LastName = user.LastName.Trim();
            user.Email = user.Email.Trim();

            if (user.LastName.Length > 0)
            {
                if (user.Email.Length > 0 &&
                    user.Email.Contains('@') &&
                    user.Email.Contains('.'))
                {
                    //TODO somehow check if the repository contains the email already
                    userValid = true;
                }
                else
                {
                    System.Console.WriteLine("Invalid email adress.");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid last name.");
            }

            return userValid;
        }
    }
}
