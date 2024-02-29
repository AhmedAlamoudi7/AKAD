using ADEK.Core.Dtos;

namespace ADEK.Core.Helpers
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Activity
    {
        public string id { get; set; }
        public string @object { get; set; }
        public long created { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public double amount { get; set; }
        public string remarks { get; set; }
    }

    public class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public Phone phone { get; set; }
    }

    public class Expiry
    {
        public int period { get; set; }
        public string type { get; set; }
    }

    public class Merchant
    {
        public string country { get; set; }
        public string currency { get; set; }
        public string id { get; set; }
    }

    public class Metadata
    {
        public string udf1 { get; set; }
        public string udf2 { get; set; }
    }

    public class Phone
    {
        public string country_code { get; set; }
        public string number { get; set; }
    }

    public class Post
    {
        public string status { get; set; }
        public string url { get; set; }
    }

    public class Receipt
    {
        public bool email { get; set; }
        public bool sms { get; set; }
    }

    public class Redirect
    {
        public string status { get; set; }
        public string url { get; set; }
    }

    public class Reference
    {
        public string transaction { get; set; }
        public string order { get; set; }
    }

    public class Response
    {
        public string code { get; set; }
        public string message { get; set; }
    }



    public class Root
    {
        public string id { get; set; }
        public string @object { get; set; }
        public bool live_mode { get; set; }
        public string api_version { get; set; }
        public string method { get; set; }
        public string status { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public bool threeDSecure { get; set; }
        public bool card_threeDSecure { get; set; }
        public bool save_card { get; set; }
        public string merchant_id { get; set; }
        public string product { get; set; }
        public string statement_descriptor { get; set; }
        public string description { get; set; }
        public Metadata metadata { get; set; }
        public Transaction transaction { get; set; }
        public Reference reference { get; set; }
        public Response response { get; set; }
        public Receipt receipt { get; set; }
        public Customer customer { get; set; }
        public Merchant merchant { get; set; }
        public Source source { get; set; }
        public Redirect redirect { get; set; }
        public Post post { get; set; }
        public List<Activity> activities { get; set; }
        public bool auto_reversed { get; set; }
 
    }

    public class Source
    {
        public string @object { get; set; }
        public string id { get; set; }
    }

    public class Transaction
    {
        public string timezone { get; set; }
        public string created { get; set; }
        public string url { get; set; }
        public Expiry expiry { get; set; }
        public bool asynchronous { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
    }



}
