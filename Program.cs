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
//ImprimirValores(queries.TerceryCuartoLibroDeMas400Pag());

//tres primeros libros filtrados con Select
//ImprimirValores(queries.TresPrimeroLibrosDeLaCollecion());

//cantidad de libros que tienen entre 200 y 500 paginas
//Console.WriteLine($"Cantidad de libros que tiene entre 200 y 500 pag. {queries.CantidadDeLibrosEntre200y500Pag()}");

// fecha de publicacion menor de todos los libros
//Console.WriteLine($"Fecha de publicacion menor: {queries.FechaDePublicacionMenor()}");

//Numero de paginas del libro con mayor Numero de paginas
//Console.WriteLine($"El libro con mayor numero de paginas tiene: {queries.NumeroDePagLibroMayor()} paginas. ");

//Libro con menor numero de paginas
//var libroMenorPag = queries.LibroConMenorNumeroDePaginas();
//Console.WriteLine($"{libroMenorPag.Title} - {libroMenorPag.PageCount}");

//Libro con fecha publicacion mas reciente
//var libroFechaPubReciente = queries.LibroConFechaPublicacionMasReciente();
//Console.WriteLine($"{libroFechaPubReciente.Title} - {libroFechaPubReciente.PublishedDate.ToShortDateString()}");

//suma de paginas de libros entre 0 y 500
//Console.WriteLine($"Suma total de paginas {queries.SumaDeTodasLasPaginasLibrosEntre0y500()}");

//Libros publicados despues del 2015
//Console.WriteLine(queries.TitulosDeLibrosDespuesDel2015Concatenados());

//el promedio de caracteres del los titulos de los libros
//Console.WriteLine($"promedio caracteres de los titulos: {queries.PromedioCaracteresTitulo()}");

//Libros publicados a partir del 2000 agrupados por ano
//ImprimirGrupo(queries.LibrosDespuesdel2000AgrupadosporAno());

//Diccionario de libros agrupados por primera letra del titulo
//var diccionarioLookup = queries.DiccionariosDeLibrosPorLetra();
//ImprimirDiccionario(diccionarioLookup, 'Z');

// libros filtradaor con la clausula join 
ImprimirValores(queries.LibrosDespuesdel2005conmasde500Pags());


void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach(var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
   Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   foreach(var item in ListadeLibros[letra])
   {
         Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
   }
}