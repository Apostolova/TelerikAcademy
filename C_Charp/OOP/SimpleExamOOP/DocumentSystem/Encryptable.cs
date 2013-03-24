using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem_1
{
    public abstract class Encryptable : BinaryDocument, IEncryptable
    {
        public bool isEncrypted = false;
        public bool IsEncrypted
        {
            get
            {
                return this.isEncrypted;
            }
        }

        public void Encrypt()
        {
            isEncrypted = true;
        }

        public void Decrypt()
        {
            isEncrypted = false;
        }

        public override string ToString()
        {
            if (this.isEncrypted)
            {
                return String.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
