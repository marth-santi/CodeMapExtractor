using CodeMapExtractor.SemanticCriteria;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.StringOperator
{
    public class StringHandler
    {
        private BaseCriteria _criteria;
        private StringHandler() { }
        public static StringHandler FromSemanticCriteria(BaseCriteria criteria)
        {
            var handler = new StringHandler();
            handler._criteria = criteria;
            return handler;
        }
        public string[] SplitToParts(string code)
        {
            var trimmedCode = code.TrimStart(_criteria.PREFIX.ToCharArray())
                                    .TrimEnd(_criteria.SUFFIX.ToCharArray());
            return trimmedCode.Split(_criteria.DELIMITERS.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
