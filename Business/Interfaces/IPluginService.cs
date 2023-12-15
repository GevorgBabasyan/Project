using Business.Models;

namespace Business.Interfaces
{
    public interface IPluginService
    {
        public Task<IEnumerable<Picture>> EditPicturesAsync(IEnumerable<PictureDataToEdit> data);
    }
}
