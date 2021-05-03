using CodeMapExtractor.SemanticCriteria;
using CodeMapExtractor.Extensions;
using CodeMapExtractor.SemanticCriteria;
using CodeMapExtractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeMapExtractor.ExtractingStrategy.Implementations
{
    public class LineCommentExtractingStrategy : IExtractingStrategy
    {
        private const string CODEMAP_COMMENT_PREFIX = "// [";
        private const string CODEMAP_COMMENT_NUMBER_VS_NAME_DELIMITER = "]: ";
        private CommentCriteria _criteria;
        
        private Step extractStepFromQualifiedLine(string line)
        {
            var lineParts = line.TrimStart(CODEMAP_COMMENT_PREFIX.ToCharArray())
                                            .Split(CODEMAP_COMMENT_NUMBER_VS_NAME_DELIMITER);

            Step step = new Step();
            step.Number = int.Parse(lineParts[0]);
            step.Name = lineParts[1];
            return step;
        }
        public LineCommentExtractingStrategy()
        {
            _criteria = SemanticCriteriaFactory.GetCommentCriteria();
        }
        public ICodeMap StartExtract(string sourceCode)
        {
            FlowCodeMap flowMap = new FlowCodeMap();
            flowMap.Name = "Mock line comment extraction";
            flowMap.Steps = new List<Step>();

            var lines = sourceCode.Split('\n');
            lines.ToList().ForEach(
                line =>
                {
                    if (line.IsQualifiedFor(_criteria))
                    {
                        var step = extractStepFromQualifiedLine(line);
                        flowMap.Steps.Add(step);
                    }
                }
            );
            return flowMap;
        }
    }
}
