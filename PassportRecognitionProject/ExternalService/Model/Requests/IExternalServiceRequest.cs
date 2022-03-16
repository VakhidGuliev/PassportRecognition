using Shared.Enums;
using System;

namespace ExternalService.Model.Requests
{
    /// <summary>
    /// Интерфейс реквестов
    /// </summary>
    public interface IExternalServiceRequest
    {
        // Не думаю, что данный функционал нужен на текущем этапе реализации
        /// <summary>
        /// Метод валидации запроса, проверяющий наличие всех ключевых полей
        /// </summary>
        // public bool IsRequestCorrect();

        /// <summary>
        /// Метод возвращаемый тип запроса(в дальнейшем может помочь при нескольких внешних сервисах)
        /// </summary>
        public ExternalTypeEnum GetType();
    }
}
