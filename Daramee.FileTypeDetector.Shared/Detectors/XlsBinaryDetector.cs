using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Document)]
    class XlsBinaryDetector : AbstractSignatureDetector
    {
        static SignatureInformation[] SignatureInfo = new[]
        {
            new SignatureInformation () { Position =512, Signature = new byte [] { 0x09, 0x08, 0x10, 0x00, 0x00, 0x06, 0x05, 0x00 } },//Excel spreadsheet subheader (MS Office)
            new SignatureInformation () { Position =0, Signature = new byte [] { 0x09, 0x02, 0x06, 0x00, 0x00, 0x00, 0x10, 0x00, 0xB9, 0x04, 0x5C, 0x00 } },//MS Excel v2
            new SignatureInformation () { Position =0, Signature = new byte [] { 0x09, 0x04, 0x06, 0x00, 0x00, 0x00, 0x10, 0x00, 0xF6, 0x05, 0x5C, 0x00 } }//MS Excel v4
        };

        public override string Extension => "xls";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override string ToString() => "Microsoft Excel 97-2003 Worksheet (.xls) Detector";
    }
}
