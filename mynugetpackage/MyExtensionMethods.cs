using System;

namespace mynugetpackage
{
    public class MyExtensionMethods
    {
        public DateTime Today() => System.DateTime.Now;

        public int ThisYear() => System.DateTime.Now.Year;
    }
}
