using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Business.Services
{
    public class PluginService : IPluginService
    {
        private readonly PictureEditorService _pictureEditorService;
        public PluginService(PictureEditorService pictureEditorService) 
        {
            _pictureEditorService = pictureEditorService;
        }  
        public async Task<IEnumerable<Picture>> EditPicturesAsync(IEnumerable<PictureDataToEdit> data)
        {

            var result = await _pictureEditorService.EditPicturesAsync(data);
            return result;
        }
    }
}
