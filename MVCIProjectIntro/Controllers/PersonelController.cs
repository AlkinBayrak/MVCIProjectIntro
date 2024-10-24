using Microsoft.AspNetCore.Mvc;
using MVCIProjectIntro.Models;

namespace MVCIProjectIntro.Controllers
{
    public class PersonelController : Controller
    {
        private static List<Personel> list = new List<Personel>()
        {
            new Personel {Id = 1 ,Name = "Alkın",Surname = "Bayrak"},
            new Personel {Id = 2 ,Name = "Meltem",Surname = "Ceran"},
            new Personel {Id = 3 ,Name = "Batu",Surname = "Özbakır"}
        };
        public IActionResult IndexPersonel()
        {
            return View(list);
        }

        [HttpGet]
        public IActionResult PersonelAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PersonelAdd(Personel personel)
        {
            personel.Id = list.Count + 1;
            list.Add(personel);
            return RedirectToAction("IndexPersonel");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var personel = list.FirstOrDefault(p => p.Id == id);
            if (personel != null)
            {
                list.Remove(personel);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var personel = list.FirstOrDefault(p => p.Id == id);
            if (personel == null)
            {
                return NotFound();
            }
            return View(personel);
        }

        [HttpPost]
        public IActionResult Update(Personel personel)
        {
            var mevcutPersonel = list.FirstOrDefault(p => p.Id == personel.Id);
            if (mevcutPersonel == null)
            {
                return NotFound();
            }
            mevcutPersonel.Name = personel.Name;
            mevcutPersonel.Surname = personel.Surname;
            return RedirectToAction("IndexPersonel");
        }
    }
}
