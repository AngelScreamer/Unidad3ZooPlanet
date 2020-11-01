using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net;
using ZooPlanet.Models.ViewModels;
using ZooPlanet.Models;
using System.Linq;
using ZooPlanet.Repositories;

namespace ZooPlanet.Controllers
{
    public class AdministradorController : Controller
    {
        public IWebHostEnvironment Enviroment { get; set; }
        public AdministradorController(IWebHostEnvironment env)
        {
            Enviroment = env;
        }

        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            Repositories.Repository<Especies> repos = new Repositories.Repository<Especies>(context);

            return View(repos.GetAll().OrderBy(x => x.Id));
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            EspeciesViewModel vm = new EspeciesViewModel();
            animalesContext context = new animalesContext();
            ClasesRepository clasesRepository = new ClasesRepository(context);
            vm.Clases = clasesRepository.GetAll();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Agregar(EspeciesViewModel vm)
        {
            animalesContext context = new animalesContext();
            try
            {

                EspeciesRepository repos = new EspeciesRepository(context);
                repos.Insert(vm.Especies);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vm.Clases = clasesRepository.GetAll();
                return View(vm);

            }
        }
        [HttpGet]
        public IActionResult Imagen(int id)
        {
            animalesContext context = new animalesContext();
            EspeciesRepository repos = new EspeciesRepository(context);
            ImagenViewModel vm = new ImagenViewModel();
            vm.Especies = repos.GetById(id);
            if (System.IO.File.Exists(Enviroment.WebRootPath + $"/especies/{vm.Especies.Id}.jpg"))
            {
                vm.Imagen = vm.Especies.Id + ".jpg";
            }
            else
            {
                vm.Imagen = "SinFoto.jpg";
            }
            return View(vm);
        }

        [HttpPost]
        public IActionResult Imagen(ImagenViewModel vm)
        {
            try
            {
                if (vm.Archivo == null)
                {
                    ModelState.AddModelError("", "Debe seleccionar la imagen de la especie.");
                    return View(vm);
                }
                else
                {
                    if (vm.Archivo.ContentType != "image/jpeg" || vm.Archivo.Length > 1024 * 1024 * 2)
                    {
                        ModelState.AddModelError("", "Debe seleccionar un archivo jpg maximo de 2MB.");
                        return View(vm);
                    }
                }
                if (vm.Archivo != null)
                {
                    FileStream fs = new FileStream(Enviroment.WebRootPath + "/especies/" + vm.Especies.Id + ".jpg", FileMode.Create);
                    vm.Archivo.CopyTo(fs);
                    fs.Close();
                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);
                return View(vm);
            }
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            animalesContext context = new animalesContext();
            EspeciesViewModel vm = new EspeciesViewModel();
            EspeciesRepository especiesRepository = new EspeciesRepository(context);
            vm.Especies = especiesRepository.GetById(id);
            if (vm.Especies == null)
            {
                return RedirectToAction("Index");
            }
            ClasesRepository cr = new ClasesRepository(context);
            vm.Clases = cr.GetAll();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Editar(EspeciesViewModel vm)
        {
            animalesContext context = new animalesContext();
            try
            {
                EspeciesRepository repos = new EspeciesRepository(context);
                var p = repos.GetById(vm.Especies.Id);
                if (p != null)
                {
                    p.Especie = vm.Especies.Especie;
                    p.IdClase = vm.Especies.IdClase;
                    p.Peso = vm.Especies.Peso;
                    p.Tamaño = vm.Especies.Tamaño;
                    p.Habitat = vm.Especies.Habitat;
                    p.Observaciones = vm.Especies.Observaciones;
                    repos.Update(p);
                }
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                ClasesRepository clasesRepository = new ClasesRepository(context);
                vm.Clases = clasesRepository.GetAll();
                return View(vm);
            }
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            animalesContext context = new animalesContext();
            EspeciesRepository repos = new EspeciesRepository(context);
                var p = repos.GetById(id);

                if (p != null)
                {
                    return View(p);
                }
                else
                    return RedirectToAction("Index");
            
        }
        public IActionResult Eliminar(Especies p)
        {
            animalesContext context = new animalesContext();
                EspeciesRepository repos = new EspeciesRepository(context);
                var especie = repos.GetById(p.Id);
                if (especie != null)
                {
                    repos.Delete(especie);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "El producto no existe o ya ha sido eliminado.");
                    return View(p);
                }
            
        }
    }
}
