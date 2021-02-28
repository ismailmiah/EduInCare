﻿using System;
using System.Collections;
using Autofac;
using FinalProject.Models;
using Foundation.Entities;
using Foundation.Services;
using Microsoft.AspNetCore.Http;

namespace FinalProject.Areas.Admin.Models
{
    public class HeaderModel : BaseModel
    {
        private readonly IHeaderService _service;
        public HeaderModel(IHeaderService headerService)
        {
            _service = headerService;
        }

        public HeaderModel()
        {
            _service = Startup.AutofacContainer.Resolve<IHeaderService>();
        }

        public bool ShowBannerImage { get; set; }
        public IFormFile BannerImage { get; set; }
        public string ImagePath { get; set; }

        public void SaveHeader(HeaderModel model)
        {
            var header = model.ConvertToEntity(model);
            _service.AddHeaderImage(header);
        }

        public HeaderModel CurrentHeader()
        {
            var model = new HeaderModel();
            var headers = _service.GetHeader();
            foreach (var header in headers)
            {
                model.ImagePath = FormatImageUrl(header.Image?.AlternativeText);
                model.ShowBannerImage = header.ShowBannerImage;
            }
            return model;
        }
        private Header ConvertToEntity(HeaderModel model)
        {
            var (fileName, filePath) = StoreFile(model.BannerImage);
            return new Header
            {
                ShowBannerImage = model.ShowBannerImage,
                Image = new Image
                {
                    Url = filePath,
                    AlternativeText = $"{fileName}"
                },
            };
        }
    }
}
