using Shared.Models;
using System.Threading.Tasks;
using ImageObject = System.Object;

namespace ExternalService.src
{
    /// <summary>
    /// Интерфейс взаимодействия с внешним сервисом
    /// </summary>
    public interface IExternalRecognitionService
    {
        /// <summary>
        /// Получение информации о документе с внешнего сервиса
        /// </summary>
        /// <param name="image"> Изображение </param>
        /// <returns> Полученные от внешнего сервиса данные </returns>
        public Task<ExternalObjectModel> GetRecognition(ImageObject image);
    }
}
