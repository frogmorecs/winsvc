// ReSharper disable InconsistentNaming
namespace winsvc.Enumerations
{
    internal enum SERVICE_CONFIG
    {
        SERVICE_CONFIG_DESCRIPTION              = 1,
        SERVICE_CONFIG_FAILURE_ACTIONS          = 2,
        SERVICE_CONFIG_DELAYED_AUTO_START_INFO  = 3,
        SERVICE_CONFIG_FAILURE_ACTIONS_FLAG     = 4,
        SERVICE_CONFIG_SERVICE_SID_INFO         = 5,
        SERVICE_CONFIG_REQUIRED_PRIVILEGES_INFO = 6,
        SERVICE_CONFIG_PRESHUTDOWN_INFO         = 7,
        SERVICE_CONFIG_TRIGGER_INFO             = 8,
        SERVICE_CONFIG_PREFERRED_NODE           = 9,
        // reserved                             =         10
        // reserved                             =         11
        SERVICE_CONFIG_LAUNCH_PROTECTED         = 12,    
    }
}