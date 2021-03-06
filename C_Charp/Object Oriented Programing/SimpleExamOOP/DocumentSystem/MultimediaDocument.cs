﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class MultimediaDocument : BinaryDocument
    {
        public long? Length { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }
}
