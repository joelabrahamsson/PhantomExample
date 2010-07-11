using System.Configuration;

namespace ConfigurableModule
{
    public class Configuration : ConfigurationSection  
    {
        public static Configuration GetConfiguration()
        {
            Configuration configuration = 
                ConfigurationManager
                .GetSection("myConfigurableModule")
                as Configuration;

            if (configuration != null)
                return configuration;

            return new Configuration();
        }

        [ConfigurationProperty("message", IsRequired = false)]
        public string Message
        {
            get
            {
                return this["message"] as string;
            }
        }
    }
}
