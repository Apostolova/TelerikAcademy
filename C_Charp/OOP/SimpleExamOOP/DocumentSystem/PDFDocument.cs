﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public class PDFDocument : Encryptable
    {
        public long? NumberOFPages { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "numberOfPages")
            {
                this.NumberOFPages = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("numberOfPages", this.NumberOFPages));
        }
    }
}