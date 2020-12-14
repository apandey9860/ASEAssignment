using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    public class VarStore
    {
        Dictionary<string, int> hash = new Dictionary<string, int>();
        public void StoreData(String varName, int varValue)
        {
            hash.Add(varName, varValue);
        }
        public int GetData(String varName)
        {
            int x;
            hash.TryGetValue(varName, out x);
            return x;
        }

        public bool DataExists(String varName)
        {
            int x;
            return hash.TryGetValue(varName, out x);
        }

        public void AppendData(String varName, int varValue)
        {
            hash[varName] = varValue;
        }
    }
}
