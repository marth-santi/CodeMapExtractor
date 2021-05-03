using System;
using System.Collections.Generic;
using System.Text;

namespace CodeMapExtractor.Configuration
{
    public class StandardConfiguration : BaseConfiguration
    {
        public static StandardConfiguration FromStringArgs(string[] args)
        {
            StandardConfiguration config = new StandardConfiguration();
            config.Path = args[0];
            return config;
        }

        public StandardConfiguration()
        {
            FileType = "cs";
        }
    }
}
