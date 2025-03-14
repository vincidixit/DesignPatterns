using Composite.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Implementation
{
    public class Directory : IFileSystemElement
    {
        public string Name { get; set; }

        private List<IFileSystemElement> _children = new List<IFileSystemElement>();

        public void Add(IFileSystemElement element)
        {
            _children.Add(element);
        }

        public void Remove(IFileSystemElement element)
        {
            _children.Remove(element);
        }

        public void Display()
        {
            Console.WriteLine($"Directory: {Name} ({GetSize()})");
            Console.WriteLine("Populating/expanding directory");
            Console.WriteLine($"Start of directory {Name}");
            foreach (var child in _children)
            {
                child.Display();
            }
            Console.WriteLine($"End of directory {Name}");
        }

        public long GetSize()
        {
            long size = 0;
            foreach (var child in _children)
            {
                size += child.GetSize();
            }
            return size;
        }
    }
}
