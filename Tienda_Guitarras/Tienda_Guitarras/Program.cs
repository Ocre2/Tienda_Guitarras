using Tienda_Guitarras;

 EstadisticasGuitarras estadisticas = new EstadisticasGuitarras();

bool salir = false;
while (!salir)
{
    Console.WriteLine("=== Sistema de Gestión de Guitarras ===");
    Console.WriteLine("1. Agregar guitarra al inventario");
    Console.WriteLine("2. Realizar mantenimiento a guitarra acústica");
    Console.WriteLine("3. Vender guitarra eléctrica");
    Console.WriteLine("4. Mostrar estadísticas del inventario");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            AgregarGuitarra(estadisticas);
            break;
        case "2":
            RealizarMantenimiento(estadisticas);
            break;
        case "3":
            VenderGuitarra(estadisticas);
            break;
        case "4":
            MostrarEstadisticas(estadisticas);
            break;
        case "5":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }

    Console.WriteLine();
}
    

    static void AgregarGuitarra(EstadisticasGuitarras estadisticas)
{
    Console.WriteLine("=== Agregar guitarra al inventario ===");
    Console.Write("Ingrese la marca: ");
    string marca = Console.ReadLine();
    Console.Write("Ingrese el modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Ingrese el tipo de cuerda: ");
    string tipoCuerda = Console.ReadLine();
    Console.Write("Ingrese la cantidad en inventario: ");
    int cantidadInventario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Seleccione el tipo de guitarra:");
    Console.WriteLine("1. Guitarra acústica");
    Console.WriteLine("2. Guitarra eléctrica");
    Console.Write("Ingrese una opción: ");
    string tipoGuitarra = Console.ReadLine();

    switch (tipoGuitarra)
    {
        case "1":
            Console.Write("Ingrese la forma del cuerpo: ");
            string formaCuerpo = Console.ReadLine();
            GuitarraAcustica guitarraAcustica = new GuitarraAcustica(marca, modelo, tipoCuerda, cantidadInventario, formaCuerpo);
            estadisticas.AgregarGuitarra(guitarraAcustica);
            Console.WriteLine("Se ha agregado la guitarra acústica al inventario.");
            break;
        case "2":
            Console.Write("Ingrese el número de cuerdas: ");
            int numeroCuerdas = Convert.ToInt32(Console.ReadLine());
            GuitarraElectrica guitarraElectrica = new GuitarraElectrica(marca, modelo, tipoCuerda, cantidadInventario, numeroCuerdas);
            estadisticas.AgregarGuitarra(guitarraElectrica);
            Console.WriteLine("Se ha agregado la guitarra eléctrica al inventario.");
            break;
        default:
            Console.WriteLine("Opción inválida. No se ha agregado la guitarra al inventario.");
            break;
    }
}

static void RealizarMantenimiento(EstadisticasGuitarras estadisticas)
{
    Console.WriteLine("=== Realizar mantenimiento a guitarra acústica ===");
    Console.Write("Ingrese la marca de la guitarra acústica: ");
    string marca = Console.ReadLine();
    Console.Write("Ingrese el modelo de la guitarra acústica: ");
    string modelo = Console.ReadLine();

    List<Guitarra> list = estadisticas.listaGuitarras;
    for (int i = 0; i < list.Count; i++)
    {
        Guitarra guitarra = list[i];
        if (guitarra is GuitarraAcustica && guitarra.ObtenerMarca() == marca && guitarra.ObtenerModelo() == modelo)
        {
            GuitarraAcustica guitarraAcustica = (GuitarraAcustica)guitarra;
            guitarraAcustica.RealizarMantenimiento();
            return;
        }
    }

    Console.WriteLine("No se encontró la guitarra acústica especificada en el inventario.");
}

static void VenderGuitarra(EstadisticasGuitarras estadisticas)
{
    Console.WriteLine("=== Vender guitarra eléctrica ===");
    Console.Write("Ingrese la marca de la guitarra eléctrica: ");
    string marca = Console.ReadLine();
    Console.Write("Ingrese el modelo de la guitarra eléctrica: ");
    string modelo = Console.ReadLine();

    foreach (Guitarra guitarra in estadisticas.listaGuitarras)
    {
        if (guitarra is GuitarraElectrica && guitarra.ObtenerMarca() == marca && guitarra.ObtenerModelo() == modelo)
        {
            GuitarraElectrica guitarraElectrica = (GuitarraElectrica)guitarra;
            guitarraElectrica.VenderGuitarra();
            return;
        }
    }

    Console.WriteLine("No se encontró la guitarra eléctrica especificada en el inventario.");
}

static void MostrarEstadisticas(EstadisticasGuitarras estadisticas)
{
    Console.WriteLine("=== Estadísticas del inventario ===");
    Console.WriteLine("Cantidad total de guitarras en el inventario: " + estadisticas.ObtenerCantidadTotalGuitarras());
    Console.WriteLine("Cantidad de guitarras acústicas en el inventario: " + estadisticas.ObtenerCantidadGuitarrasAcusticas());
    Console.WriteLine("Cantidad de guitarras eléctricas en el inventario: " + estadisticas.ObtenerCantidadGuitarrasElectricas());
}


