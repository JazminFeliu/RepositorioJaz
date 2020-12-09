Funcion MostrarLista(losNumeros, tamanio)
	Para cont = 1 hasta tamanio Hacer
		
		Escribir losNumeros[cont];
		
	FinPara
	
FinFuncion
Algoritmo OrdenamientoBurbuja
	tamanio = 3;
	Dimension losNumeros[tamanio];
	
	//Cargar mi lista
	Para cont = 1 hasta tamanio Hacer
		Escribir "Ingrese el nro. ", cont;
		Leer losNumeros[cont];
	FinPara
	
	//Mostrar lista desordenada
	MostrarLista(losNumeros, tamanio);
	
	//Ordeno mi lista
	//Logica: si nroActual > nroSiguiente, cambiar de lugar
	
	Para contador = 1 Hasta tamanio-1 Hacer
		Para nroActual = 1 Hasta tamanio-1 Hacer
			Si losNumeros[nroActual] > losNumeros[nroActual + 1] Entonces
				
				variableAuxiliar = losNumeros[nroActual];
				losNumeros[nroActual] = losNumeros[nroActual + 1];
				losNumeros[nroActual + 1 ] = variableAuxiliar;
			FinSi
		FinPara
	FinPara
	
	//Mostrar mi lista
	MostrarLista(losNumeros, tamanio);
	
FinAlgoritmo
