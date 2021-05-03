using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.Models
{
    [Serializable]
    public class FlowCodeMap : ICodeMap
    {
        public string Name { get; set; }
        public List<Step> Steps { get; set; }
    }
    public class Step
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
