using System;
using Entity;
using HojaDeVidaModel.Model;

namespace DatoAcademicoModel.Model
{
    public class DatoAcademicoInputModel
    {
        public string NombreCentroAcademico{get; set; }
        public string NivelEducativo{get; set; }
        public string EstadoCurso{get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }
        public string AspiranteId{get; set;}
    }

    public class DatoAcademicoViewModel
    {
        public string NombreCentroAcademico{get; set; }
        public string NivelEducativo{get; set; }
        public string EstadoCurso{get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }
        public HojaDeVidaViewModel HojaDeVida{get; set; }

        public DatoAcademicoViewModel(DatoAcademico datoAcademico)
        {
        NombreCentroAcademico=datoAcademico.NombreCentroAcademico;
        NivelEducativo=datoAcademico.NivelEducativo;
        EstadoCurso=datoAcademico.EstadoCurso;
        FechaInicio=datoAcademico.FechaInicio;
        FechaFinalizacion=datoAcademico.FechaFinalizacion;
        HojaDeVida=new HojaDeVidaViewModel(datoAcademico.HojaDeVida);
        }
    }

    public class InformacionDatoAcademicoViewModel
    {
        public string NombreCentroAcademico{get; set; }
        public string NivelEducativo{get; set; }
        public string EstadoCurso{get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }

        public InformacionDatoAcademicoViewModel(DatoAcademico datoAcademico)
        {
        NombreCentroAcademico=datoAcademico.NombreCentroAcademico;
        NivelEducativo=datoAcademico.NivelEducativo;
        EstadoCurso=datoAcademico.EstadoCurso;
        FechaInicio=datoAcademico.FechaInicio;
        FechaFinalizacion=datoAcademico.FechaFinalizacion;
        }
    }
}
