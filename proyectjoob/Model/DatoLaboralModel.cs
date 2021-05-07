using System;
using Entity;
using HojaDeVidaModel.Model;

namespace DatoLaboralModel.Model
{
public class DatoLaboralInputModel
    {
        public string NombreEmpresa { get; set; }
        public string Cargo{get;set; }
        public string Area { get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }
        public string AspiranteId{get; set; }
    }

    public class DatoLaboralViewModel
    {
        public string NombreEmpresa { get; set; }
        public string Cargo{get;set; }
        public string Area { get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }
        public HojaDeVidaViewModel HojaDeVida{get; set; }

        public DatoLaboralViewModel(DatoLaboral datoLaboral)
        {
        NombreEmpresa=datoLaboral.NombreEmpresa;
        Cargo=datoLaboral.Cargo;
        Area=datoLaboral.Area;
        FechaInicio=datoLaboral.FechaInicio;
        FechaFinalizacion=datoLaboral.FechaFinalizacion;
        HojaDeVida=new HojaDeVidaViewModel(datoLaboral.HojaDeVida);
        }
    }

    public class InformacionDatoLaboralViewModel
    {
        public string NombreEmpresa { get; set; }
        public string Cargo{get;set; }
        public string Area { get; set; }
        public DateTime FechaInicio{get; set; }
        public DateTime FechaFinalizacion{get; set; }

        public InformacionDatoLaboralViewModel(DatoLaboral datoLaboral)
        {
        NombreEmpresa=datoLaboral.NombreEmpresa;
        Cargo=datoLaboral.Cargo;
        Area=datoLaboral.Area;
        FechaInicio=datoLaboral.FechaInicio;
        FechaFinalizacion=datoLaboral.FechaFinalizacion;
        }
    }



    
}
