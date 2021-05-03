using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria.CodeMapStandardCriteria
{
    public class CodeMapStandardCriteriaFactory
    {
        public static CodeMapCommentCriteria GetCodeMapCommentCriteria()
        {
            return new CodeMapCommentCriteria();
        }
    }
}
