using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp1
{
    /// <summary>
    /// VarStore class store the data of user defined variables and appends it if necessary
    /// </summary>
    public class VarStore
    {
        Dictionary<string, int> hash = new Dictionary<string, int>();

        /// <summary>
        /// Stores user provided data and variable name
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="varValue"></param>
        public void StoreData(String varName, int varValue)
        {
            hash.Add(varName, varValue);
        }

        /// <summary>
        /// Gets user provided data and variable name
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public int GetData(String varName)
        {
            int x;
            hash.TryGetValue(varName, out x);
            return x;
        }

        /// <summary>
        /// Checks user provided data and variable name
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        public bool DataExists(String varName)
        {
            int x;
            return hash.TryGetValue(varName, out x);
        }

        /// <summary>
        /// Appends user provided data and variable name
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="varValue"></param>
        public void AppendData(String varName, int varValue)
        {
            hash[varName] = varValue;
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
