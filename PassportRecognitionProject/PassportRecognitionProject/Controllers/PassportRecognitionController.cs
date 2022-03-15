using Microsoft.AspNetCore.Mvc;
using PassportRecognitionProject.src.Services;
using System;
using System.Threading.Tasks;
using ImageObject = System.Object;

namespace PassportRecognitionProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassportRecognitionController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public PassportRecognitionController(IDocumentService docService)
        {
            _documentService = docService;
        }

        /// <summary>
        /// Получить расшифровку документа
        /// </summary>
        /// <param name="docScan"> Исходное изображение документа </param>
        [HttpPost]
        public async Task<IActionResult> RecognitionNewDocument([FromBody] ImageObject docScan)
        {
            return Ok(await _documentService.RecognitionDocument(docScan));
        }

        /// <summary>
        /// Получить информацию по конкретному документу
        /// </summary>
        /// <param name="documentId"> Уникальный идентификатор документа </param>
        /// <param name="pages"> Номера необходимых страниц(по умолчанию все)</param>
        /// <returns></returns>
        [HttpGet]
        [Route("info")]
        public IActionResult GetDocumentInfo([FromQuery]Guid documentId, [FromQuery] int[] pages = null)
        {
            return Ok(_documentService.GetDocumentInfo(documentId, pages));
        }

        /// <summary>
        /// Получить список всех расшифрованных документов
        /// </summary>
        [HttpGet]
        [Route("scanned")]
        public IActionResult GetScannedDocuments()
        {
            return Ok(_documentService.GetScannedDocument());
        }
    }
}
