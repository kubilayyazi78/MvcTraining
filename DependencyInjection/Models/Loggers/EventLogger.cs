﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models.Loggers
{
    public class EventLogger :ILogger
    {
        public void Log()
        {
            Debug.WriteLine("Logged With EventLogger");
        }
    }
}