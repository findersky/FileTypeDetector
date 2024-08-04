using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    internal class MicrosoftProjectMPPDetector : AbstractSignatureDetector
    {
        //public override IEnumerable<string> Files { get { yield return "MSProject"; } }

        static SignatureInformation[] SignatureInfo = new[]
{
            new SignatureInformation () { Position =0, Signature = new byte [] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 } },
        };

        public override string Extension => "mpp";

        protected override SignatureInformation[] SignatureInformations => SignatureInfo;

        public override bool Detect(Stream stream)
        {
            if (stream==null||!base.Detect(stream))
            {
                return false;
            }
            byte[] buffer = new byte[5120];
            byte[] fileTag = new byte[] { 0x4d,0x53, 0x50, 0x72, 0x6f, 0x6a, 0x65, 0x63, 0x74 };
            int tagIndex=0;
            while (true)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = 0;
                }
                var p=stream.Read (buffer, 0, buffer.Length);
                for (int i = 0; i < buffer.Length; i++)
                {
                    int j = tagIndex;
                    for (;j < fileTag.Length; j++)
                    {
                        if (fileTag[j] != buffer[i])
                        {
                            tagIndex = 0;
                            break;
                        }
                        tagIndex = j+1;
                        break;
                    }
                    if (tagIndex == fileTag.Length - 1)
                    {
                        return true;
                    }
                }
                if (tagIndex == fileTag.Length - 1)
                { 
                   return true;
                }
                if (p <= 0)
                {
                    break;
                }
            }
            return false;
        }
        public override string ToString() => "Microsoft Project Document (.mpp) Detector";
}
}
