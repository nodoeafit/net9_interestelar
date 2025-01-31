using System.Text.RegularExpressions;
using AppProductos.Models;
using AppProductos.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppProductos.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductoService _productoService;
        private const int tamanoPagina = 5;

        public ProductController(ILogger<HomeController> logger, IProductoService productoService)
        {
            _logger = logger;
            _productoService = productoService;
        }
        public IActionResult Index(string searchTerm = "", int pagina = 1)
        {
            int totalProductos;
            var productos = _productoService.ObtenerTodos(searchTerm, pagina, tamanoPagina, out totalProductos);
            ViewBag.SearchTerm = searchTerm;
            ViewBag.Pagina = pagina;
            ViewBag.TotalPaginas = (int)Math.Ceiling((double)totalProductos / tamanoPagina);
            return View(productos);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _productoService.Agregar(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        public IActionResult Delete(int id)
        {
            var producto = _productoService.ObtenerPorId(id);
            if(producto != null)
            {
                _productoService.Eliminar(id);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id) { 
            _productoService.Eliminar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var producto = _productoService.ObtenerPorId(id);
            return producto == null ? NotFound() : View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto) {
            if (ModelState.IsValid) { 
                _productoService.Actualizar(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }
}
