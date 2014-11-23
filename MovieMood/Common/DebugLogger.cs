﻿using System;
using System.Diagnostics;

using Caliburn.Micro;

namespace MovieMood.Common
{
    class DebugLogger : ILog
    {
        public DebugLogger()
        {
        }

        public DebugLogger(Type type)
        {

        }

        private string CreateLogMessage(string format, params object[] args)
        {
            return string.Format("[{0}] {1}",
                                 DateTime.Now.ToString("o"),
                                 string.Format(format, args));
        }

        public void Error(Exception exception)
        {
            Debug.WriteLine(CreateLogMessage(exception.ToString()), "ERROR");
        }

        public void Info(string format, params object[] args)
        {
            Debug.WriteLine(CreateLogMessage(format, args), "INFO");
        }

        public void Warn(string format, params object[] args)
        {
            Debug.WriteLine(CreateLogMessage(format, args), "WARN");
        }

    }
}
