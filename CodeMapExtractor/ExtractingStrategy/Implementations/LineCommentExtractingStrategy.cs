using CodeMapExtractor.SemanticCriteria;
using CodeMapExtractor.Extensions;
using CodeMapExtractor.SemanticCriteria;
using CodeMapExtractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeMapExtractor.SemanticCriteria.CodeMapStandardCriteria;
using CodeMapExtractor.StringOperator;

namespace CodeMapExtractor.ExtractingStrategy.Implementations
{
    public class LineCommentExtractingStrategy : IExtractingStrategy
    {
        private CodeMapCommentCriteria _criteria;
        private StringHandler _handler;
        
        private Step extractStepFromQualifiedLine(string line)
        {
            var lineParts = _handler.SplitToParts(line);

            Step step = new Step();
            step.Number = int.Parse(lineParts[0]);
            step.Name = lineParts[1];
            return step;
        }
        public LineCommentExtractingStrategy()
        {
            _criteria = CodeMapStandardCriteriaFactory.GetCodeMapCommentCriteria();
            _handler = StringHandler.FromSemanticCriteria(_criteria);
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
