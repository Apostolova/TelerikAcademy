﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class WordDocument : OfficeDocument, IEditable
    {
        public long? NumberOfCharecters { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "numberOfCharacters")
            {
                this.NumberOfCharecters = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("numberOfCharacters", this.NumberOfCharecters));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
