using Composite.Abstraction;
using Composite.Client;
using Directory = Composite.Implementation.Directory;
using File = Composite.Implementation.File;

namespace Composite
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFileSystemElement element = CreateFileSystemStructure();

            ClientApplication client = new ClientApplication(element);
            client.BrowseFiles();

        }

        private static Directory CreateFileSystemStructure()
        {
            var root = new Directory { Name = "Root" };
            var dir1 = new Directory { Name = "Dir1" };
            var dir2 = new Directory { Name = "Dir2" };

            var file1 = new File { Name = "File1", Size = 100 };
            var file2 = new File { Name = "File2", Size = 200 };
            var file3 = new File { Name = "File3", Size = 300 };
            var file4 = new File { Name = "File4", Size = 400 };

            dir1.Add(file1);
            dir1.Add(file2);

            dir2.Add(file3);
            dir2.Add(file4);
            dir1.Add(dir2);

            root.Add(dir1);
            return root;
        }
    }
}
