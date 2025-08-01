using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Imaging;

namespace ApplicationNandu.Controllers
{
    public class CaptchaController : Controller
    {
        [HttpGet("/captcha-image")]
        public IActionResult GenerateCaptcha()
        {
            // Generate random 5-digit captcha
            var captchaCode = new Random().Next(10000, 99999).ToString();

            // Store captcha in session
            HttpContext.Session.SetString("CaptchaCode", captchaCode);

            // Create captcha image
            using var bitmap = new Bitmap(100, 40);
            using var graphics = Graphics.FromImage(bitmap);
            var font = new Font("Arial", 18, FontStyle.Bold);
            var rect = new Rectangle(0, 0, 100, 40);
            graphics.Clear(Color.LightGray);
            graphics.DrawString(captchaCode, font, Brushes.Red, rect);

            using var ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Png);
            return File(ms.ToArray(), "image/png");
        }
    }
}
