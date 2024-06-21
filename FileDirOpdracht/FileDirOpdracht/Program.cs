

namespace FileDirOpdracht
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Jamal Alniel\Desktop\Github Jamal\M4\2024P4ProgCs2");
            foreach (FileInfo file in dir.GetFiles()) 
            {
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo directories in dir.GetDirectories()) 
            { 
                Console.WriteLine(directories.Name); 
            }


        }


    }
}
