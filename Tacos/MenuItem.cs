using System;

namespace Tacos
{
    public class MenuItem
    {
        public string Key { get; set; }
        public string Description { get; set; }
        public Action Function { get; set; }

        public MenuItem(string k, string d, Action f)
        {
            Key = k;
            Description = d;
            Function = f;
        }
    }
}