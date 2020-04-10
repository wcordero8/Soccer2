﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Soccer.Web.Helpers
{
    public interface IBlobHelper
    {
        Task<string> UploadBlobAsync(IFormFile file, string containerName);

        Task<string> UploadBlobAsync(byte[] file, string containerName);

        Task<string> UploadBlobAsync(string image, string containerName);

        string GetBlobPath(string containerName, string name);
    }
}
