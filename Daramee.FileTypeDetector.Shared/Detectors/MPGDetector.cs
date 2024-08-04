using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Video)]
    class MPGDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]{
            new SignatureInformation () { Position =0, Signature = new byte [] { 0x0, 0x0, 0x1, 0xBA } },
            new SignatureInformation () { Position =0, Signature = new byte [] { 0x0, 0x0, 0x1, 0xB3 } },
        };

        public override string Extension => "mpg";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "mpg Detector";

    }
}
