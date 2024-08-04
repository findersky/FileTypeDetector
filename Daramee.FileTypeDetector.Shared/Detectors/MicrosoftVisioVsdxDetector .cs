using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Document)]
    class MicrosoftVisioVsdxDetector : AbstractZipDetailDetector
    {
        public override IEnumerable<string> Files { get { yield return "[Content_Types].xml"; yield return "_rels/.rels"; yield return "visio/document.xml"; yield return "visio/_rels/document.xml.rels"; } }

        public override string Precondition => "zip";
        public override string Extension => "vsdx";

        public override string ToString() => "Microsoft Visio Drawing (.vsdx) Detector";
    }
}
