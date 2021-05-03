using System;
using System.Collections.Generic;
using System.Text;

using CodeMapExtractor.ExtractingStrategy;
using CodeMapExtractor.Models;

namespace CodeMapExtractor.Extractors
{
    public interface ICodeMapExtractor
    {
        void UseConfiguration(BaseConfiguration config);
        void SetExtractingStrategy(IExtractingStrategy strategy);
        ICodeMap Extract();
    }
}
