using DACN_Quan_Ly_Kham_Chua_Benh.Data;
using DACN_Quan_Ly_Kham_Chua_Benh.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DACN_Quan_Ly_Kham_Chua_Benh.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly DBContext _context;
        public TaiKhoanController(DBContext context)
        {
            _context = context;
        }

        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;

        //public TaiKhoanController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            var account = _context.TaiKhoan.FirstOrDefault(o => o.TenDangNhap == username && o.Quyen == 1);
            if(account != null && account.MatKhau.Equals(CalculateMD5Hash(password)))
            {
                ViewBag.ThanhCong = 1;               
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ThatBai = 1;
                return RedirectToAction("Login", "TaiKhoan");
            }         
        }
       
        public IActionResult Create()
        {
            TaiKhoan account = new TaiKhoan
            {
                //idTaiKhoan = 1,
                TenDangNhap = "admin",
                MatKhau = "123",
                Quyen = 1,
                TrangThai = 1
            };


            // Mã hóa mật khẩu bằng MD5
            string hashedPassword = CalculateMD5Hash(account.MatKhau);

            // Gán mật khẩu đã được mã hóa vào tài khoản
            account.MatKhau = hashedPassword;

            // Lưu tài khoản vào cơ sở dữ liệu
            _context.TaiKhoan.Add(account);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        private string CalculateMD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        public  IActionResult Logout()
        {           
            return RedirectToAction("Login", "TaiKhoan");
        }
        //Kha
        [HttpGet]
        public IActionResult Index(int trangthai = 0)
        {
            var taikhoan = _context.TaiKhoan.ToList();          
            if(trangthai == 0)
            {
                taikhoan = _context.TaiKhoan.Where(o => o.TrangThai == 0).ToList();
            }
            else
            {
                taikhoan = _context.TaiKhoan.Where(o => o.TrangThai == 1).ToList();
            }
            ViewBag.Check = taikhoan.Count;
            return View(taikhoan);
        }
        [HttpPost]
        public IActionResult XoaTaiKhoan(int idTaiKhoan)
        {
            var taiKhoan = _context.TaiKhoan.Find(idTaiKhoan);
            if (taiKhoan != null)
            {
                _context.TaiKhoan.Remove(taiKhoan);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //public IActionResult TrangThai1()
        //{
        //    var taikhoan1 = _context.TaiKhoan.Where(tk => tk.TrangThai == 1).ToList();
        //    return View(taikhoan1);
        //}
        public ActionResult ChangeStatus(int idTaiKhoan)
        {
            var taiKhoan3 = _context.TaiKhoan.Find(idTaiKhoan);

            if (taiKhoan3 == null)
            {
                return NotFound();
            }
            // Cập nhật trạng thái từ 0 sang 1
            taiKhoan3.TrangThai = 1;

            _context.SaveChanges();

            // Thực hiện các hành động khác nếu cần

            return RedirectToAction("Index");
        }
    }
}


