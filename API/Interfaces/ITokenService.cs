using API.Entities;

namespace API.Interfaces
{
    // the reason to create interface is for testing,
    // we can mock its behaviour
    // interface is best practice, allowing us to test it whenever we want
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}