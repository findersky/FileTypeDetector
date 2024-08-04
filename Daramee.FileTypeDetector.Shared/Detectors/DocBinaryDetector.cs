using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Document)]
    class DocBinaryDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]
        {
            new SignatureInformation () { Position =512, Signature = new byte [] { 0xEC, 0xA5, 0xC1, 0x00 } },
        };

        public override string Extension => "doc";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "Microsoft Word 97 - 2003 Document(.doc) Detector";
    }
}
