using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Api.Controllers
{
    /// <summary>
    /// Работа с корзиной товаров.
    /// </summary>
    [ApiController]
    [Route("v1/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly ILogger _logger;
        public ShoppingCartController(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Получить все товары из корзины.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return await Task.FromResult(Ok());
        }

        /// <summary>
        /// Изменить количество товара в корзине.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateQuantityAsync()
        {
            return await Task.FromResult(Ok());
        }


        /// <summary>
        /// Удалить товар из корзины.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return await Task.FromResult(Ok());
        }
    }
}
