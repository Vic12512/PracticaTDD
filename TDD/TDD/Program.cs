using TDD;

public class Interfaz
{
    public void Iniciar()
    {
        Vasos vasosSmall = new Vasos();
        Vasos vasosMedium = new Vasos();
        Vasos vasosLarge = new Vasos();

        vasosSmall.setCantidadVasos(10);
        vasosMedium.setCantidadVasos(10);
        vasosLarge.setCantidadVasos(10);

        Azucarero azucarero = Azucarero.ObtenerInstancia();
        azucarero.setAzucar(100);

        Cafetera cafetera = Cafetera.ObtenerInstancia();
        cafetera.setCafe(100);

        Console.WriteLine(vasosLarge.getCantidadVasos());
        Console.WriteLine(vasosSmall.getCantidadVasos());
        Console.WriteLine(vasosMedium.getCantidadVasos());
        Console.WriteLine(azucarero.getAzucar());
        Console.WriteLine(cafetera.getCafe());


        maquinaDeCafe maquina = new maquinaDeCafe(vasosSmall, vasosMedium, vasosLarge);
        int cantidadVasos;

        do
        {
            Console.WriteLine("¿Cuántos vasos de café deseas pedir?");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out cantidadVasos) || cantidadVasos <= 0)
            {
                Console.WriteLine("La cantidad ingresada es invalida. Ingrese un número entero positivo, si sabe lo que es.");
            }
        } while (cantidadVasos <= 0);

        for (int i = 0; i < cantidadVasos; i++) {
            Console.WriteLine("Selecciona el tamaño del vaso para el pedido #" + (i + 1));
            Console.WriteLine("P = Pequeño, M = Mediano, G = Grande");
            char tipoVaso = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("¿Cuánta cucharadas de  azúcar quieres para este vaso?");
            int cantidadAzucar = Convert.ToInt32(Console.ReadLine());

            try
            {
                maquina.getVasoDeCafe(tipoVaso, 1, cantidadAzucar);
                Console.WriteLine($"Tu café de tamaño {tipoVaso} con {cantidadAzucar} cucharadas de azúcar está listo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
        Console.WriteLine("Gracias por usar la máquina de café.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Interfaz interfaz = new Interfaz();  // Instanciar la clase
        interfaz.Iniciar();  // Llamar al método Iniciar
    }
}