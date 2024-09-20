using Content.Api.Servicesk;
using Microsoft.AspNetCore.Mvc;

namespace Content.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentController : ControllerBase
    {
        private readonly IContentService _contentService;

        public ContentController(IContentService contentService)
        {
            _contentService = contentService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_contentService.GetContentItems());

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var item = _contentService.GetById(id);

            if (item == null) return NotFound();

            return Ok(item);
        }
    }
}
