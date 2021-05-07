using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Mvc;
using AspiranteModel.Model;

namespace proyectjoob.Controllers
{


    [Route("api/[controller]")]
    [ApiController]

    public class AspiranteController : ControllerBase
    {
        private readonly AspiranteService aspiranteService;
        public AspiranteController(ProyectjoobContext context)
        {
            aspiranteService = new AspiranteService(context);
        }









        [HttpPost]
        public ActionResult<AspiranteViewModel> PostAspirante(AspiranteInputModel AspiranteInput)
        {

            var aspirante = MapearAspirante(AspiranteInput);
            var response = aspiranteService.GuardarAspirante(aspirante);
            if (!response.Error)
            {
                var AspiranteViewModel = new AspiranteViewModel(aspirante);
                return Ok(AspiranteViewModel);
            }
            return BadRequest(response.Mensaje);
        }










        [HttpGet("{Correo}")]
        public ActionResult<AspiranteViewModel> GetAspiranteCorreo(string correo)
        {
            var response = aspiranteService.BuscarPorCorreo(correo);
            if (!response.Error)
            {
                var aspiranteViewModel = new AspiranteViewModel(response.Aspirante);
                return Ok(aspiranteViewModel);
            }
            return BadRequest(response.Mensaje);
        }














        [HttpGet]
        public ActionResult<IEnumerable<AspiranteViewModel>> GetAspirante()
        {
            var response = aspiranteService.Consultar();
            if (!response.Error)
            {
                var aspiranteViewModels = response.Aspirantes.Select(p => new AspiranteViewModel(p));
                return Ok(aspiranteViewModels);
            }
            return BadRequest(response.Mensaje);
        }






        private Aspirante MapearAspirante(AspiranteInputModel aspiranteInput)
        {
            var aspirante = new Aspirante()
            {

            Correo=aspiranteInput.Correo,
            Contrasenia=aspiranteInput.Contrasenia,
            Identificacion=aspiranteInput.Identificacion,
            Nombres=aspiranteInput.Nombres,
            Apellidos=aspiranteInput.Apellidos,
            Edad=aspiranteInput.Edad,
            HorarioTrabajoPreferido=aspiranteInput.HorarioTrabajoPreferido,
            SalarioTrabajoPreferido=aspiranteInput.SalarioTrabajoPreferido,
            Telefono=aspiranteInput.Telefono,
            TipoDocumento=aspiranteInput.TipoDocumento,
            FechaNacimiento=aspiranteInput.FechaNacimiento,
            Genero=aspiranteInput.Genero,
            Pais=aspiranteInput.Pais,
            Departamento=aspiranteInput.Departamento,
            Ciudad=aspiranteInput.Ciudad,
            Nacionalidad=aspiranteInput.Nacionalidad,

            };
            return aspirante;
        }
    }


    
}
