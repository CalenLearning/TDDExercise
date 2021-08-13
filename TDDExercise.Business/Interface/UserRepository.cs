using System.Collections.Generic;

namespace TDDExercise.Business.Interface
{
    public interface UserRepository
    {
        void Save(User user);
        bool ValidateUser(User user);
    }
}
