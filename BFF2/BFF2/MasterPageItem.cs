using System;
namespace BFF2
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public string UqName { get; set; }
        public Type TargetType { get; set; }
        public CustomImage[] Images { get; set; }
    }
}
