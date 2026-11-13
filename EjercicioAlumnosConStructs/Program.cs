using static System.Console;



//MATRIZ
int tamaño = 5;
Alumno[] listado = new Alumno[tamaño];

//RANDOM
Random rnd = new();





InicializarArray(listado);
MostrarArray(listado);

CalcularMedia(listado);
CalcularMáximaNota(listado);
CalcularMínimaNota(listado);

int nota = 5;
var hayAlumno = HayAlumnoConNota(listado, nota);
WriteLine($"¿Hay alumnos con nota = {nota}? : {(hayAlumno ? "SÍ": "NO")}");

var hayAlumnoConNombre = ComprobarNombreAlumnos(listado, out string nombre);
WriteLine($"¿Hay alumnos con el nombre {nombre}? : {(hayAlumnoConNombre ? "SÍ": "NO")}");


//=============================RETURN=================================
return; 

string ElegirNombre(int num)
{
    string[] listaNombres =
    {
        "Pepe", "Izan", "Juan", "María", "José", "Luis"
    };

    int numero = rnd.Next(0, listaNombres.Length);
    
    return listaNombres[numero];
    
    
    
}

void InicializarArray(Alumno[] valores)
{
    for (int i = 0; i < valores.Length; i++)
    {
        valores[i] = new Alumno { nombre = ElegirNombre(i), nota = rnd.Next(0, 11) };
    }
}

void MostrarArray(Alumno[] lista)
{
    for (int i = 0; i < lista.Length; i++)
    {
        Write($"ALUMNO: {lista[i].nombre}");
        Write(" ");
        Write($"NOTA: {lista[i].nota}");
        WriteLine();
    }
}

void CalcularMedia(Alumno[] lista)
{
    int suma = 0;

    foreach (var n in lista)
    {
        suma += n.nota;
    }

    double media = (double)suma / lista.Length;
    WriteLine($"MEDIA DE LA CLASE: {media}");
}

void CalcularMáximaNota(Alumno[] lista)
{
    int máximo = 0;
    string nombreAlumno = string.Empty;
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i].nota > máximo)
        {
            máximo = lista[i].nota;
            nombreAlumno = lista[i].nombre;
        }   
    }
    
    WriteLine($"EL ALUMNO CON MAYOR NOTA ES: {nombreAlumno} \n NOTA: {máximo}");
}

void CalcularMínimaNota(Alumno[] lista)
{
    int mínimo = 0;
    string nombreAlumno = string.Empty;
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i].nota < mínimo)
        {
            mínimo = lista[i].nota;
            nombreAlumno = lista[i].nombre;
        }   
    }
    
    WriteLine($"EL ALUMNO CON MENOR NOTA ES: {nombreAlumno} \n NOTA: {mínimo}");
}

bool HayAlumnoConNota(Alumno[] lista, int n)
{
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i].nota == n)
        {
            return true;
        }
    }

    return false;
}

bool ComprobarNombreAlumnos(Alumno[] lista, out string nombre)
{
    string? nombreAlumno = ReadLine().ToLower() ?? "Desconocido";
    nombre = nombreAlumno;
    for (int i = 0; i < lista.Length; i++)
    {
        if (lista[i].nombre.ToLower() == nombreAlumno.ToLower())
        {
            return true;
        }
    }

    return false;
}

struct Alumno
{
    public string nombre;
    public int nota;
}


