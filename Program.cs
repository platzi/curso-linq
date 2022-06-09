LinqQueries queries = new LinqQueries();

//Toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());

//Libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());

//Libros que tienen mas de 250 pags y tienen en el titulo la palabra in action
//ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//Todos los libros tienen Status
//Console.WriteLine($" Todos los libros tienen status? - {queries.TodosLosLibrosTienenStatus()}");

//Si algun libro fue publicado en 2005
//Console.WriteLine($" Algun libro fue publicado en 2005? - {queries.SiAlgunLibroFuePublicado2005()}");


//Libros de python
//ImprimirValores(queries.LibrosdePython());

//libros de Java ordenados por nombre
//ImprimirValores(queries.LibrosdeJavaPorNombreAscendente());

//libros que tienen mas de 450 paginas ordernados por cantidad de paginas
//ImprimirValores(queries.Librosmasde450pagOrdernadorPorNumPagDescendente());

//los 3  libros de Java publicados recientemente
//ImprimirValores(queries.TresPrimerosLibrosJavaOrdenadosPorFecha());

//tercer y caurto libro con mas de 400 paginas
ImprimirValores(queries.TerceryCuartoLibroDeMas400Pag());


void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}