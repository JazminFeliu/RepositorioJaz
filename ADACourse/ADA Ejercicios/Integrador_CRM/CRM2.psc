
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

Funcion ingresarArticulo(Articulos, DetalleArticulos) 	
	
	
	Escribir "Ingrese la cantidad de artículos que se cargarán:";
	Leer cantidadArticulosNuevos;
	
	Si Entonces	
		hayLugarenInventario = Verdadero;
		EsCargaNueva = Verdadero;		
		
	SiNo
		hayLugarenInventario = Falso;
		EsCargaNueva = Falso;
		Escribir "El Inventario no dispone de lugar para cargar esa cantidad de articulos.";
		Escribir "Por favor, ingrese una opción válida";
	FinSi
	
	
	Borrar Pantalla;	
	
	Mientras EsCargaNueva Hacer		
		
		Para cont = 1 Hasta cantidadArticulosNuevos Hacer
			
			Escribir "Ingrese el codigo del artículo: ";
			Leer Articulos[cont,1];
			
			Escribir "Ingrese el detalle del articulo ",Articulos[cont,1],":";
			Leer DetalleArticulos[cont];
			
			Escribir "Ingrese el precio del/la ",DetalleArticulos[cont],":";
			Leer Articulos[cont,2];
			
			Escribir "Ingrese el stock de ",DetalleArticulos[cont],":";
			Leer Articulos[cont,3];			
			
		FinPara
		
		Escribir "Ha finalizado la carga de los ",cantidadArticulos," artículos."
		EsCargaNueva = Falso
		cantidadArticulosEnStock = cantidadArticulosEnStock + cantidadArticulosNuevos;
		
	FinMientras
		
	Escribir " 	Presione una tecla para volver al Menu";
	Esperar Tecla;	
	
FinFuncion

Funcion verArticulo(Articulos, DetalleArticulos)
	
	Escribir "Ingrese el codigo de artículo que desea ver:";
	Leer codigoArticulo;
	Borrar Pantalla;
	
	Escribir "	Detalle del Articulo";
	Escribir "	ID Nro.: ",Articulos[codigoArticulo,1];
	Escribir "	Detalle: ",DetalleArticulos[codigoArticulo];
	Escribir "	Precio: $ ",Articulos[codigoArticulo,2];
	Escribir "	Stock: ",Articulos[codigoArticulo,3];
	
	Escribir " 	Presione una tecla para volver al Menu";
	Esperar Tecla;	
	
FinFuncion

Funcion verInventario(Articulos, DetalleArticulos)
	
	Escribir "	Inventario de artículos";
	
	Para cont = 1 Hasta 30 Hacer
		Escribir "	Detalle del Articulo";
		Escribir "	ID Nro.: ",Articulos[codigoArticulo,1];
		Escribir "	Detalle: ",DetalleArticulos[codigoArticulo];
		Escribir "	Precio: $ ",Articulos[codigoArticulo,2];
		Escribir "	Stock: ",Articulos[codigoArticulo,3];
	FinPara
	
FinFuncion

Funcion actualizarInventario()
	
FinFuncion

Funcion salir()
	
FinFuncion

	

Algoritmo CRM	
	
	Dimension Articulos[30,3]; 			//Matriz que contiene el identificador de cada Articulo(ID), precio, stock. Todos los datos son tipo NUMERICO
	Dimension DetalleArticulos[30]; 	//Vector que contiene el detalle de cada articulo. Los datos son tipo TEXTO
	
	Definir opcionElegida Como Entero;
		
	cantidadArticulosEnStock = 3;
	
	opcionElegida = elegirOpcion();
	
	Mientras opcionElegida <> 4 Hacer
		Borrar Pantalla;
		
		Segun opcionElegida Hacer
			0: 
				ingresarArticulo(Articulos, DetalleArticulos);
			1:
				verArticulo(Articulos, DetalleArticulos);
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
