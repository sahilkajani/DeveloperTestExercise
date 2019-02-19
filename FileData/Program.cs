using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{

    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 2)
                    throw new ArgumentException("Invalid argument entered!");

                FileManager fileManager = new FileManager();
                var result = fileManager.RunFunctionality(args[0], args[1]);
                Console.WriteLine(result);

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }


    }
}
