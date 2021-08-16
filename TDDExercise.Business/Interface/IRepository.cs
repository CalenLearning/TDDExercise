namespace TDDExercise.Business.Interface
{
    public interface IRepository
    {
        void Save(User user);
        bool ValidateUser(User user);
    }
}
