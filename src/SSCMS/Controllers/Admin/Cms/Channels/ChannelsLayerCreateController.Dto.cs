﻿using System.Collections.Generic;
using SSCMS.Abstractions.Dto.Request;

namespace SSCMS.Controllers.Admin.Cms.Channels
{
    public partial class ChannelsLayerCreateController
    {
        public class CreateRequest : SiteRequest
        {
            public List<int> ChannelIds { get; set; }
            public bool IsIncludeChildren { get; set; }
            public bool IsCreateContents { get; set; }
        }
    }
}