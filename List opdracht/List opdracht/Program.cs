namespace List_opdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> birds = new List<string>()
            {
                "uil", "kraai", "hond", "papagaai"
            };

            List<string> birds2 = new List<string>()
            {
                "meeuw", "duif"
            };
            
            birds.AddRange(birds2);

            birds.Remove("hond");

            birds.Count();

            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);
            };
            
        }
    }
}
