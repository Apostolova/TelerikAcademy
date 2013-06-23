namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICatalog
    {
        /// <summary>
        /// Add content item to the catalog 
        /// </summary>
        /// <param name="content"></param>
        void Add(IContent content);

        /// <summary>
        /// Find all content item in the catalog that match the specified title.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="numberOfContentElementsToList">Maximal number of return elements</param>
        /// <returns>Returns no more than numberOfContentElementsToList elements</returns>
        IEnumerable<IContent> GetListContent(string title, int numberOfContentElementsToList);

        /// <summary>
        /// Update item by old and new URL. Get old URL and replace with New URL
        /// </summary>
        /// <param name="oldUrl">old URL</param>
        /// <param name="newUrl">new URL</param>
        /// <returns>Return count of replaces</returns>
        int UpdateContent(string oldUrl, string newUrl);
    }
}
