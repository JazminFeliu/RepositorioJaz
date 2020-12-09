
Funcion opcion = elegirOpcion() // Menu principal de opciones
	Borrar Pantalla;
	Escribir "Menu principal ";
	Escribir "Ingrese una opción: ";
	Escribir "		0 - Ingresar un articulo";
	Escribir "		1 - Ver articulo";
	Escribir "		2 - Ver Inventario"; 
	Escribir "		3 - Actualizar Inventario";
	Escribir "		4 - Salir"
	Leer opcion;
	
FinFuncion

//OPCION # 0 CARGA DE ARTICULOS
Funcion ingresarArticulo(Articulos, DetalleArticulos) 
	Borrar Pantalla;
	Escribir "Ingrese la cantidad de artículos a cargar:";
	Leer cantidadArticulos;
	
	Para cont = 1 Hasta cantidadArticulos Hacer
		// Nº ID
		Escribir "Ingrese el Nº de código: ";
		Leer Articulos[cont,1];
		// Nombre o detalle
		Escribir "Ingrese el detalle / descripción:";
		Leer DetalleArticulos[cont];
		// $
		Escribir "Ingrese precio por unidad:";
		Leer Articulos[cont,2];
		// Cantidad
		Escribir "Ingrese stock:";
		Leer Articulos[cont,3];
		//acumuladorStock = acumuladorStock + Articulos[cont,3];
	FinPara

	Escribir "Carga finalizada de ",cantidadArticulos," artículos."
	Escribir " 	Presione una tecla para volver al Menu";
	Esperar Tecla;	
FinFuncion

//OPCION # 1 MOSTRAR UN SOLO ARTICULO
Funcion verArticulo()
	
FinFuncion


//OPCION # 2 INVENTARIO TOTAL
Funcion verInventario(Articulos, DetalleArticulos)
	Escribir "Inventario";
	Borrar Pantalla;
	Escribir "Ingrese la cantidad de artículos a listar:";
	//Se puede indicar 30 como MAXIMO, o bien un Nº < a 30.
	Leer listarArticulos;
	
	Para cont = 1 Hasta listarArticulos Hacer
		Escribir "Articulo nº ", Articulos[cont,1] ," - " DetalleArticulos[cont], " - Precio $ ", Articulos[cont,2], " - Stock  ", Articulos[cont,3], " unidades" ;
	FinPara
	
	Escribir " 	Presione una tecla para volver al Menu";
	Esperar Tecla;	
FinFuncion


//OPCION # 3 COMIENZO ACTUALIZACION INVENTARIO
Funcion actualizarInventario()
	
FinFuncion


// OPCION # 4 SALIR
Funcion salir()
	
FinFuncion

	

Algoritmo CRM
	Dimension Articulos[30,3]; 			//Matriz que contiene el identificador de cada Articulo(ID), precio, stock. Todos los datos son tipo NUMERICO
	Dimension DetalleArticulos[30]; 	//Vector que contiene el detalle de cada articulo. Los datos son tipo TEXTO
	
	Definir opcionElegida Como Entero;
	
	opcionElegida = elegirOpcion();

	Mientras opcionElegida <> 4 Hacer
		Borrar Pantalla;
		
		Segun opcionElegida Hacer
			0: 
				ingresarArticulo(Articulos, DetalleArticulos);
			1:
				verArticulo();
			2:
				verInventario(Articulos, DetalleArticulos);
			3:
				actualizarInventario();
			4:
				salir();
				
			De Otro Modo:
				Borrar Pantalla;
				Escribir "	Opcion incorrecta";
				Escribir " 	Presione una tecla para volver al Menu";
				Esperar Tecla;
				
		FinSegun
		
		opcionElegida = elegirOpcion();
		
	FinMientras
	
FinAlgoritmo
