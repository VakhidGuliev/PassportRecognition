using PassportRecognitionProject.src.Database;
using PassportRecognitionProject.src.Models;
using System;
using System.Collections.Generic;

using ImageObject = System.Object;
using DocumentInfoModel = System.Object;
using DocumentShortInfo = System.Object;


namespace PassportRecognitionProject.src.Services
{
    public class DocumentService : IDocumentService
    {
        private IExternalRecognitionService _externalService;
        private IDatabaseService _databaseService;

        public DocumentService(IDatabaseService databaseService, IExternalRecognitionService externalService)
        {
            _externalService = externalService;
            _databaseService = databaseService;
        }

        public DocumentInfoModel RecognitionDocument(ImageObject image)
        {
            var externalInfo = GetRecognitionDocFromExternalService(image);
            return AddToDataBase(externalInfo);
        }

        public DocumentInfoModel GetDocumentInfo(Guid documentId, int[] pages)
        {
            return _databaseService.GetDocumentInfo(documentId, pages);
        }

        public List<DocumentShortInfo> GetScannedDocument()
        {
            return _databaseService.GetScannedDocuments();
        }

        /// <summary>
        /// Получить от внешнего сервиса распознанную информация с изображения документа
        /// </summary>
        /// <param name="image"> исходное изображение </param>
        /// <returns> Информация пришедшая с внешнего сервиса </returns>
        private ExternalObjectModel GetRecognitionDocFromExternalService(ImageObject image)
        {
            return _externalService.GetRecognition(image);
        }

        /// <summary>
        /// Отправить полученный ответ от внешнего сервиса в базу данных
        /// </summary>
        /// <param name="externalModel"> Инофрмация полученная от внешнего сервиса </param>
        /// <returns> Расшифрованную и универсальную модель документа </returns>
        private DocumentInfoModel AddToDataBase(ExternalObjectModel externalModel)
        {
            return _databaseService.CheckWriteAndReturnDocumentInfo(externalModel);
        }
    }
}
