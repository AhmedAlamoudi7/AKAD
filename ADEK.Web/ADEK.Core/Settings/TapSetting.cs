namespace ADEK.Core.Settings
{
    public class TapSetting
    {
        public class Customer
        {

            public string firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public phones phone { get; set; }
            public Source source { get; set; }
            public Redirect redirect { get; set; }
            public Merchant merchant { get; set; }

            public class phones
            {
                public string country_code { get; set; }
                public string number { get; set; }
            }
            public class Merchant
            {
                public string id { get; set; }
            }
            public class Source
            {
                public string id { get; set; }
            }
            public class Redirect
            {
                public string url { get; set; }
            }
        }
    }
}
