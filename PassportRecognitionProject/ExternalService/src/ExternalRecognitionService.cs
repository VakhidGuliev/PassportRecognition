using Shared.Models;
using System;

namespace ExternalService.src
{
    public class ExternalRecognitionService : IExternalRecognitionService
    {
        public ExternalObjectModel GetRecognition(object image)
        {
            throw new NotImplementedException();
        }

                /// <summary>
        /// Получение данных для подключения к  внешнему сервису
        /// </summary>
        /// <returns> Данные для подключения к внешнему сервису </returns>
        public ExternalServiceInfo GetExternalServiceInfo()
        {
            throw new NotImplementedException();
        }
    }
}
