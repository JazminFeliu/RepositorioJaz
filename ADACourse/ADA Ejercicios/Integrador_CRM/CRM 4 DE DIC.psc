//Integrador de pseudocódigo
//Crear un sistema que permita controlar el stock de productos en una tienda.
//Condiciones:
//El nro. máximo de productos es 30.
//El sistema debe poder mostrar la cantidad total de artículos, el stock de un producto determinado, los detalles de un producto elegido, el precio.
//Además, debe permitir ingresar nuevos productos (máximo 30) y actualizar el stock de productos existentes.
//Debe existir un menú que ofrezca las distintas opciones del programa.

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

Funcion stockArticulosCargados = ingresarArticulo(Articulos, DetalleArticulos, stockArticulosCargados) 
	posicion = 1;	
	cantArticulosNuevos = 0; 
	cargaNueva ="S";
	
	Mientras cargaNueva = "S" Hacer
				
			Si stockArticulosCargados < 3 Entonces
				Si posicion <= 3 Entonces
					Si Articulos[posicion,1] == 0 Entonces
						
						Borrar Pantalla;
						Escribir "Ingrese el ID del Articulo nuevo:";
						Leer Articulos[posicion, 1];
						cantArticulosNuevos = cantArticulosNuevos + 1;
						
						Escribir "Ingrese el Detalle del Articulo: ",Articulos[posicion,1];
						Leer DetalleArticulos[posicion];
						
						Escribir "Ingrese el Precio del Articulo: ",Articulos[posicion,1];
						Leer Articulos[posicion,2];
						
						Escribir "Ingrese la Cantidad de Articulos: ",Articulos[posicion,1];
						Leer Articulos[posicion,3];
						
						Escribir "Desea realizar una carga nueva?(S/N)";
						Leer cargaNueva;				
						
					FinSi
					posicion = posicion + 1;
				SiNo
					cargaNueva = "N";
					
					Borrar Pantalla;
					Escribir "No se pueden cargar mas articulos, no hay mas lugar en el vector";
					Escribir "Pulse una tecla para continuar";
					Esperar Tecla; 
					
				FinSi		
			SiNo
				cargaNueva = "N";
				
				Escribir "No se pueden ingresar mas articulos. El stock esta lleno:";
				
				Para cont = 1 hasta 3 Hacer
					Escribir "ID de Articulo en la posicion ",cont," : ",Articulos[cont,1];	
					Escribir "Detalle: ",DetalleArticulos[cont];
					Escribir "Precio $ ",Articulos[cont,2];
					Escribir "Cantidad :",Articulos[cont,3]," unidades";
				FinPara
				Escribir "Pulse una tecla para continuar";
				Esperar Tecla;
			FinSi
	FinMientras
	
	stockArticulosCargados = stockArticulosCargados + cantArticulosNuevos;
	
	Borrar Pantalla;	
	Escribir "Se han ingresado ",cantArticulosNuevos," articulos nuevos";
	Escribir "Pulse una tecla para continuar";
	Esperar Tecla; 

FinFuncion

Funcion verArticulo(Articulos, DetalleArticulos)	
	Escribir "Ingrese ID del articulo que quiere ver: (1-30) ";
	Leer IdArt;
	Mientras IdArt<1 o IdArt>30 Hacer
		Escribir "Ingrese ID del articulo que quiere ver: (1-30) ";
		Leer IdArt;
	Fin Mientras
		Para i<-1 Hasta 30 Hacer 
			Si IdArt = Articulos[i,1] Entonces
			Escribir "ID de Articulo en la posicion ",i," : ",Articulos[i,1];	
			Escribir "Detalle: ",DetalleArticulos[i];
			Escribir "Precio $ ",Articulos[i,2];
			Escribir "Cantidad :",Articulos[i,3]," unidades";
			FinSi
		Fin Para
	
	
FinFuncion

Funcion verInventario()
	
FinFuncion

Funcion actualizarInventario()
	
FinFuncion

Funcion salir()
	
FinFuncion



Algoritmo CRM
	Dimension Articulos[3,3]; 			//Matriz que contiene el identificador de cada Articulo(ID), precio, stock. Todos los datos son tipo NUMERICO
	Dimension DetalleArticulos[3]; 	//Vector que contiene el detalle de cada articulo. Los datos son tipo TEXTO
	
	Definir opcionElegida Como Entero;
	stockArticulosCargados = 0;
	idArticulo = 1;
	
	opcionElegida = elegirOpcion();
	
	Mientras opcionElegida <> 4 Hacer
		Borrar Pantalla;
		
		Segun opcionElegida Hacer
			0: 
				stockArticulosCargados = ingresarArticulo(Articulos, DetalleArticulos, stockArticulosCargados);
			1:
				verArticulo(Articulos, DetalleArticulos);
			
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

