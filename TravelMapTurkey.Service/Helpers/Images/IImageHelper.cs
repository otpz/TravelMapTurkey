using Microsoft.AspNetCore.Http;
using TravelMapTurkey.Entity.ViewModel.Images;

namespace TravelMapTurkey.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedViewModel> Upload(string name, IFormFile imageFile, string folderName = null);
        void Delete(string imageName);
    }
}
