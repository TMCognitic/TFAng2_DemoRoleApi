namespace DemoRoleApi.Models
{
    public interface IUser
    {
        string Email { get; }
        string FirstName { get; }
        int Id { get; }
        string LastName { get; }
        string Token { get; }
    }
}