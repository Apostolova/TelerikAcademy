namespace CatalogOfFreeContent
{
    using System;
    using System.Linq;

    public enum CommandType
    {
        AddBook,
        AddMovie,
        AddSong,
        AddApplication,
        Update, 
        Find,
    }

    public enum Categories
    {
        Book,
        Movie,
        Song,
        Aplication,
    }

    public enum Information
    {
        Title = 0, 
        Author,
        Size,
        Url,
    }
}
