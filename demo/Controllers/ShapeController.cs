using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [Route("api/Shape")]
    [ApiController]
    public class ShapeController : ControllerBase
    {
        private readonly IShapeService _shapeService;
        public ShapeController(IShapeService shapeService):base()
        {
            _shapeService = shapeService;
        }

        [HttpGet]
        [Route("all")]
        public ActionResult<List<string>> GetAll()
        {
            return _shapeService.GetAll();
        }

        [HttpGet]
        [Route("Square/Area")]
        public ActionResult<double> SquareArea(double length)
        {
            return _shapeService.SquareArea(length);
        }
    }
}