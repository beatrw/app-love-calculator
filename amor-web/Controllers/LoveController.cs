using Microsoft.AspNetCore.Mvc;
using System;

namespace LoveCalculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoveController : ControllerBase
    {
        private readonly Random _random = new Random();

        [HttpGet("GetPercentage")]
        public IActionResult GetPercentage(string fname, string sname)
        {
            int percentage = _random.Next(0, 101);
            string result = GetResultByPercentage(percentage);

            var response = new
            {
                fname = fname,
                sname = sname,
                percentage = percentage.ToString(),
                result = result
            };

            return Ok(response);
        }

        [HttpPost("Calculate")]
        public IActionResult Calculate([FromBody] LoveData data)
        {
            int percentage = _random.Next(0, 101);
            string result = GetResultByPercentage(percentage);

            var response = new
            {
                fname = data.fname,
                sname = data.sname,
                percentage = percentage.ToString(),
                result = result
            };

            return Ok(response);
        }

        private string GetResultByPercentage(int percentage)
        {
            if (percentage <= 10)
            {
                return "Não combina ( ˘︹˘ )";
            }
            else if (percentage > 10 && percentage < 40)
            {
                return "Relação instável (╥﹏╥)";
            }
            else if (percentage >= 40 && percentage < 60)
            {
                return "Belo par (>‿◠)✌";
            }
            else if (percentage >= 60 && percentage < 90)
            {
                return "Amor duradouro ٩(˘◡˘)۶";
            }
            else
            {
                return "Amor eterno! Compatibilidade perfeita ≧✯◡✯≦";
            }
        }
    }

    public class LoveData
    {
        public string fname { get; set; }
        public string sname { get; set; }
    }
}
