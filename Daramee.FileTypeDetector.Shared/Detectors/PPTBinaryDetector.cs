using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Document)]
    class PPTBinaryDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]
        {
            new SignatureInformation () { Position =512, Signature = new byte [] { 0x00, 0x6E, 0x1E, 0xF0 } },
            new SignatureInformation () { Position =0, Signature = new byte [] { 0x0F, 0x00, 0xE8, 0x03 } }
        };

        public override string Extension => "ppt";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "Microsoft PowerPoint 97-2003 PowerPoint(.ppt)";
    }
}
