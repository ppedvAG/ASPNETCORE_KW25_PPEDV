namespace MovieStoreApp.Configurations
{
    public class MovieStoreSettings
    {
        public OmdbapiSettings OmdbapiSettings { get; set; }
    }

    public class OmdbapiSettings
    {
        public string SampleURL { get; set; }
        public string ActivateKey { get; set; }

        public OmdbapiParameter OmdbapiParameter { get; set; }

    }

    public class OmdbapiParameter
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Plot { get; set; }
        public string Key { get; set; }
    }
}
