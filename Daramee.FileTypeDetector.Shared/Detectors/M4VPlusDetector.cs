using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Video)]
    class M4VPlusDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]{
            new SignatureInformation () { Position =4, Signature = new byte [] { 0x66, 0x74, 0x79, 0x70, 0x4D, 0x34,0x56 } }
        };

        public override string Extension => "m4v";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "m4v Detector";

    }
}
