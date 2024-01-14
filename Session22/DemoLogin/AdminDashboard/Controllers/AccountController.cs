using Infrastructure.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Request;
using Models.Response;

namespace AdminDashboard.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("/tai-khoan/thong-tin-ca-nhan")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/dang-nhap")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/dang-ky")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("/quen-mat-khau")]
        public IActionResult Forgot()
        {
            return View();
        }

        [HttpPost("/do-login")]
        public async Task<IActionResult> DoLoginAsync(LoginRequest request)
        {
            var accountFind = await _unitOfWork.Account.HandleLoginAsync(request.Email);

            if (accountFind != null)
            {
                if (accountFind.Password.Equals(request.Password))
                {
                    return Ok(new ResponseObject<Account> { Code = 0, Message = "Login success!", Data = accountFind });
                }
            }

            return Ok();
        }

        [HttpPost("/do-register")]
        public async Task<IActionResult> DoRegisterAsync(RegisterRequest request)
        {
            var accountFind = await _unitOfWork.Account.HandleLoginAsync(request.Email);

            if (accountFind == null)
            {
                var account = new Account
                {
                    Email = request.Email,
                    Password = request.Password,
                    Address = request.Address,
                    IsActived = true,
                    IsDeleted = false,
                };

                var registerResult = await _unitOfWork.Account.CreateAsync(account);

                if (registerResult > 0)
                {
                    return Ok(new ResponseObject { Code = 0, Message = "Register success!", Data = registerResult });
                }

                return Ok(new ResponseObject { Code = -1, Message = "Register failed! Please try again!" });
            }

            return Ok(new ResponseObject { Code = -1, Message = "Email is already exist!" });
        }
    }
}
