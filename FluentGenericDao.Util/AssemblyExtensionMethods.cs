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
            Assembly _assemnbly = AppDomain.CurrentDomain.GetAssemblies().Where(p => p.FullName.Contains(typeName)).FirstOrDefault();
            return _assemnbly;
        }

    }
}
