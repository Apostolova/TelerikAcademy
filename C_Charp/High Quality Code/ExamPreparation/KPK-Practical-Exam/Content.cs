namespace CatalogOfFreeContent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Content : IComparable, IContent
    {
        private string url;

        public Content(Categories type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)Information.Title];
            this.Author = commandParams[(int)Information.Author];
            this.Size = long.Parse(commandParams[(int)Information.Size]);
            this.URL = commandParams[(int)Information.Url];
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public long Size { get; set; }

        public string URL
        {
            get
            {
                return this.url;
            }

            set
            {
                this.url = value;
                this.TextRepresentation = this.ToString();
            }
        }

        public Categories Type { get; set; }

        public string TextRepresentation { get; set; }

        public int CompareTo(object obj)
        {
            if (null == obj)
            {
                return 1;
            }

            Content otherContent = obj as Content;
            if (otherContent != null)
            {
                int comparisonResul = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);
                return comparisonResul;
            }

            throw new ArgumentException("Object is not a Content");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(this.Type.ToString() + ": " + this.Title + "; " + this.Author + "; " + this.Size + "; " + this.URL);
            return output.ToString();
        }
    }
}
