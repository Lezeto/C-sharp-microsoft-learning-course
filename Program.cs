string[] identificadores = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
foreach(string identificador in identificadores){
    if (identificador.StartsWith("B"))
    {
        Console.WriteLine(identificador);
    }
}