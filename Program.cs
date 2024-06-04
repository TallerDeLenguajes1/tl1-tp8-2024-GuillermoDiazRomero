using EspacioCalculadora;

Calculadora NuevaCalculadora = new Calculadora(); //Creo una variable de clase Calculadora con memoria dinamica

//Declaracion de variables
int nume;
string ingresado;
bool resultado;
int num;


//Agregando el historial al código
var historial = new List<Historial>();
var funcion = new Historial();

int contador = 0;

do
{
    Console.WriteLine("Calculadora Reiterativa para el numero {0}", NuevaCalculadora.Resultado);
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    Console.WriteLine("5.Limpiar");
    Console.WriteLine("6.Salir");
    do
    {
        Console.WriteLine("\nIngrese una opción");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado || nume < 1 || nume > 6);

    switch (nume)
    {
        case 1:
            num = numero();
            funcion.AgregarItem("Suma",contador,historial,NuevaCalculadora.Resultado,NuevaCalculadora.Sumar(num));
            break;
        case 2:
            num = numero();
            funcion.AgregarItem("Resta",contador,historial,NuevaCalculadora.Resultado,NuevaCalculadora.Restar(num));
            break;
        case 3:
            num = numero();
            funcion.AgregarItem("Multiplicar",contador,historial,NuevaCalculadora.Resultado,NuevaCalculadora.Multiplicar(num));
            break;
        case 4:
            num = numeroParaDividir();
            funcion.AgregarItem("Dividir",contador,historial,NuevaCalculadora.Resultado,NuevaCalculadora.Dividir(num));
            break;
        case 5:
            funcion.AgregarItem("Limpiar",contador,historial,NuevaCalculadora.Resultado,NuevaCalculadora.Limpiar());
            break;
    }
    contador++;
} while (nume != 6);

Console.WriteLine("=================Lista=================");
foreach (var item in historial)
{
    Console.WriteLine("Operación: "+ item.Operacion);
    Console.WriteLine("Id: "+item.NumeroOperacion);
    Console.WriteLine("Número anterior: "+item.Anterior);
    Console.WriteLine("Número Actual: "+item.Actual);
    Console.WriteLine("\n");
}

static int numero()
{
    string ingresado;
    int nume;
    bool resultado;
    do
    {
        Console.Write("\nIngrese un numero: ");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado);

    return (nume);
}

static int numeroParaDividir()
{
    string ingresado;
    int nume;
    bool resultado;
    do
    {
        Console.Write("\nIngrese un numero: ");
        ingresado = Console.ReadLine();
        resultado = int.TryParse(ingresado, out nume);
    } while (!resultado || nume == 0);

    return (nume);
}

