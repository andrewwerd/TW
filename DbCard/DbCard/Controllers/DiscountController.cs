using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbCard.Infrastructure.Dto.Balance;
using DbCard.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbCard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        // GET: api/customer/myDiscounts
        [Authorize(Roles = "Customer")]
        [HttpGet("myDiscounts")]
        public async Task<ActionResult<IEnumerable<MyDiscount>>> MyDiscounts()
        {
            var myDiscounts = await _discountService.GetMyDiscounts();
            if (!myDiscounts.Any()) return NoContent();
            return Ok(myDiscounts);
        }
    }
}
