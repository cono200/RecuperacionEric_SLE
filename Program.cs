namespace RecuperacionEric_SLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IntentoListas intentoListas1 = new IntentoListas();



            //int continuar=0;

            //    Console.WriteLine("Ingrese la marca del auto");
            //    string marca = Console.ReadLine();
            //    Console.WriteLine("Ingrese el modelo");
            //    int modelo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Ingrese el año de fabricacion");
            //    int anioLanzamiento = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("¿Quieres añadir otro? 1 para simon 2 para nel");
            //continuar = Convert.ToInt32(Console.ReadLine());
            //intentoListas1.InsertarInicio(new Carro(marca,modelo,anioLanzamiento));



            //if (continuar== 1)
            //{
            //    Console.WriteLine("Ingrese la marca del auto");
            //     marca = Console.ReadLine();
            //    Console.WriteLine("Ingrese el modelo");
            //     modelo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Ingrese el año de fabricacion");
            //     anioLanzamiento = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Todavia quieres continuar?");
            //    continuar = Convert.ToInt32(Console.ReadLine());
            //    intentoListas1.InsertarInicio(new Carro(marca, modelo, anioLanzamiento));

            //}
            //intentoListas1.ImprimirLista();


            //intentoListas1.InsertarInicio(new Carro())


            intentoListas1.InsertarInicio(new Carro("Chevy", 2008, 2005));
            intentoListas1.InsertarInicio(new Carro("Chevy", 2001, 2005));
            intentoListas1.InsertarInicio(new Carro("Tsuru", 2010, 2009));
            intentoListas1.InsertarInicio(new Carro("Kia", 2016, 2015));

            //  intentoListas1.Busqueda("Chevy");
            //intentoListas1.Ordenar();

            //Console.WriteLine("Aqui ya deberia de estar ordenado ");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("-------------------------------");
            //intentoListas1.MostrarTodo();
            intentoListas1.ImprimirLista();


            //BUSCAR QUE NO SIRVE
            Console.WriteLine("Ingrese la marca de auto que quieras buscar");
            string buscar= Console.ReadLine();

            intentoListas1.Busqueda(buscar);

            // intentoListas1.ImprimirLista();

        }
    }
}