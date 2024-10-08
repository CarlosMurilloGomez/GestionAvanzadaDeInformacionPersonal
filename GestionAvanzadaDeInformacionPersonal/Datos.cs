using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvanzadaDeInformacionPersonal
{
    public class Datos
    {
        String Nombre { get; set; }
        String Direccion { get; set; }
        String Email { get; set; }
        String Genero { get; set; }
        int Edad {  get; set; }
        DateTime FechaNac {  get; set; }
        String Pais { get; set; }
        ArrayList Hobbies { get; set; }
        bool Subscripcion {  get; set; }
        int NivelSatisfacción { get; set; }

    }
}
