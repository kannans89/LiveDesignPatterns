using CompositePatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp.Operations
{
    internal class DisplayOccuranceOperation : IOperation
    {
        private int _fileCount;
        private int _folderCount;
        public void Apply(File file)
        {
            _fileCount++;
        }

        public void Apply(Folder folder)
        {
            _folderCount++;
        }

        public void PrintDetails() {

            Console.WriteLine($"Total Files: {_fileCount}");
            Console.WriteLine($"Total Folders: {_folderCount}");
        }
    }
}
