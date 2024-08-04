namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Video)]
    class WMVDetector : AbstractSignatureDetector
    {

        static SignatureInformation[] WMV_SignatureInfo = new[]{
            new SignatureInformation () { Position = 0, Signature = new byte [] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11, 0xA6, 0xD9, 0x00, 0xAA, 0x00, 0x62, 0xCE, 0x6C } },
        };

        public override string Extension => "wmv";

        protected override SignatureInformation[] SignatureInformations => WMV_SignatureInfo;

        public override string ToString() => "wmv Detector";

    }
}
