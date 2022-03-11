using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PassportRecognitionProject.src.Models;

// Временное решение
using DocumentInfoModel = System.Object;
using ImageObject = System.Object;
using DocumentShortInfo = System.Object;

namespace PassportRecognitionProject.src.Services
{
    /// <summary>
    /// Интерфейс взаимодействия с бизнес-логикой
    /// </summary>
    public interface IDocumentService
    {
        /// <summary>
        /// Расшифровка документа
        /// </summary>
        /// <param name="image"> Исходное изображение </param>
        /// <returns> Информацию об отправляемом документе </returns>
        // object - DocumentInfoModel
        public DocumentInfoModel RecognitionDocument(ImageObject image);

        /// <summary>
        /// Отправить полученный ответ от внешнего сервиса в базу данных
        /// </summary>
        /// <param name="externalModel"> Инофрмация полученная от внешнего сервиса </param>
        /// <returns> Расшифрованную и универсальную модель документа </returns>
        public DocumentInfoModel AddToDataBase(ExternalObjectModel externalModel);

        /// <summary>
        /// Получение информации об сохранённом документе
        /// </summary>
        /// <param name="documentId"> уникальный идентификатор документа </param>
        /// <param name="page"> номера запрашиваемых страниц </param>
        /// <returns> Информация по запрашиваемому документу </returns>
        public DocumentInfoModel GetDocumentInfo(Guid documentId, int[] page);

        /// <summary>
        /// Получить список отсканированных документов
        /// </summary>
        /// <returns> Список краткой инормации об готовых документах для последующего выбора </returns>
        public List<DocumentShortInfo> GetScannedDocument();

        /// <summary>
        /// Получить от внешнего сервиса распознанную информация с изображения документа
        /// </summary>
        /// <param name="image"> исходное изображение </param>
        /// <returns> Информация пришедшая с внешнего сервиса </returns>
        public ExternalObjectModel GetRecognitionDocFromExternalService(ImageObject image);
    }
}
