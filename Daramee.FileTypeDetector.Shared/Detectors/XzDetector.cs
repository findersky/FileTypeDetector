using System;
using System.Collections.Generic;
using System.Text;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Compression)]
    class XzDetector : AbstractSignatureDetector
	{
		static SignatureInformation[] SignatureInfo = new[]
		{
			new SignatureInformation () { Position = 0, Signature = new byte [] { 0xFD, 0x37, 0x7A, 0x58, 0x5a, 0x00 } }
		};

		public override string Extension => "xz";

		protected override SignatureInformation[] SignatureInformations => SignatureInfo;

		public override string ToString() => "xz Detector";
	}
}
