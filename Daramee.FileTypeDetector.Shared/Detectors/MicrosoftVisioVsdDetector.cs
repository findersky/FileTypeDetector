using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Document)]
    internal class MicrosoftVisioVsdDetector : AbstractCompoundFileDetailDetector
    {
        public override IEnumerable<string> Chunks { get { yield return "VisioDocument"; } }

        public override string Extension => "vsd";

        protected override bool IsValidChunk(string chunkName, byte[] chunkData)
        {
            if (chunkName == "VisioDocument")
                return true;
            return false;
        }

        public override string ToString() => "Microsoft Visio 2003-2010 Drawing (.vsd) Detector";
    }
}
