
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

Funcion ingresarArticulo() 
	
FinFuncion

Funcion verArticulo()
	
FinFuncion

Funcion verInventario()
	
FinFuncion

Funcion actualizarInventario()
	
FinFuncion

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
				ingresarArticulo();
			1:
				verArticulo();
			2:
				verInventario();
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
