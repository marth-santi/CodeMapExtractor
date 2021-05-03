using CodeMapExtractor.SemanticCriteria;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria
{
    public static class SemanticCriteriaFactory
    {
        public static CommentCriteria GetCommentCriteria()
        {
            return new CommentCriteria();
        }
    }
}
