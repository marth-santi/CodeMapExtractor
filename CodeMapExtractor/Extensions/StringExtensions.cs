using System;
using System.Collections.Generic;
using System.Text;

using CodeMapExtractor.SemanticCriteria;

namespace CodeMapExtractor.Extensions
{
    public static class StringExtensions
    {
        public static bool IsQualifiedFor(this string codeline, BaseCriteria criteria)
        {
            if (criteria.SuccessfullyCheck(codeline))
                return true;

            return false;
        }
    }
}
