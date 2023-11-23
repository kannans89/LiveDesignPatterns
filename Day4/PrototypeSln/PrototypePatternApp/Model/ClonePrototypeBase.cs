using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternApp.Model
{
    internal abstract class ClonePrototypeBase<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T CloneDeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
