using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    /// <summary>
    /// MethodStore class store the instructions provided in a method and its parameters
    /// </summary>
    public class MethodStore
    {
        Dictionary<string, string> hash = new Dictionary<string, string>();

        /// <summary>
        /// Stores user provided instructions and parameters
        /// </summary>
        /// <param name="methodName">Name of user defined method</param>
        /// <param name="methodValue">user defined parameters</param>
        public void StoreData(String methodName, String methodValue)
        {
            hash.Add(methodName, methodValue);
        }

        /// <summary>
        /// Gets user provided instructions and parameters
        /// </summary>
        /// <param name="methodName">Name of user defined method</param>
        /// <returns></returns>
        public String GetData(String methodName)
        {
            String x;
            hash.TryGetValue(methodName, out x);
            return x;
        }

        /// <summary>
        /// Checks user provided instructions and parameters
        /// </summary>
        /// <param name="methodName">Name of user defined method</param>
        /// <returns></returns>
        public bool DataExists(String methodName)
        {
            String x;
            return hash.TryGetValue(methodName, out x);
        }

        /// <summary>
        /// Clears all variables
        /// </summary>
        public void reset()
        {
            hash.Clear();
        }
    }
}
