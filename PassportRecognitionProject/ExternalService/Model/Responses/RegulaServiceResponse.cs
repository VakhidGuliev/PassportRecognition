using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExternalService.Model.Responses
{

    // Generate by https://json2csharp.com/

    public class FieldRect
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class ListOfCandidate
    {
        public int Class { get; set; }
        public int SubClass { get; set; }
        public int SymbolCode { get; set; }
        public int SymbolProbability { get; set; }
    }

    public class SymbolRect
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class StringResult
    {
        public int BaseLineBottom { get; set; }
        public int BaseLineTop { get; set; }
        public int CandidatesCount { get; set; }
        public List<ListOfCandidate> ListOfCandidates { get; set; }
        public int Reserved { get; set; }
        public SymbolRect SymbolRect { get; set; }
    }

    public class StringsResult
    {
        public int Reserved { get; set; }
        public List<StringResult> StringResult { get; set; }
        public int SymbolsCount { get; set; }
    }

    public class PArrayField
    {
        public int Buf_Length { get; set; }
        public string Buf_Text { get; set; }
        public string FieldMask { get; set; }
        public string FieldName { get; set; }
        public FieldRect FieldRect { get; set; }
        public int FieldType { get; set; }
        public int InComparison { get; set; }
        public int Reserved2 { get; set; }
        public int Reserved3 { get; set; }
        public int StringsCount { get; set; }
        public List<StringsResult> StringsResult { get; set; }
        public int Validity { get; set; }
        public int wFieldType { get; set; }
        public int wLCID { get; set; }
        public Image image { get; set; }
    }

    public class DocVisualExtendedInfo
    {
        public int nFields { get; set; }
        public List<PArrayField> pArrayFields { get; set; }
    }

    public class Symbol
    {
        public List<int> boundingRect { get; set; }
    }

    public class MRZRow
    {
        public int length { get; set; }
        public int maxLength { get; set; }
        public List<Symbol> symbols { get; set; }
    }

    public class ResultMRZDetector
    {
        public int MRZFormat { get; set; }
        public List<MRZRow> MRZRows { get; set; }
        public int MRZRowsNum { get; set; }
        public List<double> boundingQuadrangle { get; set; }
    }

    public class Center
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class LeftBottom
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class LeftTop
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class RightBottom
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class RightTop
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class MrzPosition
    {
        public double Angle { get; set; }
        public Center Center { get; set; }
        public int Dpi { get; set; }
        public int Height { get; set; }
        public int Inverse { get; set; }
        public LeftBottom LeftBottom { get; set; }
        public LeftTop LeftTop { get; set; }
        public int ObjArea { get; set; }
        public int ObjIntAngleDev { get; set; }
        public int PerspectiveTr { get; set; }
        public int ResultStatus { get; set; }
        public RightBottom RightBottom { get; set; }
        public RightTop RightTop { get; set; }
        public int Width { get; set; }
        public int docFormat { get; set; }
    }

    public class MRZTestQuality
    {
        public int CHECK_SUMS { get; set; }
        public int CONTRAST_PRINT { get; set; }
        public int DOC_FORMAT { get; set; }
        public int MRZ_FORMAT { get; set; }
        public int PRINT_POSITION { get; set; }
        public int STAIN_MRZ { get; set; }
        public int SYMBOLS_PARAM { get; set; }
        public int StrCount { get; set; }
        public List<object> Strings { get; set; }
        public int TEXTUAL_FILLING { get; set; }
    }

    public class RectPhoto
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class PRects
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class Re
    {
        public int CoincidenceToPhotoArea { get; set; }
        public int LightType { get; set; }
        public int Orientation { get; set; }
        public int Probability { get; set; }
        public RectPhoto Rect_Photo { get; set; }
        public int Reserved { get; set; }
        public PRects pRects { get; set; }
    }

    public class FaceDetection
    {
        public int Count { get; set; }
        public int CountFalseDetection { get; set; }
        public List<Re> Res { get; set; }
        public int Reserved1 { get; set; }
        public int Reserved2 { get; set; }
    }

    public class DocumentPosition
    {
        public double Angle { get; set; }
        public Center Center { get; set; }
        public int Dpi { get; set; }
        public int Height { get; set; }
        public int Inverse { get; set; }
        public LeftBottom LeftBottom { get; set; }
        public LeftTop LeftTop { get; set; }
        public int ObjArea { get; set; }
        public int ObjIntAngleDev { get; set; }
        public int PerspectiveTr { get; set; }
        public int ResultStatus { get; set; }
        public RightBottom RightBottom { get; set; }
        public RightTop RightTop { get; set; }
        public int Width { get; set; }
        public int docFormat { get; set; }
    }

    public class FDSIDList
    {
        public int Count { get; set; }
        public string ICAOCode { get; set; }
        public List<int> List { get; set; }
        public string dCountryName { get; set; }
        public int dFormat { get; set; }
        public bool dMRZ { get; set; }
        public int dType { get; set; }
        public string dYear { get; set; }
    }

    /// <summary>
    /// Соответсвует разделу Document type
    /// </summary>
    public class OneCandidate
    {
        public int AuthenticityNecessaryLights { get; set; }
        public int CheckAuthenticity { get; set; }
        public string DocumentName { get; set; }
        public FDSIDList FDSIDList { get; set; }
        public int ID { get; set; }
        public int NecessaryLights { get; set; }
        public int OVIExp { get; set; }
        public double P { get; set; }
        public int RFID_Presence { get; set; }
        public int Rotated180 { get; set; }
        public int RotationAngle { get; set; }
        public int UVExp { get; set; }
    }

    public class Image
    {
        public string format { get; set; }
        public string image { get; set; }
    }

    public class DocGraphicsInfo
    {
        public int nFields { get; set; }
        public List<PArrayField> pArrayFields { get; set; }
    }

    public class ListMain
    {
        public DocVisualExtendedInfo DocVisualExtendedInfo { get; set; }
        public int buf_length { get; set; }
        public int light { get; set; }
        public int list_idx { get; set; }
        public int page_idx { get; set; }
        public int result_type { get; set; }
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
        public int featureType { get; set; }
        public double mean { get; set; }
        public int probability { get; set; }
        public int result { get; set; }
        public double std_dev { get; set; }
        public int type { get; set; }
    }

    public class ImageQualityCheckList
    {
        public int Count { get; set; }
        public List<SecondaryList> List { get; set; }
        public int result { get; set; }
    }

    public class PFieldMap
    {
        public int FieldType { get; set; }
        public string Field_MRZ { get; set; }
        public string Field_Visual { get; set; }
        public List<int> Matrix { get; set; }
        public int wFieldType { get; set; }
        public int wLCID { get; set; }
    }

    public class ListVerifiedFields
    {
        public int Count { get; set; }
        public string pDateFormat { get; set; }
        public List<PFieldMap> pFieldMaps { get; set; }
    }

    public class AvailableSourceList
    {
        public int containerType { get; set; }
        public string source { get; set; }
        public int validityStatus { get; set; }
    }

    public class ComparisonList
    {
        public string sourceLeft { get; set; }
        public string sourceRight { get; set; }
        public int status { get; set; }
    }

    public class ValidityList
    {
        public string source { get; set; }
        public int status { get; set; }
    }

    public class Rect
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class OriginalSymbol
    {
        public int code { get; set; }
        public int probability { get; set; }
        public Rect rect { get; set; }
    }

    public class FieldRect3
    {
        public int bottom { get; set; }
        public int left { get; set; }
        public int right { get; set; }
        public int top { get; set; }
    }

    public class ValueList
    {
        public int containerType { get; set; }
        public List<OriginalSymbol> originalSymbols { get; set; }
        public int originalValidity { get; set; }
        public int pageIndex { get; set; }
        public int probability { get; set; }
        public string source { get; set; }
        public string value { get; set; }
        public FieldRect fieldRect { get; set; }
        public string originalValue { get; set; }
        public int lightIndex { get; set; }
        public int originalPageIndex { get; set; }
    }


    /// <summary>
    /// Вероятно, является разделом Document Images
    /// </summary>
    public class FieldList
    {
        public List<ComparisonList> comparisonList { get; set; }
        public int comparisonStatus { get; set; }
        public string fieldName { get; set; }
        public int fieldType { get; set; }
        public int lcid { get; set; }
        public string lcidName { get; set; }
        public int status { get; set; }
        public List<ValidityList> validityList { get; set; }
        public int validityStatus { get; set; }
        public string value { get; set; }
        public List<ValueList> valueList { get; set; }
    }

    /// <summary>
    /// Соответствует разделу Text Fields
    /// </summary>
    public class Text
    {
        public List<AvailableSourceList> availableSourceList { get; set; }
        public int comparisonStatus { get; set; }
        public string dateFormat { get; set; }
        public List<FieldList> fieldList { get; set; }
        public int status { get; set; }
        public int validityStatus { get; set; }
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
        public int docType { get; set; }
        public int expiry { get; set; }
        public int imageQA { get; set; }
        public int mrz { get; set; }
        public int overallStatus { get; set; }
        public int pagesCount { get; set; }
        public int security { get; set; }
        public int text { get; set; }
        public int vds { get; set; }
    }

    public class DetailsRFID
    {
        public int AA { get; set; }
        public int BAC { get; set; }
        public int CA { get; set; }
        public int PA { get; set; }
        public int PACE { get; set; }
        public int TA { get; set; }
        public int overallStatus { get; set; }
    }

    /// <summary>
    /// Соответвует разделу Status
    /// </summary>
    public class Status
    {
        public DetailsOptical detailsOptical { get; set; }
        public DetailsRFID detailsRFID { get; set; }
        public int optical { get; set; }
        public int overallStatus { get; set; }
        public int portrait { get; set; }
        public int rfid { get; set; }
        public int stopList { get; set; }
    }

    public class ContainerList
    {
        public int Count { get; set; }
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
        private const string CantRecive = "can't resive data";

        public int ChipPage { get; set; }
        public ContainerList ContainerList { get; set; }
        public int CoreLibResultCode { get; set; }
        public int ProcessingFinished { get; set; }
        public TransactionInfo TransactionInfo { get; set; }
        public int elapsedTime { get; set; }
        public int morePagesAvailable { get; set; }
        public object passBackObject { get; set; }
        public bool serviceMemorySizeMaxExceeded { get; set; }

        public ExternalObjectModel ConverToCommonType()
        {
            string mRZLine = "", documentClassCode;

            var docVisualPart = ContainerList.List.First(it => it.DocVisualExtendedInfo != null);
            if (docVisualPart != null)
            {
                var fields = docVisualPart.DocVisualExtendedInfo.pArrayFields;
                mRZLine = fields.DefaultIfEmpty(new PArrayField() { Buf_Text = CantRecive })
                    .First(it => it.FieldType == 51 && it.FieldName == "MRZ Strings").Buf_Text;
                documentClassCode = fields.DefaultIfEmpty(new PArrayField() { Buf_Text = CantRecive })
                    .FirstOrDefault(it => it.FieldType == 51 && it.FieldName == "Document Class Code").Buf_Text;
            }

            return new ExternalObjectModel("testNumber")
            {
                MRZLine = mRZLine
            };
        }
    }


}
