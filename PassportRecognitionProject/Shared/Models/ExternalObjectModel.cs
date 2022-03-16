using Shared.Enums;
using System;

namespace Shared.Models
{
    /// <summary>
    /// Модель получаемая от внешнего сервиса
    /// </summary>
    public class ExternalObjectModel
    {
        public ExternalObjectModel(string docNumber)
        {
            DocNumber = docNumber;
        }
        /// <summary>
        /// Категория документа (Паспорт, водительское удостоверение)
        /// </summary>
        public DocumentCategoryEnum DocumentCategory { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public string DocumentType { get; set; }

        /// <summary>
        /// Имя-Фамилия
        /// </summary>
        public string FirstSecondName { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public string Age { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocNumber { get; private set; }

        /// <summary>
        /// Код выдачи косударства
        /// </summary>
        public string IssuingStateCode { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Дата действия
        /// </summary>
        public DateTime DateOfExpiration { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Текст с униварсальной MRZ линии
        /// </summary>
        public string MRZLine { get; set; }

        /// <summary>
        /// Класс документа
        /// </summary>
        public string DocumentClassCode { get; set; }

        /// <summary>
        /// Национальный код
        /// </summary>
        public string NationalityCode { get; set; }

        /// <summary>
        /// Название страны
        /// </summary>
        public string ContryName { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Национальность
        /// </summary>
        public string Nationality { get; set; }

        public string OptionalData { get; set; }
    }
}
