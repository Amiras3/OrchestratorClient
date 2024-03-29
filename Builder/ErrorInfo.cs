﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ErrorInfo
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }

        public ValidationErrorInfo[] ValidationErrors { get; set; }
    }
}
