﻿using System;

namespace NStore.Persistence
{
    public class StreamDeleteException : Exception
    {
        public string StreamId { get; }

        public StreamDeleteException(string streamId) : 
            base($"Error deleting stream {streamId}")
        {
            this.StreamId = streamId;
        }
    }
}