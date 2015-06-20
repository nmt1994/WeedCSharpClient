using System.Collections.Generic;

namespace WeedCSharpClient.Net
{
    public class LookupResult : Result
    {
        public volumeId { get; set; }
        public List<Location> locations { get; set; }
    }
}
