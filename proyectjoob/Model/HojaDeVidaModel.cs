using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using DatoLaboralModel.Model;
using DatoAcademicoModel.Model;
using AspiranteModel.Model;


namespace HojaDeVidaModel.Model
{
    public class HojaDeVidaInputModel
    {
        public string Nombre{ get; set; }
        public string DescripcionPerfilLaboral{ get; set; }
        public string AspiranteId{ get; set; }
        
    }

    public class HojaDeVidaViewModel
    {
        public int HojaDeVidaId{ get; set; }
        public string Nombre{ get; set; }
        public string DescripcionPerfilLaboral{ get; set; }
        public AspiranteViewModel Aspirante { get; set; }
        public List<DatoAcademicoViewModel> DatosAcademicos{get; set; }
        public List<DatoLaboralViewModel> DatosLaborales{get; set; }
        
        public HojaDeVidaViewModel(HojaDeVida hojaDeVida)
        {
        Nombre=hojaDeVida.Nombre;
        DescripcionPerfilLaboral=hojaDeVida.DescripcionPerfilLaboral;
        Aspirante=new AspiranteViewModel(hojaDeVida.Aspirante);
        DatosAcademicos=hojaDeVida.DatosAcademicos.Select(p=>new DatoAcademicoViewModel(p)).ToList();
        DatosLaborales=hojaDeVida.DatosLaborales.Select(p=>new DatoLaboralViewModel(p)).ToList();
        }
    }

    public class InformacionHojaDeVidaViewModel
    {
        public string Nombre{ get; set; }
        public string DescripcionPerfilLaboral{ get; set; }


        public InformacionHojaDeVidaViewModel(HojaDeVida hojaDeVida)
        {
        Nombre=hojaDeVida.Nombre;
        DescripcionPerfilLaboral=hojaDeVida.DescripcionPerfilLaboral;
        }
    }

}
