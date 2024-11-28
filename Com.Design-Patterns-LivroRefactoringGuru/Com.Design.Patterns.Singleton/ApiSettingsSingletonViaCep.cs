namespace Com.Design.Patterns.Singleton
{
    public class ApiSettingsSingletonViaCep
    {
        private static ApiSettingsSingletonViaCep _instance;
        private static readonly object _lock = new object();
        public string ViaCepBaseUrl { get; private set; }

        public ApiSettingsSingletonViaCep(IConfiguration configuration)
        {
            // Carrega a URL do appsettings
            ViaCepBaseUrl = configuration["ApiSettings:ViaCepBaseUrl"];
        }

        public static ApiSettingsSingletonViaCep GetInstance(IConfiguration configuration)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ApiSettingsSingletonViaCep(configuration);
                    }
                }
            }
            return _instance;
        }
    }
}
