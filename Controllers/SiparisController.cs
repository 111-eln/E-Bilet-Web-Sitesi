using eTicketApp.Models;
using Microsoft.AspNetCore.Mvc;
using Razorpay.Api;

namespace eTicketApp.Controllers
{
    public class SiparisController : Controller
    {
        [BindProperty]
        public Siparis siparisDetay { get; set; }
        public IActionResult siparisOlustur() {
            
            string key = "rzp_test_zNttLqHRw7tD0F";
            string secret = "4kaEO1oowH2Q67uyB1SBmrYj";
            Random _random = new Random();
            string iletimId = _random.Next(0, 10000).ToString();
           
            Dictionary<string, object> input = new Dictionary<string, object>();
            input.Add("amount",Convert.ToDecimal(siparisDetay.toplamTutar)*100); 
            input.Add("currency", "INR");
            input.Add("receipt", iletimId);

            RazorpayClient client = new RazorpayClient(key, secret);
            Razorpay.Api.Order order = client.Order.Create(input);
            ViewBag.orderid = order["id"].ToString();
            return View("Odeme", siparisDetay);
        }    
        public IActionResult Index()
        {
            return View();
        }
    }
}
