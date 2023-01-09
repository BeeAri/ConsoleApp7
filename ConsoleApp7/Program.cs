namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("c:\\Program Files");
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
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(folder.Name);

                    foreach (var file in folder.GetFiles())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(file.Name);  
                    };
                    Don(folder);
                }

            }
            catch (Exception)
            {

              
            }
            

        }
    }
}