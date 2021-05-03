using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.SemanticCriteria
{
    public abstract class BaseCriteria
    {
        protected string prefix = "";
        protected List<string> delimiters = new List<string>();
        protected string suffix = "";

        public string PREFIX { get => prefix; }
        public List<string> DELIMITERS { get => delimiters; }
        public string SUFFIX { get => suffix; }

        public abstract bool SuccessfullyCheck(string codeline);
    }
}
