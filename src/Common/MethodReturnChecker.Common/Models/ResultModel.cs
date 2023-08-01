﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturnChecker.Common.Models
{
    public class ResultModel
    {
        public string FilePath { get; set; } = string.Empty;
        public int LineNumber { get; set; }
        public string MatchedLine { get; set; } = string.Empty;
        public string Error { get; set; } = string.Empty;
    }
}
