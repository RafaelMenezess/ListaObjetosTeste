namespace ListaObjetos;

public class Eletronicos
{

    public string Id { get; set; }
    public string Name { get; set; }
    public Data Data { get; set; }
}

public class Data
{
    public string Color { get; set; }
    public string Capacity { get; set; }
}