//completar las funciones
//agregar mas opciones al menu
//sean creativas
//ordenar vectores!!! 


Funcion cuenta = contar(minimo, maximo)
	
	Para contador=minimo hasta maximo Hacer
		cuenta = cuenta + 1;
				
	FinPara
	
FinFuncion

Funcion mostrarTabla(numero)
	
	Para contador = 1 Hasta numero Hacer
		Escribir contador," x ",numero,"= ",contador*numero; 
	FinPara
FinFuncion

Algoritmo repasoMultiuso
	
	opcionElegida = 1;
	
	Mientras opcionElegida <> 0 Hacer
		Escribir "Elija la opcion: ";
		Escribir"1-Contar del 1 al 10, 2-Tabla del dos";
		Escribir "0 al salir";
		
		Leer opcionElegida;
		
		Segun opcionElegida hacer
			1: cuenta = contar(1,10);
			2: mostrarTabla(2);	
			deotromodo: 
				Escribir "Opcion invalida";
		FinSegun
	FinMientras
	
FinAlgoritmo
