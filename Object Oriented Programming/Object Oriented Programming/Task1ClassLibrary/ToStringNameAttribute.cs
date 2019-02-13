namespace StudentBookClassLibrary
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ToStringNameAttribute : Attribute
    {
        public ToStringNameAttribute(string displayedName)
        {
            this.DisplayedName = displayedName;
        }

        public string DisplayedName { get; set; }
    }
}