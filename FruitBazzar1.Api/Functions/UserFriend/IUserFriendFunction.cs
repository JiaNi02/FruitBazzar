namespace FruitBazzar1.Api.Functions.UserFriend
{
    public interface IUserFriendFunction
    {
        Task<IEnumerable<User.User>> GetListUserFriend(int userId);
    }
}
