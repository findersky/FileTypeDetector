using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Image)]
    class WMFDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]{
            new SignatureInformation () { Position =0, Signature = new byte [] { 0xD7, 0xCD, 0xC6, 0x9A } }
        };

        public override string Extension => "wmf";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "Windows Meta File";

    }
}
