// Menu principal de opciones
Funcion opcion = elegirOpcion() 
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

// Funcion para Ingresar Articulos al Inventario
Funcion stockArticulosCargados = ingresarArticulo(Articulos, DetalleArticulos, stockArticulosCargados) 
	
	posicion = stockArticulosCargados + 1;	
	cantArticulosNuevos = 0; 
	cargaNueva ="S";
	
	Mientras cargaNueva = "S" Hacer
		
		Si stockArticulosCargados < 3 Entonces
			Si posicion <= 3 Entonces
				Borrar Pantalla;
				Escribir "Ingrese el ID del Articulo nuevo:";
				Leer Articulos[posicion, 1];
				
				Escribir "Ingrese el Detalle del Articulo: ",Articulos[posicion,1];
				Leer DetalleArticulos[posicion];
				
				Escribir "Ingrese el Precio del Articulo: ",Articulos[posicion,1];
				Leer Articulos[posicion,2];
				
				Escribir "Ingrese la Cantidad de Articulos: ",Articulos[posicion,1];
				Leer Articulos[posicion,3];
				
				Escribir "Desea realizar una carga nueva?(S/N)";
				Leer cargaNueva;		
				
				posicion = posicion + 1;
				cantArticulosNuevos = cantArticulosNuevos + 1;
			SiNo
				cargaNueva = "N";
				
				Borrar Pantalla;
				Escribir "No se pueden cargar mas articulos, no hay mas lugar en el vector";
				Escribir "";	
				Escribir "Pulse una tecla para volver al Menú Principal";
				Esperar Tecla; 
				
			FinSi		
		SiNo
			cargaNueva = "N";
			
			Escribir "No se pueden ingresar mas articulos. El stock esta lleno.";
			Escribir "";			
			Escribir "Pulse una tecla para volver al Menu Principal";
			Esperar Tecla;
		FinSi
	FinMientras
	
	stockArticulosCargados = stockArticulosCargados + cantArticulosNuevos;
	
	Borrar Pantalla;	
	Escribir "Cantidad de artículos ingresados:  ",cantArticulosNuevos," articulos nuevos";
	Escribir "";	
	Escribir "Pulse una tecla para volver al Menu Principal";
	Esperar Tecla; 
	
FinFuncion

// Funcion para Ver Articulos del Inventario
Funcion verArticulo(Articulos, DetalleArticulos, stockArticulosCargados)
	
	mostrarNuevo = "S";		
	cantArticulosVistos = 0;
	
	Mientras mostrarNuevo = "S" Hacer
		
		posicion = 1;
		estaBuscando = Verdadero;
		
		Escribir "Ingrese el ID del Articulo que desea ver:";
		Leer idArticulo;		
		
		Mientras posicion <= stockArticulosCargados y estaBuscando Hacer
			
			Si idArticulo == Articulos[posicion,1] Entonces
				
				Borrar Pantalla;
				
				Escribir "ID de Articulo en la posicion ",posicion," : ",Articulos[posicion,1];	
				Escribir "Detalle: ",DetalleArticulos[posicion];
				Escribir "Precio $ ",Articulos[posicion,2];
				Escribir "Cantidad  ",Articulos[posicion,3]," unidades";
				
				estaBuscando = Falso;
				cantArticulosVistos = cantArticulosVistos + 1;
				
				Escribir "";	
				Escribir "Pulse una tecla para continuar";
				Esperar Tecla;
				Borrar Pantalla;
				
			SiNo
				posicion = posicion + 1;
			FinSi
			
		FinMientras
		
		
		Si estaBuscando Entonces
			Escribir "No se ha encontrado en el Inventario el articulo solicitado.";
			
		SiNo
			Escribir "Se mostraron ",cantArticulosVistos," artículo/s del Inventario";
		FinSi
		
		Escribir "";	
		Escribir "Desea ver otro articulo?(S/N)";
		Leer mostrarNuevo;
		
		
	FinMientras
	
	Escribir "";	
	Escribir "Pulse Una tecla para volver al Menu Principal";
	Esperar Tecla;
	Borrar Pantalla;
	
FinFuncion

// Funcion para ver el Inventario
Funcion verInventario(Articulos, DetalleArticulos, stockArticulosCargados)
	
	Si stockArticulosCargados > 0 Entonces
		
		Escribir "El Inventario tiene ",stockArticulosCargados," articulos cargados en total";
		Escribir"";
		
		Para posicion = 1 hasta stockArticulosCargados Hacer
			Escribir "ID de Articulo en la posicion ",posicion," : ",Articulos[posicion,1];	
			Escribir "Detalle: ",DetalleArticulos[posicion];
			Escribir "Precio $ ",Articulos[posicion,2];
			Escribir "Cantidad  ",Articulos[posicion,3]," unidades";
			Escribir "";
		FinPara
		
	SiNo
		Escribir "El inventario no tiene articulos cargados todavía";
	FinSi
	
	Escribir"";
	Escribir "Pulse una tecla para volver al Menu Principal";
	Esperar Tecla;
	
FinFuncion

// Funcion para actualizar algun Articulo del Inventario
Funcion actualizarInventario(Articulos, DetalleArticulos, stockArticulosCargados)
	
	actualizacionesRealizadas = 0;
	actualizacionNueva = "S";
	
	Mientras actualizacionNueva = "S" Hacer
		
		Escribir "Ingrese el ID del artículo que quiere actualizar:";
		Leer idArticuloParaActualizar;
		
		Escribir "Ingrese la opcion a actualizar:";
		Escribir "	Detalle del Artículo: 	1";
		Escribir "	Precio: 		2";
		Escribir "	Cantidad: 		3";
		Leer actualizacion;
		
		estaBuscando = Verdadero;
		posicion = 1;
		
		Mientras estaBuscando y posicion <= stockArticulosCargados Hacer
			Si Articulos[posicion,1] == idArticuloParaActualizar Entonces
				Segun actualizacion Hacer
					1:
						Escribir "El detalle actual del articulo es: ",DetalleArticulos[posicion];
						Escribir "Ingrese el nuevo detalle del artículo ",idArticuloParaActualizar;
						Leer DetalleArticulos[posicion];
					2:
						Escribir "El precio actual del artículo es $ ",Articulos[posicion,2];
						Escribir "Ingrese el nuevo precio del artículo ",idArticuloParaActualizar;
						Leer Articulos[posicion,2];
					3: 
						Escribir "La cantidad actual del artículo es ",Articulos[posicion,3]," unidades";
						Escribir "Ingrese la nueva cantidad del articulo ",idArticuloParaActualizar;
						Leer Articulos[posicion, 3];
						
					De Otro Modo:
						Escribir "Opcion incorrecta";
						Escribir " 	Presione una tecla para volver al Menu";
						Esperar Tecla;
						
				FinSegun
				
				estaBuscando = Falso;
				actualizacionesRealizadas = actualizacionesRealizadas + 1;
				
			SiNo
				posicion = posicion + 1;
			FinSi			
			
		FinMientras
		
		Borrar Pantalla;
		
		Si estaBuscando Entonces
			
			Escribir "El articulo que desea actualizar no se encuentra en el Inventario.";
			
			
		SiNo
			Escribir "Cantidad de actualizaciones: ",actualizacionesRealizadas;
			
		FinSi
		
		Escribir "Desea realizar una actualización nueva? (S/N):";
		Leer actualizacionNueva;
		
	FinMientras
FinFuncion


Algoritmo CRM
	Dimension Articulos[3,3]; 			//Matriz que contiene el identificador de cada Articulo(ID), precio, stock. Todos los datos son tipo NUMERICO
	Dimension DetalleArticulos[3]; 	//Vector que contiene el detalle de cada articulo. Los datos son tipo TEXTO
	
	Definir opcionElegida Como Entero;
	stockArticulosCargados = 0;
	
	opcionElegida = elegirOpcion();
	
	Mientras opcionElegida  <> 4  Hacer
		Borrar Pantalla;
		
		Segun opcionElegida Hacer
			0: 
				stockArticulosCargados = ingresarArticulo(Articulos, DetalleArticulos, stockArticulosCargados);
			1:
				verArticulo(Articulos, DetalleArticulos,stockArticulosCargados);
			2:
				verInventario(Articulos, DetalleArticulos, stockArticulosCargados);
			3:
				actualizarInventario(Articulos, DetalleArticulos, stockArticulosCargados);
			4:
				
			De Otro Modo:
				Borrar Pantalla;
				Escribir "	Opcion incorrecta";
				Escribir " 	Presione una tecla para volver al Menu Principal";
				Esperar Tecla;
				
		FinSegun
		
		opcionElegida = elegirOpcion();
		
	FinMientras
	
	Borrar Pantalla;
	Escribir "Gracias por utilizar el CRM";
	Escribir "Pulse una tecla para finalizar";
	Esperar Tecla;
	
FinAlgoritmo

