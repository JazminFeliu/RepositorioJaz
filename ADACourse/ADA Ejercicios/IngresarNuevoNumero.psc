Funcion cargarNuevo()
	
	Dimension ArregloNumeros[3];
	
	Escribir "Es la primera carga de datos que realiza?(S/N)";
	Leer esPrimeraCarga;
	Borrar Pantalla;
	
	Si esPrimeraCarga == "S" Entonces
		
		lugaresDisponibles = 3;
		
		Escribir "Ingrese la cantidad de numeros a cargar:";
		Leer cantidadNueva;
		
		Si lugaresDisponibles >= cantidadNueva Entonces
			EsCargaNueva = Verdadero;
			posicion = 1;
		SiNo
			Borrar Pantalla;
			Escribir "Quedan ",lugaresDisponibles," lugares disponibles para ingresar nuevos números";
			Escribir "Por favor ingrese otra opcion";
			EsCargaNueva = Falso;
		FinSi		
		
	SiNo
		Para cont=2 Hasta 3 Hacer
			Si ArregloNumeros[cont] = 0 Entonces
				lugaresDisponibles = 3-cont;
				posicion = cont;
				
				Escribir "Ingrese la cantidad de numeros a cargar:";
				Leer cantidadNueva;
				
				Si lugaresDisponibles >= cantidadNueva Entonces
					EsCargaNueva = Verdadero;
					posicion = 1;
				SiNo
					Borrar Pantalla;
					Escribir "Quedan ",lugaresDisponibles," lugares disponibles para ingresar nuevos números";
					Escribir "Por favor ingrese otra opcion";
					EsCargaNueva = Falso;
				FinSi	
				
			FinSi
		FinPara
		
	FinSi
	
	
	Mientras EsCargaNueva Hacer
				
		Si posicion <= cantidadNueva Entonces
			Escribir "Ingrese el numero a cargar";
			Leer ArregloNumeros[posicion];
			posicion = posicion + 1;
			
		SiNo
				Escribir "Carga Finalizada. Presione una tecla para continuar";
				EsCargaNueva = Falso;
				Esperar Tecla;
				Borrar Pantalla;
			
		Finsi;
	FinMientras
	
	posicionActualizada = posicion;
	lugaresDisponibles = 3 - cantidadNueva;		
	
FinFuncion

Algoritmo CargarNumero
	opcionMenu = 1;	
	
	Mientras opcionMenu <> 0 Hacer
		Escribir "Ingrese una opcion: 1-Cargar nuevo numero / 0-Salir)";
		Leer opcionMenu;
		
		Si opcionMenu = 1 Entonces
			Borrar Pantalla;
			cargarNuevo();
			
		SiNo
			Borrar Pantalla;
			Escribir"Gracias por utilizar el servicio";
		FinSi
		
	FinMientras	
	
FinAlgoritmo
 