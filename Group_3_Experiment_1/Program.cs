namespace Group_3_Experiment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bhai, ga-ulan ba, bhai? (Y/N) ");
            string input = Console.ReadLine();

            bool isRaining = true;
            if (input == "N")
                isRaining = false;

            if (isRaining == true)
            {
                Console.Write("Bhai, bawal ka mugawas ha!");
            }
            else
            {
                Console.Write("Sige, gawas lang didto, bhai.");
            }

        }
    }
}
