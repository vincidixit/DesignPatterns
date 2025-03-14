using Composite.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Client
{
    public class ClientApplication
    {
        private readonly IFileSystemElement _fileSystemElement;
        public ClientApplication(IFileSystemElement fileSystemElement)
        {
            _fileSystemElement = fileSystemElement;
        }

        public void BrowseFiles()
        {
            _fileSystemElement.Display();
        }
    }
}
