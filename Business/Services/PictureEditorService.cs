using Business.Models;
using System.Runtime.CompilerServices;
using static Business.Constants.Constants;

namespace Business.Services
{
    public class PictureEditorService
    {
        public PictureEditorService() 
        {

        }   

        public async Task<List<Picture>> EditPicturesAsync(IEnumerable<PictureDataToEdit> data)
        {

            var pictures = new List<Picture>(data.Count());
            foreach (var picture in data)
            {
                pictures.Add(await EditAsync(picture));
            }
            return pictures;
        }

        private async Task<Picture> EditAsync(PictureDataToEdit data)
        {
            var picture = new Picture();
            foreach (var item in data.Effects)
            {
                await EffectAsync(picture, (EffectType)item.Type);
            }
            return picture;
        }

        private async Task EffectAsync(Picture picture, EffectType type)
        {
            //////
            await Task.FromResult(picture);
            ///
        }
    }
}
