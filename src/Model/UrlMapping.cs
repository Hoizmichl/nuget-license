namespace NugetUtility
{
    public class UrlMapping
    {
        // Used to match a package
        public string MatchId { get; set; }
        public string MatchVersion { get; set; }

        // Data for building the URLs
        public string Space { get; set; }
        public string Repository { get; set; }
        public string LicenseFile { get; set; }

        // Will be applied to the extracted data
        public string PackageName { get; set; }
        public string ProjectUrl { get; set; }
        public string SourceUrl { get; set; }
        public string LicenseUrl { get; set; }
        public string LicenseType { get; set; }
    }
}