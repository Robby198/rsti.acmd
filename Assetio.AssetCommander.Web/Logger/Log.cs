using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Assetio.AssetCommander.Web.Logger
{
    public class Log
    {
        private static ILog log => LogManager.GetLogger(new StackFrame(2).GetMethod().DeclaringType);

        static Log()
        {
        }

        public static void Info(object message) => log.Logger.Log(typeof(Log), log4net.Core.Level.Info, message, null);

        public static void Info(object message, Exception e) => log.Logger.Log(typeof(Log), log4net.Core.Level.Info, message, e);

        public static void Debug(object message) => log.Logger.Log(typeof(Log), log4net.Core.Level.Debug, message, null);

        public static void Debug(object message, Exception e) => log.Logger.Log(typeof(Log), log4net.Core.Level.Debug, message, e);

        public static void Warn(object message) => log.Logger.Log(typeof(Log), log4net.Core.Level.Warn, message, null);

        public static void Warn(object message, Exception e) => log.Logger.Log(typeof(Log), log4net.Core.Level.Warn, message, e);

        public static void Error(object message) => log.Logger.Log(typeof(Log), log4net.Core.Level.Error, message, null);

        public static void Error(object message, Exception e) => log.Logger.Log(typeof(Log), log4net.Core.Level.Error, message, e);

    }
}