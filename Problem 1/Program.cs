namespace VanyaAndFence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NoOfFriends, HieghtOfFence,RoadWidth=0;

            Console.WriteLine("Enter No Of Friends");
            NoOfFriends=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height Of Fence");
            HieghtOfFence = Convert.ToInt32(Console.ReadLine());

            int[] Hieghts=new int[NoOfFriends];

            Console.WriteLine("Please Enter Heights");
            for (int i = 0; i < Hieghts.Length; i++)
            {
                Hieghts[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < Hieghts.Length; i++)
            {
                if (Hieghts[i] <= HieghtOfFence)
                    RoadWidth++;
                else
                    RoadWidth = RoadWidth + 2;
            }

            Console.WriteLine(RoadWidth);

        }
    }
}
