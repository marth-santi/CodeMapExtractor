using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria
{
    public class CommentCriteria : BaseCriteria
    {
        private const string LINE_COMMENT_PREFIX = "//";
        private const string BLOCK_COMMENT_PREFIX = "/*";
        private const string BLOCK_COMMENT_SUFFIX = "*/";
        public override bool SuccessfullyCheck(string code)
        {
            if (code.TrimStart().StartsWith(LINE_COMMENT_PREFIX))
                return true;

            if (code.TrimStart().StartsWith(BLOCK_COMMENT_PREFIX) && code.TrimEnd().EndsWith(BLOCK_COMMENT_SUFFIX))
                return true;

            return false;
        }
    }
}
