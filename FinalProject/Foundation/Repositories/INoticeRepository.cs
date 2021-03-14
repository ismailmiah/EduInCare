﻿using System;
using DataAccessLayer;
using Foundation.Library.Contexts;
using Foundation.Library.Entities;

namespace Foundation.Library.Repositories
{
    public interface INoticeRepository : IRepository<Notice, Guid, WebsiteContext>
    {

    }
}