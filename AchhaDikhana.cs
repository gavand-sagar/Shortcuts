using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcuts
{
    public class AchhaDikhana
    {
        public static string DisplayObject<T>(T obj)
        {
            string value = string.Empty;

            var properties = typeof(T).GetProperties();

            value += "===========================\n";

            foreach (var property in properties)
            {
                value += property.Name + "\t:\t" + property.GetValue(obj).ToString() + "\n";
            }

            value += "===========================\n";


            return value;
        }
       
    }
}
