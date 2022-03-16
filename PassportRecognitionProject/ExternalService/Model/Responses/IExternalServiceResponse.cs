using Shared.Models;

namespace ExternalService.Model.Responses
{
    public interface IExternalServiceResponse
    {
        public ExternalObjectModel ConverToCommonType();
    }
}
