using CodeMapExtractor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.ExtractingStrategy
{
    public interface IExtractingStrategy
    {
        ICodeMap StartExtract(string sourceCode);
    }
}
