using System;

namespace Mathador
{
    internal class Generator
    {
        public DateTime Expiry { get; internal set; }
        public string Name { get; internal set; }
        public int[] Sizes { get; internal set; }
    }
}