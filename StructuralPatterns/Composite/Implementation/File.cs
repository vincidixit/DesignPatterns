using Composite.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementation
{
    public class File : IFileSystemElement
    {
        public string Name { get; set; }

        public long Size { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name} ({Size}) kb");
        }

        public long GetSize()
        {
            return Size;
        }
    }
}
