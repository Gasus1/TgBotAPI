namespace API_IPBot2.Models
{
    public class IP_Data
    {
        public string Query { get; set; }
        public string status { get; set; }
        public string country { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string isp { get; set; }
        public string org { get; set; }
        public string As { get; set; }
    }
    public class IPCountry
    {
        public string country { get; set; }
    }
    public class Query
    {
        public string query { get; set; }
    }
    public class RegionName
    {
        public string regionName { get; set; }
    }
    public class City
    {
        public string city { get; set; }
    }
    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
    public class Isp
    {
        public string isp { get; set; }
    }
    public class Orgs
    {
        public string org { get; set; }
        public string As { get; set; }
    }
}
