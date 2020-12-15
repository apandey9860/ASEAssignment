using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    public class MethodStore
    {
        Dictionary<string, string> hash = new Dictionary<string, string>();
        public void StoreData(String methodName, String methodValue)
        {
            hash.Add(methodName, methodValue);
        }
        public String GetData(String methodName)
        {
            String x;
            hash.TryGetValue(methodName, out x);
            return x;
        }

        public bool DataExists(String methodName)
        {
            String x;
            return hash.TryGetValue(methodName, out x);
        }

        public void reset()
        {
            hash.Clear();
        }
    }
}
