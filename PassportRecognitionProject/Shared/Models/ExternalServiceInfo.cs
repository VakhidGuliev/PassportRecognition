using Shared.Enums;

namespace Shared.Models
{
    /// <summary>
    /// Данные для подключения к внешнему сервису
    /// </summary>
    public class ExternalServiceInfo
    {
        public string URL { get; set; }

        public ExternalTypeEnum ServiceType { get; set; }
    }
}
