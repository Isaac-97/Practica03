using Practica03WS.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica03WS
{
    /// <summary>
    /// Descripción breve de CalcularWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService : System.Web.Services.WebService
    {        

        [WebMethod]
        public double AreaCuadrado(int _lado)
        {
            Calcular areas = new Calcular();
            return areas.CalcularAreaCuadrado(_lado);
        }

        [WebMethod]
        public double AreaTriangulo(int _base, int _altura)
        {
            Calcular areas = new Calcular();
            return areas.CalcularAreaTriangulo(_base, _altura);
        }

        [WebMethod]
        public double AreaCirculo(int _radio)
        {
            Calcular areas = new Calcular();
            return areas.CalcularAreaCirculo(_radio);
        }

    }
}
