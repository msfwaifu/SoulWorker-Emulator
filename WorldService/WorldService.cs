﻿// Licensed under the MIT license. See LICENSE file in the project root folder for full license information.

using System;
using System.Threading;

using SoulWorker.Framework.Configuration;
using SoulWorker.Framework.Database;
using SoulWorker.Framework.Logging;

namespace SoulWorker.WorldService
{
    static class WorldService
    {
        static void Main(string[] args)
        {
            Log.Message();
            Log.Message(LogType.Normal, "Starting SoulWorker World Service...");

            // Service Function Placeholder

            Log.Message(LogType.Normal, "Total Memory Usage: {0} Kilobytes", GC.GetTotalMemory(false) / 1024);
        }
    }
}
