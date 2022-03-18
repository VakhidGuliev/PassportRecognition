using Shared.Enums;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExternalService.Model.Responses
{

    // Generate by https://json2csharp.com/

    public class FieldRect
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class ListOfCandidate
    {
        public long Class { get; set; }
        public long SubClass { get; set; }
        public long SymbolCode { get; set; }
        public long SymbolProbability { get; set; }
    }

    public class SymbolRect
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class StringResult
    {
        public long BaseLineBottom { get; set; }
        public long BaseLineTop { get; set; }
        public long CandidatesCount { get; set; }
        public List<ListOfCandidate> ListOfCandidates { get; set; }
        public long Reserved { get; set; }
        public SymbolRect SymbolRect { get; set; }
    }

    public class StringsResult
    {
        public long Reserved { get; set; }
        public List<StringResult> StringResult { get; set; }
        public long SymbolsCount { get; set; }
    }

    public class PArrayField
    {
        public long Buf_Length { get; set; }
        public string Buf_Text { get; set; }
        public string FieldMask { get; set; }
        public string FieldName { get; set; }
        public FieldRect FieldRect { get; set; }
        public long FieldType { get; set; }
        public long InComparison { get; set; }
        public long Reserved2 { get; set; }
        public long Reserved3 { get; set; }
        public long StringsCount { get; set; }
        public List<StringsResult> StringsResult { get; set; }
        public long Validity { get; set; }
        public long wFieldType { get; set; }
        public long wLCID { get; set; }
        public Image image { get; set; }
    }

    public static class PArrayFieldExtention
    {
        public static string GetValue(this PArrayField field, string StrIfNull)
        {
            return field?.Buf_Text ?? StrIfNull;
        }
    }

    public class DocVisualExtendedInfo
    {
        public long nFields { get; set; }
        public List<PArrayField> pArrayFields { get; set; }
    }

    public class Symbol
    {
        public List<long> boundingRect { get; set; }
    }

    public class MRZRow
    {
        public long length { get; set; }
        public long maxLength { get; set; }
        public List<Symbol> symbols { get; set; }
    }

    public class ResultMRZDetector
    {
        public long MRZFormat { get; set; }
        public List<MRZRow> MRZRows { get; set; }
        public long MRZRowsNum { get; set; }
        public List<double> boundingQuadrangle { get; set; }
    }

    public class Center
    {
        public long x { get; set; }
        public long y { get; set; }
    }

    public class LeftBottom
    {
        public long x { get; set; }
        public long y { get; set; }
    }

    public class LeftTop
    {
        public long x { get; set; }
        public long y { get; set; }
    }

    public class RightBottom
    {
        public long x { get; set; }
        public long y { get; set; }
    }

    public class RightTop
    {
        public long x { get; set; }
        public long y { get; set; }
    }

    public class MrzPosition
    {
        public double Angle { get; set; }
        public Center Center { get; set; }
        public long Dpi { get; set; }
        public long Height { get; set; }
        public long Inverse { get; set; }
        public LeftBottom LeftBottom { get; set; }
        public LeftTop LeftTop { get; set; }
        public long ObjArea { get; set; }
        public long ObjlongAngleDev { get; set; }
        public long PerspectiveTr { get; set; }
        public long ResultStatus { get; set; }
        public RightBottom RightBottom { get; set; }
        public RightTop RightTop { get; set; }
        public long Width { get; set; }
        public long docFormat { get; set; }
    }

    public class MRZTestQuality
    {
        public long CHECK_SUMS { get; set; }
        public long CONTRAST_PRlong { get; set; }
        public long DOC_FORMAT { get; set; }
        public long MRZ_FORMAT { get; set; }
        public long PRlong_POSITION { get; set; }
        public long STAIN_MRZ { get; set; }
        public long SYMBOLS_PARAM { get; set; }
        public long StrCount { get; set; }
        public List<object> Strings { get; set; }
        public long TEXTUAL_FILLING { get; set; }
    }

    public class RectPhoto
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class PRects
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class Re
    {
        public long CoincidenceToPhotoArea { get; set; }
        public long LightType { get; set; }
        public long Orientation { get; set; }
        public long Probability { get; set; }
        public RectPhoto Rect_Photo { get; set; }
        public long Reserved { get; set; }
        public PRects pRects { get; set; }
    }

    public class FaceDetection
    {
        public long Count { get; set; }
        public long CountFalseDetection { get; set; }
        public List<Re> Res { get; set; }
        public long Reserved1 { get; set; }
        public long Reserved2 { get; set; }
    }

    public class DocumentPosition
    {
        public double Angle { get; set; }
        public Center Center { get; set; }
        public long Dpi { get; set; }
        public long Height { get; set; }
        public long Inverse { get; set; }
        public LeftBottom LeftBottom { get; set; }
        public LeftTop LeftTop { get; set; }
        public long ObjArea { get; set; }
        public long ObjlongAngleDev { get; set; }
        public long PerspectiveTr { get; set; }
        public long ResultStatus { get; set; }
        public RightBottom RightBottom { get; set; }
        public RightTop RightTop { get; set; }
        public long Width { get; set; }
        public long docFormat { get; set; }
    }

    public class FDSIDList
    {
        public long Count { get; set; }
        public string ICAOCode { get; set; }
        public List<long> List { get; set; }
        public string dCountryName { get; set; }
        public long dFormat { get; set; }
        public bool dMRZ { get; set; }
        public long dType { get; set; }
        public string dYear { get; set; }
    }

    /// <summary>
    /// Соответсвует разделу Document type
    /// </summary>
    public class OneCandidate
    {
        public long AuthenticityNecessaryLights { get; set; }
        public long CheckAuthenticity { get; set; }
        public string DocumentName { get; set; }
        public FDSIDList FDSIDList { get; set; }
        public long ID { get; set; }
        public long NecessaryLights { get; set; }
        public long OVIExp { get; set; }
        public double P { get; set; }
        public long RFID_Presence { get; set; }
        public long Rotated180 { get; set; }
        public long RotationAngle { get; set; }
        public long UVExp { get; set; }
    }

    public class Image
    {
        public string format { get; set; }
        public string image { get; set; }
    }

    public class DocGraphicsInfo
    {
        public long nFields { get; set; }
        public List<PArrayField> pArrayFields { get; set; }
    }

    public class ListMain
    {
        public DocVisualExtendedInfo DocVisualExtendedInfo { get; set; }
        public long buf_length { get; set; }
        public long light { get; set; }
        public long list_idx { get; set; }
        public long page_idx { get; set; }
        public long result_type { get; set; }
        public ResultMRZDetector ResultMRZDetector { get; set; }
        public MrzPosition MrzPosition { get; set; }
        public MRZTestQuality MRZTestQuality { get; set; }
        public FaceDetection FaceDetection { get; set; }
        public DocumentPosition DocumentPosition { get; set; }
        /// <summary>
        /// Соответсвует части раздела Document type
        /// </summary>
        public OneCandidate OneCandidate { get; set; }
        public DocGraphicsInfo DocGraphicsInfo { get; set; }
        public ImageQualityCheckList ImageQualityCheckList { get; set; }
        public ListVerifiedFields ListVerifiedFields { get; set; }
        public Text Text { get; set; }
        public Images Images { get; set; }
        public Status Status { get; set; }
    }

    public class SecondaryList
    {
        public long featureType { get; set; }
        public double mean { get; set; }
        public long probability { get; set; }
        public long result { get; set; }
        public double std_dev { get; set; }
        public long type { get; set; }
    }

    public class ImageQualityCheckList
    {
        public long Count { get; set; }
        public List<SecondaryList> List { get; set; }
        public long result { get; set; }
    }

    public class PFieldMap
    {
        public long FieldType { get; set; }
        public string Field_MRZ { get; set; }
        public string Field_Visual { get; set; }
        public List<long> Matrix { get; set; }
        public long wFieldType { get; set; }
        public long wLCID { get; set; }
    }

    public class ListVerifiedFields
    {
        public long Count { get; set; }
        public string pDateFormat { get; set; }
        public List<PFieldMap> pFieldMaps { get; set; }
    }

    public class AvailableSourceList
    {
        public long containerType { get; set; }
        public string source { get; set; }
        public long validityStatus { get; set; }
    }

    public class ComparisonList
    {
        public string sourceLeft { get; set; }
        public string sourceRight { get; set; }
        public long status { get; set; }
    }

    public class ValidityList
    {
        public string source { get; set; }
        public long status { get; set; }
    }

    public class Rect
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class OriginalSymbol
    {
        public long code { get; set; }
        public long probability { get; set; }
        public Rect rect { get; set; }
    }

    public class FieldRect3
    {
        public long bottom { get; set; }
        public long left { get; set; }
        public long right { get; set; }
        public long top { get; set; }
    }

    public class ValueList
    {
        public long containerType { get; set; }
        public List<OriginalSymbol> originalSymbols { get; set; }
        public long originalValidity { get; set; }
        public long pageIndex { get; set; }
        public long probability { get; set; }
        public string source { get; set; }
        public string value { get; set; }
        public FieldRect fieldRect { get; set; }
        public string originalValue { get; set; }
        public long lightIndex { get; set; }
        public long originalPageIndex { get; set; }
    }


    /// <summary>
    /// Вероятно, является разделом Document Images
    /// </summary>
    public class FieldList
    {
        public List<ComparisonList> comparisonList { get; set; }
        public long comparisonStatus { get; set; }
        public string fieldName { get; set; }
        public long fieldType { get; set; }
        public long lcid { get; set; }
        public string lcidName { get; set; }
        public long status { get; set; }
        public List<ValidityList> validityList { get; set; }
        public long validityStatus { get; set; }
        public string value { get; set; }
        public List<ValueList> valueList { get; set; }
    }

    /// <summary>
    /// Соответствует разделу Text Fields
    /// </summary>
    public class Text
    {
        public List<AvailableSourceList> availableSourceList { get; set; }
        public long comparisonStatus { get; set; }
        public string dateFormat { get; set; }
        public List<FieldList> fieldList { get; set; }
        public long status { get; set; }
        public long validityStatus { get; set; }
    }

    /// <summary>
    /// Соответствует разделу Graphic Fields
    /// </summary>
    public class Images
    {
        public List<AvailableSourceList> availableSourceList { get; set; }
        public List<FieldList> fieldList { get; set; }
    }

    public class DetailsOptical
    {
        public long docType { get; set; }
        public long expiry { get; set; }
        public long imageQA { get; set; }
        public long mrz { get; set; }
        public long overallStatus { get; set; }
        public long pagesCount { get; set; }
        public long security { get; set; }
        public long text { get; set; }
        public long vds { get; set; }
    }

    public class DetailsRFID
    {
        public long AA { get; set; }
        public long BAC { get; set; }
        public long CA { get; set; }
        public long PA { get; set; }
        public long PACE { get; set; }
        public long TA { get; set; }
        public long overallStatus { get; set; }
    }

    /// <summary>
    /// Соответвует разделу Status
    /// </summary>
    public class Status
    {
        public DetailsOptical detailsOptical { get; set; }
        public DetailsRFID detailsRFID { get; set; }
        public long optical { get; set; }
        public long overallStatus { get; set; }
        public long portrait { get; set; }
        public long rfid { get; set; }
        public long stopList { get; set; }
    }

    public class ContainerList
    {
        public long Count { get; set; }
        public List<ListMain> List { get; set; }
    }

    public class TransactionInfo
    {
        public string ComputerName { get; set; }
        public DateTime DateTime { get; set; }
        public string SystemInfo { get; set; }
        public string TransactionID { get; set; }
        public string UserName { get; set; }
        public string Version { get; set; }
    }

    public class RegulaResponse : IExternalServiceResponse
    {
        private const string CantRecive = "can't read data";

        public long ChipPage { get; set; }
        public ContainerList ContainerList { get; set; }
        public long CoreLibResultCode { get; set; }
        public long ProcessingFinished { get; set; }
        public TransactionInfo TransactionInfo { get; set; }
        public long elapsedTime { get; set; }
        public long morePagesAvailable { get; set; }
        public object passBackObject { get; set; }
        public bool serviceMemorySizeMaxExceeded { get; set; }

        public ExternalObjectModel ConverToCommonType()
        {
            ExternalObjectModel result;

            var mainDocVisualPart = ContainerList.List.FirstOrDefault(it => it.DocVisualExtendedInfo != null && it.result_type == 3);
            var secondaryDocVisualPart = ContainerList.List.FirstOrDefault(it => it.DocVisualExtendedInfo != null && it.result_type == 17);

            var DocNumberField = mainDocVisualPart?.DocVisualExtendedInfo.pArrayFields.FirstOrDefault(it => it.FieldType == 2 && it.FieldName == "Document Number");
            if (DocNumberField == null)
            {
                DocNumberField = secondaryDocVisualPart?.DocVisualExtendedInfo.pArrayFields
                    .FirstOrDefault(it => it.FieldType == 2 && it.FieldName == "Document Number");
            }

            if (DocNumberField != null)
            {
                string DocumentNumber = DocNumberField.Buf_Text;
                result = new ExternalObjectModel(DocumentNumber);

                if (mainDocVisualPart != null)
                {
                    var fields = mainDocVisualPart.DocVisualExtendedInfo.pArrayFields;
                    FillByFirstDocVisualExtendedInfo(fields, ref result);
                }

                if (secondaryDocVisualPart != null)
                {
                    var fields = secondaryDocVisualPart.DocVisualExtendedInfo.pArrayFields;
                    FillBySecondDocVisualExtendedInfo(fields, ref result);
                }

                FillDocumentType(ref result);
                FillAge(ref result);
            }
            else
            {
                throw new ArgumentNullException("Не удалось распознать номер документа");
            }
          
            return result;           
        }

        private void FillByFirstDocVisualExtendedInfo(List<PArrayField> fields, ref ExternalObjectModel externalObjectModel)
        {
            externalObjectModel.FirstSecondName = fields.FirstOrDefault(it => it.FieldType == 25 && it.FieldName == "Surname & Given Names")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.IssuingStateCode = fields.FirstOrDefault(it => it.FieldType == 1 && it.FieldName == "Issuing State Code")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.Sex = fields.FirstOrDefault(it => it.FieldType == 12 && it.FieldName == "Sex")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.MRZLine = fields.FirstOrDefault(it => it.FieldType == 51 && it.FieldName == "MRZ Strings")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.DocumentClassCode = fields.FirstOrDefault(it => it.FieldType == 0 && it.FieldName == "Document Class Code")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.NationalityCode = fields.FirstOrDefault(it => it.FieldType == 26 && it.FieldName == "Nationality Code")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.OptionalData = fields.FirstOrDefault(it => it.FieldType == 36 && it.FieldName == "Optional Data")
                .GetValue(StrIfNull: CantRecive);
        }

        private void FillBySecondDocVisualExtendedInfo(List<PArrayField> fields, ref ExternalObjectModel externalObjectModel)
        {
            externalObjectModel.PlaceOfBirth = fields.FirstOrDefault(it => it.FieldType == 6 && it.FieldName == "Place of Birth")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.ContryName = fields.FirstOrDefault(it => it.FieldType == 24 && it.FieldName == "Authority")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.Nationality = fields.FirstOrDefault(it => it.FieldType == 11 && it.FieldName == "Nationality")
                .GetValue(StrIfNull: CantRecive);

            externalObjectModel.DateOfBirth = fields.FirstOrDefault(it => it.FieldType == 5 && it.FieldName == "Date of Birth")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.DateOfExpiration = fields.FirstOrDefault(it => it.FieldType == 3 && it.FieldName == "Date of Expiry")
                .GetValue(StrIfNull: CantRecive);
            externalObjectModel.DateOfIssue = fields.FirstOrDefault(it => it.FieldType == 4 && it.FieldName == "Date of Issue")
                .GetValue(StrIfNull: CantRecive);

            if (externalObjectModel.Sex == CantRecive || string.IsNullOrEmpty(externalObjectModel.Sex))
            {
                externalObjectModel.Sex = fields.FirstOrDefault(it => it.FieldType == 12 && it.FieldName == "Sex")
                    .GetValue(StrIfNull: CantRecive);
            }

            if (externalObjectModel.IssuingStateCode == CantRecive || string.IsNullOrEmpty(externalObjectModel.IssuingStateCode))
            {
                externalObjectModel.IssuingStateCode = fields.FirstOrDefault(it => it.FieldType == 1 && it.FieldName == "Issuing State Code")
                    .GetValue(StrIfNull: CantRecive);
            }

        }

        private void FillDocumentType(ref ExternalObjectModel externalObjectModel)
        {
            var onCandidateInfo = ContainerList.List.FirstOrDefault(it => it.OneCandidate != null)?.OneCandidate;
            if (onCandidateInfo != null)
            {
                externalObjectModel.DocumentType = onCandidateInfo.DocumentName;
                externalObjectModel.DocumentCategory = (onCandidateInfo.RFID_Presence < 3)
                    ? (DocumentCategoryEnum)onCandidateInfo.RFID_Presence
                    : DocumentCategoryEnum.Unknown;
            }
            else
            {
                externalObjectModel.DocumentType = CantRecive;
            }
        }

        private void FillAge(ref ExternalObjectModel externalObjectModel)
        {
            var textfields = ContainerList.List.FirstOrDefault(it => it.Text != null)?.Text;
            externalObjectModel.Age = textfields?.fieldList.FirstOrDefault(it => it.fieldType == 185 && it.fieldName == "Age")?.value ?? CantRecive;
        }
       
    }


}
