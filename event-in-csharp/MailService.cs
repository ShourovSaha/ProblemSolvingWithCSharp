﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace event_in_csharp
{
    /// <summary>
    /// Subscriber class.
    /// The responsibility of this class is to send mail.
    /// </summary>
    public class MailService
    {
        public void OnMessageLogged(object sender, EventArgs args)
        {
            Console.WriteLine("Mail send starts...");
            Thread.Sleep(3000);
            Console.WriteLine("Mail send ends...");
        }
    }
}
