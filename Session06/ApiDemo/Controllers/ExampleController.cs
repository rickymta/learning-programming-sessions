using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly ICalculation calculation;

        public ExampleController(ICalculation calculation)
        {
            this.calculation = calculation;
        }

        [HttpGet]
        [Route("tong/{a}/{b}")]
        public IActionResult Tong(int a, int b)
        {
            var result = calculation.Cong(a, b);
            return Ok(result);
        }

        [HttpGet]
        [Route("hieu/{a}/{b}")]
        public IActionResult Hieu(int a, int b)
        {
            var result = calculation.Cong(a, b);
            return Ok(result);
        }

        [HttpGet]
        [Route("tich/{a}/{b}")]
        public IActionResult Tich(int a, int b)
        {
            var result = calculation.Nhan(a, b);
            return Ok(result);
        }

        [HttpGet]
        [Route("thuong/{a}/{b}")]
        public IActionResult Thuong(int a, int b)
        {
            var result = calculation.Chia(a, b);
            return Ok(result);
        }
    }
}
