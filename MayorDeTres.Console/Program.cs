//Poner nombres linbdos de variables
//Limpiar el codigo y ver que ande dspues de hacer cambios
//Ver que metodos agregar
//Hacer que se repita preguntando al usuario
//TIP: vistiar el ejecrico del mayor de 2 con repeticion que hicimos en la casa de pato para sacar ejemplos de metodos, retornos, void

MayorDeTres();

int pedirNumeroAlUsuario()
{
    Console.WriteLine("Ingresar un numero para comparar y presione enter");
    // Si yo quiero poner en el segundo numero : ingrese el segundo numero a comparar ? //
    string linea = Console.ReadLine();
    int numeroLeido= int.Parse(linea);
    return numeroLeido;
}
void MayorDeTres()
{
    Console.WriteLine("Mayor de 3 números");
    Console.WriteLine("Este programa calcula el mayor de 3 números ingresados por el usuraio");
    Console.WriteLine();
    
    int numeroA= pedirNumeroAlUsuario();
    int numeroB= pedirNumeroAlUsuario();
    int numeroC= pedirNumeroAlUsuario();
    Console.WriteLine("Procesando.....");
    Thread.Sleep(1000); 
    if (numeroA == numeroB && numeroB == numeroC)
    {
        Console.WriteLine("Los números ingresados son iguales"); // Porque no me pregunta si quiero seguir comprando //
    }
    else
    {
        if (numeroA > numeroB && numeroB > numeroC)
        {

            Console.WriteLine("El número mayor es :" + numeroA);
        }
        else
        {
            if(numeroB> numeroC)
            {
                Console.WriteLine(" El número mayor es :" + numeroB);
            }
            else
            {
                Console.WriteLine(" El número mayor es :" + numeroC);
            }
        }
        Console.WriteLine(" ¿ Desea seguir buscando el mayor de tres ? Ingrese Si para continuar con el programa o No para finalizarlo. ");
        string Respuesta = Console.ReadLine();
        if(Respuesta == "Si")
        {
            MayorDeTres();
        }
        else
        {
            Console.WriteLine("Gracias por usar este programa por Brian y Pato");
            Console.WriteLine("Presione una tecla cualquiera para salir");
            Console.Read(); 
        }
    }
}






