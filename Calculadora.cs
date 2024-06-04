//Ejercicio 1
//En este archivo solamente se crean las clases

namespace EspacioCalculadora
{

    //Creo una clase publica capaz de ser accesible con "."
    public class Calculadora
    {
        //Todo lo que se declare aquí son los campos o atributos de mi clase, luego se trabaja como una estructura en c

        private double dato; //Creo un dato de forma privada que se inicializa en 0
        public double Resultado { get => dato; }
        //get copio valor, set asigno valor
        public double Sumar(double termino)
        {
            dato += termino;
            return dato;

        }
        public double Restar(double termino)
        {
            dato -= termino;
            return dato;
        }
        public double Multiplicar(double termino)
        {
            dato *= termino;
            return dato;

        }
        public double Dividir(double termino)
        {
            dato /= termino;
            return dato;

        }
        public double Limpiar()
        {
            dato = 0;
            return dato;

        }
    }

    public class Historial
    {
        private string operacion;
        public string Operacion { get => operacion; set => operacion = value; }
        private int numeroOperacion;
        public int NumeroOperacion { get => numeroOperacion; set => numeroOperacion = value; }
        private double anterior;
        public double Anterior { get => anterior; set => anterior = value;}
        private double actual;
        public double Actual { get => actual; set => actual = value; }
        public void AgregarItem(string titulo, int id, List<Historial> lista, double anterior, double actual)
        {
            Historial item = new Historial();
            item.operacion = titulo;
            item.numeroOperacion = id;
            item.actual = actual;
            item.Anterior = anterior;
            lista.Add(item);
        }

    }
}
//Los datos de alguna clase siempre deben ser privados mientras que las funciones que lo editan tienen que ser publicas


