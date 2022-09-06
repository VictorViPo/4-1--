using System;

namespace CardStorageService
{
    internal class TableAttribute : Attribute
    {
        public TableAttribute(string v)
        {
            V = v;
        }

        public string V { get; }
    }
}