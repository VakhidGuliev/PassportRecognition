using PassportRecognitionProject.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DocumentInfoModel = System.Object;
using DocumentShortInfo = System.Object;

namespace PassportRecognitionProject.src.Database
{
    /// <summary>
    /// Интерфейс взаимодействия с базой данных
    /// </summary>
    public interface IDatabaseService
    {
        /// <summary>
        /// Проверка наличия записи в базе, запись в случае отсутствия
        /// </summary>
        /// <param name="externalModel"> Данные полученные от внешнего сервиса </param>
        /// <returns> Преобразованная информация о документе </returns>
        public DocumentInfoModel CheckWriteAndReturnDocumentInfo(ExternalObjectModel externalModel);

        /// <summary>
        /// Получение списка уже сохранённых документов
        /// </summary>
        public List<DocumentShortInfo> GetScannedDocuments();

        /// <summary>
        /// Получение информации по конкретному документу
        /// </summary>
        /// <param name="documentId"> Уникальный идентификатор документа </param>
        /// <param name="pages"> Конкретные страницы запроса </param>
        public DocumentInfoModel GetDocumentInfo(Guid documentId, int[] pages);
    }
}
