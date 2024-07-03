using Random_User_Generator.Models;
using Tynamix.ObjectFiller;

namespace Random_User_Generator.Services;

public class UserService
{
  public User GenerateRandomUser()
  {
    var filler = new Filler<User>();
    filler.Setup()
      .OnProperty(u => u.Name).Use(new RealNames(NameStyle.FirstNameLastName))
      .OnProperty(u => u.Email).Use(new EmailAddresses());

    return filler.Create();
  }
}