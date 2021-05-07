using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Mvc;
using DatoAcademicoModel.Model;

namespace proyectjoob.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DatoAcademicoController : ControllerBase
    {
        private readonly DatoAcademicoService datoAcademicoService;
        private readonly HojaDeVidaService hojaDeVidaService;
        public DatoAcademicoController(ProyectjoobContext context)
        {
            datoAcademicoService = new DatoAcademicoService(context);
            hojaDeVidaService = new HojaDeVidaService(context);
        }









        [HttpPost]
        public ActionResult<InformacionDatoAcademicoViewModel> PostDatoAcademico(DatoAcademicoInputModel DatoAcademicoInput)
        {
            var buscarHojaDeVidaResponse = hojaDeVidaService.BuscarHojaDeVidaPorCorreoAspirante(DatoAcademicoInput.AspiranteId);

                if(buscarHojaDeVidaResponse.HojaDeVida==null){
                        return BadRequest("No se encuentra registrada la hoja de vida en la que desea ingresar los datos");
                }else{

            var datoAcademico = MapearDatoAcademico(DatoAcademicoInput);
            datoAcademico.HojaDeVida= buscarHojaDeVidaResponse.HojaDeVida;
            var response = datoAcademicoService.GuardarDatoAcademico(datoAcademico);
            if (!response.Error)
            {
                var informacionDatoAcademicoViewModel = new InformacionDatoAcademicoViewModel(datoAcademico);
                return Ok(informacionDatoAcademicoViewModel);
            }
            return BadRequest(response.Mensaje);

                }
            
        }










        [HttpGet("{Id}")]
        public ActionResult<InformacionDatoAcademicoViewModel> GetDatoAcademicoId(int id)
        {
            var response = datoAcademicoService.BuscarPorId(id);
            if (!response.Error)
            {
                var informacionDatoAcademicoViewModel = new InformacionDatoAcademicoViewModel(response.DatoAcademico);
                return Ok(informacionDatoAcademicoViewModel);
            }
            return BadRequest(response.Mensaje);
        }














        [HttpGet]
        public ActionResult<IEnumerable<InformacionDatoAcademicoViewModel>> GetDatoAcademico()
        {
            var response = datoAcademicoService.Consultar();
            if (!response.Error)
            {
                var informacionDatoAcademicoViewModels = response.DatosAcademicos.Select(p => new InformacionDatoAcademicoViewModel(p));
                return Ok(informacionDatoAcademicoViewModels);
            }
            return BadRequest(response.Mensaje);
        }






        private DatoAcademico MapearDatoAcademico(DatoAcademicoInputModel datoAcademicoInput)
        {
            var datoAcademico = new DatoAcademico()
            {

        NombreCentroAcademico=datoAcademicoInput.NombreCentroAcademico,
        NivelEducativo=datoAcademicoInput.NivelEducativo,
        EstadoCurso=datoAcademicoInput.EstadoCurso,
        FechaInicio=datoAcademicoInput.FechaInicio,
        FechaFinalizacion=datoAcademicoInput.FechaFinalizacion,
            };
            return datoAcademico;
        }



    }
}

