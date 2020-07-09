using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using FrontierCodeChallenge.Models;

namespace FrontierCodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<AccountsViewModel> accounts = new List<AccountsViewModel>();

            using (var client = new HttpClient())
            {
                using (var responseTask = await client.GetAsync("https://frontiercodingtests.azurewebsites.net/api/accounts/getall"))
                {
                    string response = await responseTask.Content.ReadAsStringAsync();
                    accounts = JsonConvert.DeserializeObject<List<AccountsViewModel>>(response);
                }
            }

            return View(accounts);
        }
    }
}
