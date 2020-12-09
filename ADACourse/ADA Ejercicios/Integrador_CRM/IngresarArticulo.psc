Funcion stockArticulosCargados = ingresar(Articulos, stockArticulosCargados) 
	
	posicion = 1;	
	cantArticulosNuevos = 0; 
	cargaNueva ="S";
	
	Mientras cargaNueva = "S" Hacer
		Si posicion < 4 Entonces
			Si Articulos[posicion] = 0 Entonces
				
				Borrar Pantalla;
				Escribir "Ingrese el articulo nuevo:";
				Leer Articulos[posicion];
				cantArticulosNuevos = cantArticulosNuevos + 1;
				
				Escribir "Desea realizar una carga nueva?(S/N)";
				Leer cargaNueva;				
				
			FinSi
			posicion = posicion + 1;
		SiNo
			Borrar Pantalla;
			Escribir "No se pueden cargar mas articulos, no hay mas lugar en el vector";
			cargaNueva = "N";
		FinSi		
		
	FinMientras
	
	Borrar Pantalla;	
	Escribir "Se han ingresado ",cantArticulosNuevos," articulos nuevos";
	
	stockArticulosCargados = stockArticulosCargados + cantArticulosNuevos;
	Escribir "El stock tiene ",stockArticulosCargados," articulos cargados en total";
	Escribir "Presione una tecla para continuar";
	Esperar Tecla;
	
FinFuncion


Algoritmo ingresarArticulo
	
	Dimension Articulos[3];
	opcionMenu = 1;
	stockArticulosCargados = 0;
	
	Mientras opcionMenu <> 0 Hacer
		Borrar Pantalla; 
		Escribir "	Ingrese una opcion:";
		Escribir "	1- Ingresar articulo";
		Escribir "	0-Salir";
		Leer opcionMenu;
		
		Si opcionMenu = 1 Entonces
			Si stockArticulosCargados < 3 Entonces
				stockArticulosCargados = ingresar(Articulos, stockArticulosCargados);
			SiNo
				Escribir "No se pueden ingresar mas articulos. El stock esta lleno:";
				Para cont = 1 hasta 3 Hacer
					Escribir "Articulo en la posicion ",cont," : ",Articulos[cont];					
				FinPara
				Escribir "Pulse una tecla para continuar";
				Esperar Tecla;
			FinSi			
			
		SiNo
			Escribir "Gracias por utilizar el servicio";
			Escribir "Pulse una tecla para continuar";
				Esperar Tecla
			
		FinSi
	FinMientras	
	
	
FinAlgoritmo
