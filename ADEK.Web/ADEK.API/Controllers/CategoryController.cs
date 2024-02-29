using ADEK.infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ADEK.Core.Constants;
namespace ADEK.API.Controllers
{
 
    public class CategoryController : BaseController
    {

        private readonly IInterfaceServices _interfaceServices;
        public CategoryController(IInterfaceServices interfaceServices)
        {
            _interfaceServices = interfaceServices;
        }

        [HttpGet]
        public IActionResult GetDataCategory(string lang = Constant.English, int page = Constant.NumberOne)
        {
            var data = _interfaceServices.categoryService.GetAll(page, lang);
            return Ok(GetRespons(data, MessageResults.GetSuccessResult()));
        }
 
    }
}