﻿using System.Collections.Generic;
using SSCMS.Abstractions;
using SSCMS.Abstractions.Dto.Request;

namespace SSCMS.Controllers.Admin.Cms.Contents
{
    public partial class ContentsLayerDeleteController
    {
        public class GetRequest : ChannelRequest
        {
            public string ChannelContentIds { get; set; }
        }

        public class GetResult
        {
            public IEnumerable<Content> Contents { get; set; }
        }

        public class SubmitRequest : ChannelRequest
        {
            public string ChannelContentIds { get; set; }
            public bool IsRetainFiles { get; set; }
        }
    }
}