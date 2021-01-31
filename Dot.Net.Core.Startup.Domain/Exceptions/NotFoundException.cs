﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot.Net.Core.Startup.Domain.Exceptions
{
    public class NotFoundException : BusinessExceptionBase
    {
        public NotFoundException(string message) : base(404, message)
        {

        }
    }
}
