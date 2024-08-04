using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Video)]
    class RMVBDetector: AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]{
            new SignatureInformation () { Position = 0, Signature = new byte [] { 0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12, 0x00, 0x01 } },
        };

        public override string Extension => "rmvb";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "rmvb Detector";
    }
}
