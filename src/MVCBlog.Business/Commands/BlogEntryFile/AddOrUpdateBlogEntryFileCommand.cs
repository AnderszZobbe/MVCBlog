﻿using System;

namespace MVCBlog.Business.Commands
{
    public class AddOrUpdateBlogEntryFileCommand
    {
        public string FileName { get; set; }

        public byte[] Data { get; set; }

        public Guid BlogEntryId { get; set; }
    }
}
