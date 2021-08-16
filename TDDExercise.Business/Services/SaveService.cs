using TDDExercise.Business.Interface;

namespace TDDExercise.Business
{
    public class SaveService
    {
        private readonly IRepository repository;

        public SaveService(IRepository repository)
        {
            this.repository = repository;
        }
        public void Save(User user)
        {
            repository.Save(user);
        }
    }
}
