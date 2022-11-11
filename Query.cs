public class Query
{
    public Saludo GetSaludo() =>
        new Saludo
        {
            Hola = "mundo"
        };

    public Autor GetAutor()=>
        new Autor{
            Edad=20,
            Nombre="Ale",
            Sexo=Sexo.Femenino
        };

    public Libro GetLibro()=>
        new Libro{
            Titulo="ABC",
            Autor= new Autor{
                Edad=20,
                Nombre="Ale",
                Sexo=Sexo.Femenino
            }
        };
}
