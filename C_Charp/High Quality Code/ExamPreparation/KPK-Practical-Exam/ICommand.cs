namespace CatalogOfFreeContent
{
    using System;
    using System.Linq;
    using System.Text;

    public interface ICommand
    {
        CommandType Type { get; set; }

        string OriginalForm { get; set; }

        string Name { get; set; }

        string[] Parameters { get; set; }

        CommandType ReadCommandType(string commandName);

        string GetNameOfCommand();

        string[] ReadParameters();
    }
}
