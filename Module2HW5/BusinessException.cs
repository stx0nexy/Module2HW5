﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW5
{
    public class BusinessException : Exception
    {
        public BusinessException(string message)
        : base(message)
        {
        }
    }
}
