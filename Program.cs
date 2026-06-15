
Console.WriteLine("=== Cálculo de Descuento para Clientes ===");
Console.WriteLine("---------------------------------------------");

string tipoCliente;
double compra, descuento;

Console.Write("Ingrese tipo de cliente (VIP o NORMAL): ");
tipoCliente = Console.ReadLine();

Console.Write("Ingrese monto de compra: ");
compra = double.Parse(Console.ReadLine());

if (tipoCliente.ToUpper() == "VIP")
{
    if (compra > 500)
    {
        descuento = compra * 0.20;
    }
    else
    {
        descuento = compra * 0.10;
    }
}
else
{
    if (compra > 500)
    {
        descuento = compra * 0.05;
    }
    else
    {
        descuento = 0;
    }
}

Console.WriteLine($"Descuento: S/{descuento}" );
Console.WriteLine("Total a pagar: S/" + (compra - descuento));

Console.ReadKey();