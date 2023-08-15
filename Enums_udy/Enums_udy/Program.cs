//ENUMS
//agrupar conjunto de constantes numericas

using Enums_udy;

var esttatusDeVentaDeUnaCamisa = EstatusVenta.PendienteDePago;

//accion del estatus
//en switch presiona ctrl+. para colocar todos los posibles estatus de la clase
switch (esttatusDeVentaDeUnaCamisa)
{
    case EstatusVenta.Exitoso:
        Console.WriteLine("La venta fue exitosa");
        break;
    case EstatusVenta.PendienteDePago:
        Console.WriteLine("El cliente debe pagar");
        break;
    case EstatusVenta.Cancelada:
        Console.WriteLine("Nooooooooo :(");
        break;
    default:
        Console.WriteLine("Estatus desconocido");
        break;
}

//ejemplo 2 con casteos

int estatus = (int)esttatusDeVentaDeUnaCamisa;
Console.WriteLine(estatus);//1

int estatus2= 3;
var estatus2Nombre = (EstatusVenta)estatus2;
Console.WriteLine(estatus2Nombre);