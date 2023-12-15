using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Plugin_Framework.Models;

namespace Plugin_Framework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PluginController : ControllerBase
    {
        
        private readonly IPluginService _IPluginService;

        public PluginController(IPluginService IPluginService)
        {
            _IPluginService = IPluginService;
        }

        [HttpPost]
        [Route("EditPictures")]
        public async Task<IEnumerable<Picture>> EditPicturesAsync(RequestModel request)
        {
            //log request
            var result = await _IPluginService.EditPicturesAsync(request.PictureData);
            return result;
        }
    }
}
