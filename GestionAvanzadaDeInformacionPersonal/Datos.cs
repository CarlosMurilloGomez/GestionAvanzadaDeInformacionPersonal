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
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public String Email { get; set; }
        public String Genero { get; set; }
        public int Edad {  get; set; }
        public DateTime FechaNac {  get; set; }
        public String Pais { get; set; }
        public ArrayList Hobbies { get; set; }
        public bool Subscripcion {  get; set; }
        public int NivelSatisfacción { get; set; }
        public String RutaFotoPerfil { get; set; } = "C:\\Users\\infci\\source\\repos\\GestionAvanzadaDeInformacionPersonal\\GestionAvanzadaDeInformacionPersonal\\fotoPerfilDefault.jpg";


    }
}
