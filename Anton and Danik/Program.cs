namespace Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Anton=0, Danik=0;
            Console.WriteLine("No of Games");
            int NoOfGames = Convert.ToInt32(Console.ReadLine());

            string Result;


            for (int i = 1; i <= NoOfGames; i++)
            {
                Console.WriteLine($"Enter Result of Game No {i}");
                Result = Console.ReadLine();

                if (Result == "A")
                    Anton++;
                else if (Result == "D")
                    Danik++;
                else
                {
                    Console.WriteLine("Enter A or D");
                    Result = Console.ReadLine();
                    if (Result == "A")
                        Anton++;
                    else if (Result == "D")
                        Danik++;
                }
            }

            if(Anton >Danik)
                Console.WriteLine("Anton");
            else if (Anton < Danik)
                Console.WriteLine("Danik");
            if (Anton == Danik) Console.WriteLine("Friendship");

        }
    }
}
