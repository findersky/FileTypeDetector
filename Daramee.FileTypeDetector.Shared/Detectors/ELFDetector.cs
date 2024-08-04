namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Compression)]
    class ELFDetector : AbstractSignatureDetector
    {
        static readonly SignatureInformation[] ELF_SignatureInfo = new[]
        {
            new SignatureInformation () { Position = 0, Signature = new byte [] { 0x7F, 0x45, 0x4C, 0x46 } },
        };

        public override string Extension => "elf";

        protected override SignatureInformation[] SignatureInformations => ELF_SignatureInfo;

        public override string ToString() => "Executable and Linkable Format";
    }
}
