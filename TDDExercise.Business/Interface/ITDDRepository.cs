using System.Collections.Generic;

namespace TDDExercise.Business.Interface
{
    public interface ITDDRepository
    {
        void Save(User user);
        bool ValidateUser(User user);
    }
}
