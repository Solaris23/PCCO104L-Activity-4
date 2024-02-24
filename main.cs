using System;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        string message = "";

        while (true)
        {
            Console.Write("Enter something: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Closing program...");
                break;
            }

            int number;
            bool isNumeric = int.TryParse(input, out number);

            if (isNumeric)
            {
                sum += number;
                Console.WriteLine($"Adding {number} to {sum - number} = {sum}");
            }
            else
            {
                message += input;
                Console.WriteLine($"Current message is: {message}");
            }
        }
    }
}






/* string output = "";
  string input = "";
  do
  {
      Console.Write("Enter Input: ");
      input = Console.ReadLine();
      if(input != "exit")
      {
          output += input + " ";
          Console.WriteLine("Output: " + output.Trim());
      }
      else
      {
          Console.WriteLine("Output: exit");
          break;
      }
  } while (true);
  Console.WriteLine("Exiting Program...");
}
}
*/