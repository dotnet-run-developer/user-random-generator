using Random_User_Generator.Models;
using Random_User_Generator.Services;

namespace Random_User_Generator;

internal abstract class Program
{
  private static void Main()
  {
    Console.Write("How many random users do you want to generate? ");
    if (int.TryParse(Console.ReadLine(), out int numberOfUsers) && numberOfUsers > 0)
    {
      UserService userService = new UserService();

      for (int i = 0; i < numberOfUsers; i++)
      {
        User randomUser = userService.GenerateRandomUser();

        Console.WriteLine($"User {i + 1}: {randomUser.Name}, Email: {randomUser.Email}");
      }
    }
    else
    {
      Console.WriteLine("Please enter a valid number greater than 0.");
    }
  }
}

