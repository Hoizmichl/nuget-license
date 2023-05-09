using System.Collections.Generic;

namespace NugetUtility
{
    public class UrlMappingRoot
    {
        public List<UrlPattern> UrlPatterns { get; set; }
        public List<UrlMapping> UrlMappings { get; set; }
    }
}
