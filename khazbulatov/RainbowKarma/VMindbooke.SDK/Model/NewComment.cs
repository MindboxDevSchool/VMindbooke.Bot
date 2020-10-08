﻿using System;

namespace VMindbooke.SDK.Model
{
    public class NewComment
    {
        public string Content { get; }

        public NewComment(string content)
        {
            Content = content ?? throw new ArgumentNullException(nameof(content));
        }
    }
}