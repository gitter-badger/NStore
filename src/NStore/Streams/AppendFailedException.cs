﻿using System;

namespace NStore.Streams
{
    public class AppendFailedException : Exception
    {
        public string StreamId { get; private set; }

        public AppendFailedException(string streamId, string message) : base(message)
        {
            StreamId = streamId;
        }
    }
}