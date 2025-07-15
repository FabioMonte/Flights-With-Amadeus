namespace Flights.Models
{
    public class RootObject
    {
        public Data[] data { get; set; }
        public Dictionaries dictionaries { get; set; }
        public Meta meta { get; set; }
        public object[] warnings { get; set; }
    }

    public class Data
    {
        public string type { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public Price price { get; set; }
        public Links links { get; set; }
    }

    public class Price
    {
        public string total { get; set; }
    }

    public class Links
    {
        public string flightDates { get; set; }
        public string flightOffers { get; set; }
    }

    public class Dictionaries
    {
        public Currencies currencies { get; set; }
    }

    public class Currencies
    {
        public string EUR { get; set; }
    }

    public class Meta
    {
        public string currency { get; set; }
        public Links1 links { get; set; }
        public Defaults defaults { get; set; }
    }

    public class Links1
    {
        public string self { get; set; }
    }

    public class Defaults
    {
        public string departureDate { get; set; }
        public bool oneWay { get; set; }
        public string duration { get; set; }
        public bool nonStop { get; set; }
        public string viewBy { get; set; }
    }
}