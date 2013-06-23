namespace ICatalogTest
{
    using System;
    using System.Linq;
    using CatalogOfFreeContent;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Wintellect.PowerCollections;
   
    [TestClass]
    public class ICatalogTest
    {
        [TestMethod]
        public void TestMethodAddSingleItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Assert.AreEqual(1, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddMultipuleItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content song = new Content(Categories.Song, new string[] { "My song", "P.Nakov", "1276389224", "http://www.youtube.com" });
            catalog.Add(song);
            Content movie = new Content(Categories.Movie, new string[] { "The notebook", "M.Nakov", "5689745012", "http://www.introprogramming.com" });
            catalog.Add(movie);
            Assert.AreEqual(3, catalog.Count);
        }

        [TestMethod]
        public void TestMethodAddDuplicateItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content book1 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book1);
            Content book2 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book2);
            Assert.AreEqual(3, catalog.Count);
        }

        [TestMethod]
        public void TestMethodGetListContentTwoItem()
        {
            Catalog catalog = new Catalog();

            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content book2 = new Content(Categories.Book, new string[] { "Intro Java", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book2);
            var result = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(result.Count(), 1);
        }

        [TestMethod]
        public void TestMethodGetListContentMissingItem()
        {
            Catalog catalog = new Catalog();

            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content book2 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book2);
            var result = catalog.GetListContent("Intro PHP", 0);
            Assert.AreEqual(result.Count(), 0);
        }

        [TestMethod]
        public void TestMethodGetListContentSameItem()
        {
            Catalog catalog = new Catalog();

            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content book2 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book2);
            var result = catalog.GetListContent("Intro C#", 2);
            Assert.AreEqual(result.Count(), 2);
        }

        [TestMethod]
        public void TestMethodUpdateContentMissingUrl()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            catalog.UpdateContent("http://www.intro.com", "http://www.introprogramming.com");
            var actual = catalog.UpdateContent("http://www.intro.com", "http://www.introprogramming.com");
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodUpdateContentSingleItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            int actual = catalog.UpdateContent("http://www.introprogramming.info", "http://www.introprogramming.com");
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodUpdateContentMultipleItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content movie = new Content(Categories.Movie, new string[] { "Intro movie", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(movie);
            Content song = new Content(Categories.Song, new string[] { "Songs", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(song);
            int actual = catalog.UpdateContent("http://www.introprogramming.info", "http://www.introprogramming.com");
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodUpdateContentMultipleSameItem()
        {
            Catalog catalog = new Catalog();
            Content book = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book);
            Content book1 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book1);
            Content book2 = new Content(Categories.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.Add(book2);
            int actual = catalog.UpdateContent("http://www.introprogramming.info", "http://www.introprogramming.com");
            Assert.AreEqual(3, actual);
        } 
    }
}
