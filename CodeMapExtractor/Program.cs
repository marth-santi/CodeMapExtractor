using CodeMapExtractor.Configuration;
using CodeMapExtractor.ExtractingStrategy.Implementations;
using CodeMapExtractor.Extractors;
using CodeMapExtractor.Extractors.Implementations;
using CodeMapExtractor.Models;
using System;
using System.Text.Json;

namespace CodeMapExtractor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = StandardConfiguration.FromStringArgs(args);
            // TODO: choose extractor and strategy based on args input
            var extractor = new StandardExtractor();
            var strategy = new LineCommentExtractingStrategy();

            extractor.UseConfiguration(config);
            extractor.SetExtractingStrategy(strategy);
            var codeMapResult = extractor.Extract();

            Console.WriteLine(JsonSerializer.Serialize((FlowCodeMap)codeMapResult));
        }
    }
}
