using System;
using System.Collections.Generic;
using System.Text;

using CodeMapExtractor.SemanticCriteria;

namespace CodeMapExtractor.Extensions
{
    public static class StringExtensions
    {
        public static bool IsQualifiedFor(this string code, BaseCriteria criteria)
        {
            if (criteria.SuccessfullyCheck(code))
                return true;

            return false;
        }
    }
}
