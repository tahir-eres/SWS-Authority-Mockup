using SWS.Mockups.Permit.Api.ConfigurationManager;

namespace SWS.Mockups.Permit.Api.BusinessCore.Base
{
    public abstract class ProcessorBase
    {
        public ProcessorBase(ConfigurationSettings configurations) {
            ConfigSettings = configurations;
        }
        public ConfigurationSettings ConfigSettings { get; set; }
    }
}
