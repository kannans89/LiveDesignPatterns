using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternApp
{
    internal class NamesRepository:IEnumerable
    {
        private string[] _names;

        public NamesRepository(string namesCsvList)
        {
            _names = namesCsvList.Split(',');
        }

        public void AddName(string newName)
        {
            // Resize the array to accommodate the new name
            Array.Resize(ref _names, _names.Length + 1);

            // Add the new name to the end of the array
            _names[_names.Length - 1] = newName;
        }

        public IEnumerator GetEnumerator()
        {
            return new NamesArrayEnumerator(this);
        }

        public IEnumerator MakeEnumerator()
        {

            return new NamesArrayEnumerator(this);
        }

        public class NamesArrayEnumerator : IEnumerator
        {


            private NamesRepository _repo;
            int _index = -1;
            public NamesArrayEnumerator(NamesRepository repo)
            {
                _repo = repo;
            }
            public object Current
            {
                get
                {
                    string current = _repo._names[_index];
                    return current;
                }
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _repo._names.Length;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }
}
