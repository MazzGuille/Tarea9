Clear();

//1)      Pedir al usuario la longitud de un vector
WriteLine("Ingrese la longitud del vector. Ingresar un numero entero entre 0-10:");
int longVector = int.Parse(ReadLine());
WriteLine("=====================================================================");
WriteLine();

//2)      Crear el vector del tamaño ingresado.
int[] miVector = new int[longVector];


//3)      Llenar el mismo con datos aleatorios
Random numRandom = new Random();

for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = numRandom.Next(0, 11);
}


//4)      Mostrar el vector por pantalla
WriteLine();
WriteLine("Mostrar el vector por pantalla:");
for (int i = 0; i < miVector.Length; i++)
{
    WriteLine($"La posicion {i} del vector equivale a: {miVector[i]}");
    WriteLine("=====================================================================");
}


//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero;
//        el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente.
//        En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido,
//        el vector debe quedar así: 50, 40, 30, 20, 10.
//        Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
WriteLine();
WriteLine("Vector invertido:");
for (int i = miVector.Length - 1; i >= 0; i--)
{
    WriteLine($"La posicion {i} del vector equivale a: {miVector[i]}");
    WriteLine("=====================================================================");
}

//6)      Mostrar el vector nuevamente.
WriteLine("");
WriteLine("Mostrar el vector nuevamente:");
for (int i = 0; i < miVector.Length; i++)
{
    WriteLine($"La posicion {i} del vector equivale a: {miVector[i]}");
    WriteLine("=====================================================================");
}