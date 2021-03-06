﻿using System;
using System.Threading;

namespace MusicBear.Core
{
    public static class AppControl
    {
        public static void Exit()
        {
            Thread.Sleep(1000);
            MessageHandler.Service.AddMessage("Message", "This application will be closed automatically in 15sec");
            Thread.Sleep(15000);
            Environment.Exit(0);
        }
    }
}
