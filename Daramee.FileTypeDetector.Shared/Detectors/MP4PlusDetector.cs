using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{

    [FormatCategory(FormatCategories.Video)]
    class MP4PlusDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]{
            new SignatureInformation () { Position =4, Signature = new byte [] { 0x66, 0x74, 0x79, 0x70, 0x4D, 0x53, 0x4E, 0x56 } },
            new SignatureInformation () { Position =4, Signature = new byte [] { 0x66, 0x74, 0x79, 0x70, 0x69, 0x73, 0x6F, 0x6D } },
        };

        public override string Extension => "mp4";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "mp4 Detector";

    }
}
