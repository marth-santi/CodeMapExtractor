using CodeMapExtractor.ExtractingStrategy;
using CodeMapExtractor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeMapExtractor.Extractors.Implementations
{
    public class StandardExtractor : ICodeMapExtractor
    {
        private BaseConfiguration _config;
        private IExtractingStrategy _strategy;

        public void UseConfiguration(BaseConfiguration config)
        {
            _config = config;
        }
        public void SetExtractingStrategy(IExtractingStrategy strategy)
        {
            _strategy = strategy;
        }
        public ICodeMap Extract()
        {
            var fileContent = File.ReadAllText(_config.Path);
            return _strategy.StartExtract(fileContent);
        }
    }
}
