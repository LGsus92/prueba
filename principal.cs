using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class program
{
    public static void Main(string[] args){
        int opc,n1,n2 ;
        do{
            console.writeLine("Selecciona una Opción");            
            console.writeLine("1. Sumar");
            console.writeLine("2. Restar");
            console.writeLine("3. Multiplicar");
            console.writeLine("4. Dividir");
            console.writeLine("5. Salir");
            opc= int.Parse(console.ReadLine());
        }
        while(opc != 5);
    }
}