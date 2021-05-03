using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria
{
    public abstract class BaseCriteria
    {
        public abstract bool SuccessfullyCheck(string codeline);
    }
}
