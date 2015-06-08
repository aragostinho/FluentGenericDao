using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class AssemblyExtensionMethods
    {
        public static Assembly GetAssembly(this String typeName)
        {
            foreach (Assembly currentassembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type t = currentassembly.GetType(typeName, false, true);
                if (t != null) { return currentassembly; }
            }

            return null;
        }

    }
}
