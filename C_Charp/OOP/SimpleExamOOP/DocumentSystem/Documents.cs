using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class Documents : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }


        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            if (key == "content")
            {
                this.Content = value;
            }

        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));

        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            properties.Sort((a, b) => a.Key.CompareTo(b.Key));
            StringBuilder str = new StringBuilder();
            str.Append(this.GetType().Name);
            str.Append("[");
            bool first = true;
            foreach (var prop in properties)
            {
                if (prop.Value != null)
                {
                    if (!first)
                    {
                        str.Append(";");
                    }
                    str.AppendFormat("{0}={1}", prop.Key, prop.Value);
                    first = false;
                }
            }
            str.Append("]");
            return str.ToString();
        }
    }
}
