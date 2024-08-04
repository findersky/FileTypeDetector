using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Daramee.FileTypeDetector.Detectors
{
    [FormatCategory(FormatCategories.Executable)]
    class HyperTextMarkupLanguageDetector : AbstractRegexSignatureDetector
    {
        public override string Precondition => "txt";
        public override string Extension => "html";

        protected override Regex Signature => new Regex(@"(?:<!DOCTYPE html.*?>)?[\s\S]*?<html.*>", RegexOptions.IgnoreCase);

        public override string ToString() => "HyperText Markup Language(HTML) Detector";
    }
}
