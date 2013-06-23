namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CommandExecuter : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contentCatalog, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                        contentCatalog.Add(new Content(Categories.Book, command.Parameters));
                        output.AppendLine("Book added");
                        break;

                case CommandType.AddMovie:
                        contentCatalog.Add(new Content(Categories.Movie, command.Parameters));
                        output.AppendLine("Movie added");
                        break;

                case CommandType.AddSong:
                        contentCatalog.Add(new Content(Categories.Song, command.Parameters));
                        output.AppendLine("Song added");
                        break;

                case CommandType.AddApplication:
                        contentCatalog.Add(new Content(Categories.Aplication, command.Parameters));
                        output.AppendLine("Application added");
                        break;

                case CommandType.Update:
                        ExecuteCommandUpdate(contentCatalog, command, output);
                        break;

                case CommandType.Find:
                        ExecuteCommandFind(contentCatalog, command, output);
                        break;

                default:
                    {
                        throw new FormatException("Unknown command!" + command.Type);
                    }
            }
        }

        private static void ExecuteCommandUpdate(ICatalog contentCatalog, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new FormatException("Invalid params");
            }

            output.AppendLine(contentCatalog.UpdateContent(command.Parameters[0], command.Parameters[1]) + " items updated");
        }

        private static void ExecuteCommandFind(ICatalog contentCatalog, ICommand command, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new ArgumentException("Invalid number of parameters!");
            }

            int numberOfElementsToList = int.Parse(command.Parameters[1]);
            IEnumerable<IContent> foundContent = contentCatalog.GetListContent(command.Parameters[0], numberOfElementsToList);
            if (foundContent.Count() == 0)
            {
                output.AppendLine("No items found");
            }
            else
            {
                foreach (IContent content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }
            }
        }
    }
}
