using System;
using System.Collections.Generic;

// Временное решение
using DocumentInfoModel = System.Object;
using DocumentShortInfo = System.Object;
using System.Threading.Tasks;

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
        public Task<DocumentInfoModel> RecognitionDocument(byte[] image);

        /// <summary>
        /// Получение информации об сохранённом документе
        /// </summary>
        /// <param name="documentId"> уникальный идентификатор документа </param>
        /// <param name="pages"> номера запрашиваемых страниц </param>
        /// <returns> Информация по запрашиваемому документу </returns>
        public DocumentInfoModel GetDocumentInfo(Guid documentId, int[] pages);

        /// <summary>
        /// Получить список отсканированных документов
        /// </summary>
        /// <returns> Список краткой инормации об готовых документах для последующего выбора </returns>
        public List<DocumentShortInfo> GetScannedDocument();
    }
}
