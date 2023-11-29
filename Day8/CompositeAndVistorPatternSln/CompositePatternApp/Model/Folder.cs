using CompositePatternApp.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp.Model
{
    internal class Folder:IStorageItem
    {
        private string _name;
        private List<IStorageItem> _children;
        public Folder(string name)
        {
            _name = name;
            _children = new List<IStorageItem>();
        }
        public void AddChild(IStorageItem childItem)
        {
            _children.Add(childItem);
        }

        public void Display(int depth=0)
        {
            for(int i = 0; i < depth; i++)
                Console.Write("  ");

            Console.WriteLine("{0}", _name);
            foreach (IStorageItem child in _children)
            {
                int childDepth = depth;
                child.Display(++childDepth);
            }

        }

        public void Execute(IOperation operation)
        {
            operation.Apply(this);

            foreach (IStorageItem child in _children)
            {
                child.Execute(operation);
            }

        }
    }
}
