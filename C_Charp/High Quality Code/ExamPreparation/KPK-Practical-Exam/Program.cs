namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog cat = new Catalog();
            ICommandExecutor c = new CommandExecuter();

            foreach (ICommand item in Parse())
            {
                c.ExecuteCommand(cat, item, output);
            }

            Console.Write(output);
        }

        private static List<ICommand> Parse()
        {
            List<ICommand> ins = new List<ICommand>();
            bool end = false;

            do
            {
                string line = Console.ReadLine();
                end = line.Trim() == "End";
                if (!end)
                {
                    ins.Add(new Command(line));
                }
            }
            while (!end);
            return ins;
        }
    }
}