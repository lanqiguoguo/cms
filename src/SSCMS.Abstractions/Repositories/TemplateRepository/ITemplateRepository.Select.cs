﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SSCMS.Abstractions
{
    public partial interface ITemplateRepository
    {
        Task<List<TemplateSummary>> GetSummariesAsync(int siteId);

        Task<Template> GetAsync(int templateId);
    }
}