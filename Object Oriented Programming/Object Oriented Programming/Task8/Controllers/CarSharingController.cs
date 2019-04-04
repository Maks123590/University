namespace Task8.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// The car sharing controller.
    /// </summary>
    public class CarSharingController : Controller
    {
        private readonly IConfiguration configuration;

        public CarSharingController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}