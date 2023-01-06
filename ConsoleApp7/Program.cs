namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("c:\\");
            var dirList = di.GetDirectories();
            foreach (var folder in dirList)
            {
                Console.WriteLine(folder.Name);
                Don(folder);
            }

        }

        static void Don(DirectoryInfo di)
        {
            try
            {
                var dirList = di.GetDirectories();
                foreach (var folder in dirList)
                {
                    Console.WriteLine(folder.Name);
                    Don(folder);
                }

            }
            catch (Exception)
            {

              
            }
            

        }
    }
}