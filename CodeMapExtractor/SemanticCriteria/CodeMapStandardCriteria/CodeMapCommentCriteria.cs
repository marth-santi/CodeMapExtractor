using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria.CodeMapStandardCriteria
{
    public class CodeMapCommentCriteria : BaseCriteria
    {
        private const string CODEMAP_COMMENT_PREFIX = "// [";
        private const string CODEMAP_COMMENT_DELIMITER = "]: ";
        public CodeMapCommentCriteria() : base()
        {
            this.prefix = CODEMAP_COMMENT_PREFIX;
            this.delimiters = new List<string> { CODEMAP_COMMENT_DELIMITER };
        }
        public override bool SuccessfullyCheck(string code)
        {
            if (code.TrimStart().StartsWith(PREFIX) && code.Contains(DELIMITERS[0]))
                return true;

            return false;
        }
    }
}
