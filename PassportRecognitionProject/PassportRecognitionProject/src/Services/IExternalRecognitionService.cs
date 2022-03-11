using PassportRecognitionProject.src.Models;

using ImageObject = System.Object;

namespace PassportRecognitionProject.src.Services
{
    /// <summary>
    /// Интерфейс взаимодействия с внешним сервисом
    /// </summary>
    interface IExternalRecognitionService
    {
        /// <summary>
        /// Получение информации о документе с внешнего сервиса
        /// </summary>
        /// <param name="image"> Изображение </param>
        /// <returns> Полученные от внешнего сервиса данные </returns>
        public ExternalObjectModel GetRecognition(ImageObject image);

        /// <summary>
        /// Получение данных для подключения к  внешнему сервису
        /// </summary>
        /// <returns> Данные для подключения к внешнему сервису </returns>
        protected ExternalServiceInfo GetExternalServiceInfo();
    }
}
