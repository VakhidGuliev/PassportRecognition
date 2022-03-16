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
        public string DocumentCategory { get; set; }

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
        public int Age { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public char Sex { get; set; }

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
    }
}
