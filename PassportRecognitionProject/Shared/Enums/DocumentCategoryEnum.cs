using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public enum DocumentCategoryEnum
    {
        /// <summary>
        /// Водительское удостоверение
        /// </summary>
        DrivingLicense = 0,
        /// <summary>
        /// Паспорт/Идентификационная карточка
        /// </summary>
        Passport = 1,
        /// <summary>
        /// Международный паспорт
        /// </summary>
        TravelDocument = 2,
        /// <summary>
        /// Неизвестный
        /// </summary>
        Unknown = 10
    }
}
