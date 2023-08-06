namespace Contexts.Users.Domain;

public interface IUserRepository
{
    Task<List<User>> GetAll();
    Task<User> GetById(string id);
    Task<bool> Add(User person);
    Task<bool> Update(User person);
    Task<bool> Delete(User user);
}