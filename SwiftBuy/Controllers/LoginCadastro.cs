using Microsoft.AspNetCore.Mvc;

namespace SwiftBuy.Controllers {
    public class LoginCadastro : Controller {
        public IActionResult Login() {
            return View();
        }
        public IActionResult Cadastro() {
            return View();
        }
    }
}
