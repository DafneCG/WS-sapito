using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_sapito
{
    /// <summary>
    /// Descripción breve de sapito
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class sapito : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(int calificaciones)
        {
			String[] t = new String[10];
			t[0] = "Play Station 1";
			t[1] = "Play Station 2";
			t[2] = "Play Station 3";
			t[3] = "Play Station 4";
			t[4] = "PSP E1000";
			t[5] = "Nintendo Switch";
			t[6] = "Nintendo DS Lite";
			t[7] = "Xbox";
			t[8] = "Xbox 360";
			t[9] = "Xbox One";
			string a = t[0] + "tiene 6 de calificacion";
			string b = t[1] + "tiene 6 de calificacion";
			string c = t[2] + "tiene 7 de calificacion";
			string d = t[3] + "tiene 9 de calificacion";
			string e = t[4] + "tiene 9 de calificacion";
			string f = t[5] + "tiene 10 de calificacion";
			string g = t[6] + "tiene 5 de calificacion";
			string h = t[7] + "tiene 7 de calificacion";
			string i = t[8] + "tiene 8 de calificacion";
			string j = t[9] + "tiene 9 de calificacion";
			string z = "opcion invalida :)";

			int l;
			l = calificaciones;
			if (l == 0)
			{
				return a;
			}
			if (l == 1)
			{
				return b;
			}
			if (l == 2)
			{
				return c;
			}
			if (l == 3)
			{
				return d;
			}
			if (l == 4)
			{
				return e;
			}
			if (l == 5)
			{
				return f;
			}
			if (l == 6)
			{
				return g;
			}
			if (l == 7)
			{
				return h;
			}
			if (l ==8)
			{
				return i;
			}
			if (l == 9)
			{
				return j;
			}
			{
				return e;
			}
		}
    }
}
