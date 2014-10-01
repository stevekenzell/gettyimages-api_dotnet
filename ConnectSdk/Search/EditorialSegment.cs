using System;

namespace GettyImages.Connect.Search
{
    [Flags]
    public enum EditorialSegment
    {
        None = 0,
        Archival = 1,
        Entertainment = 2,
        News = 4,
        Publicity = 8,
        Royalty = 16,
        Sport = 32,
    }
}