namespace CatalogOfFreeContent
{
    using System;
    using System.Linq;
    using System.Text;

    public class Command : ICommand
    {
       private readonly char[] paramsSeparators = { ';' };
       private readonly char commandEnd = ':';

        private int commandNameEndIndex;

        public Command(string input)
        {
            this.OriginalForm = input.Trim();

            this.ReadInputData();
        }

        public CommandType Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }

        public CommandType ReadCommandType(string commandName)
        {
            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException("Incorrect name command!");
            }

            switch (commandName.Trim())
            {
                case "Add book":
                   return CommandType.AddBook;
                case "Add movie":
                   return CommandType.AddMovie;
                case "Add song":
                   return CommandType.AddSong;
                case "Add application":
                   return CommandType.AddApplication;
                case "Update":
                   return CommandType.Update;
                case "Find":
                   return CommandType.Find;
                default:
                    {
                        throw new FormatException("Invalid command name!" + commandName);
                    }
            }
        }

        public string GetNameOfCommand()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex + 1);
            return name;
        }

        public string[] ReadParameters()
        {
            int paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 3);
            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 3, paramsLength);
            string[] parameters = paramsOriginalForm.Split(this.paramsSeparators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i];
            }

            return parameters;
        }

        public int GetCommandNameEndIndex()
        {
            int endIndex = this.OriginalForm.IndexOf(this.commandEnd) - 1;
            return endIndex;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Empty + this.Name + " ");
            foreach (string param in this.Parameters)
            {
                result.Append(param + " ");
            }

            return result.ToString();
        }

        private void TrimParams()
        {
            for (int i = 0; i < this.Parameters.Length; i++)
            {
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        private void ReadInputData()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();

            this.Name = this.GetNameOfCommand();
            this.Parameters = this.ReadParameters();
            this.TrimParams();

            this.Type = this.ReadCommandType(this.Name);
        }
    }
}
