﻿using Microsoft.AspNetCore.Mvc;

namespace Factory.PL.Services.UploadFile
{
    public interface IVideoService
    {
        Task<string> UploadVideoAsync(IFormFile video);
        Task<FileStreamResult> DownloadVideoAsync(string videoFileName);
        Task<bool> DeleteVideoAsync(string videoFileName);
    }

}
