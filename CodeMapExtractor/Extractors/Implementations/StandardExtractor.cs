using CodeMapExtractor.ExtractingStrategy;
using CodeMapExtractor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
        public ICodeMap Extract<CodeMapType>() where CodeMapType : ICodeMap
        {
            // TODO: change output extract type based on T (generic)
            var fileContent = File.ReadAllText(_config.Path);
            return _strategy.StartExtract(fileContent);
        }
        public void ExtractToOutputFile<CodeMapType>() where CodeMapType : ICodeMap
        {
            var codeMapJson = JsonSerializer.Serialize((CodeMapType)Extract<CodeMapType>());
            using (var fileStream = File.OpenWrite("F:/mockfile.json"))
            {
                Byte[] info =
                    new UTF8Encoding(true).GetBytes(codeMapJson);
                fileStream.Write(info, 0, info.Length);
            }
            
        }

    }
}
