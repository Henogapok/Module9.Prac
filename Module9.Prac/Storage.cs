using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.Prac
{
    public abstract class Storage
    {
        public string Name { get; set; }
        public Storage(string name)
        {
            this.Name = name;
        }
        public abstract double GetSize();
        public abstract double CopyAllFiles();
        public abstract double GetFreeSize();
        public abstract void GetInfo();
    }
}
