Funcion cargarVector(numeros Por Referencia, tamanio) // por referencia le estoy dando los valores para que los modifique. Esto significa que le estoy pasando el puntero, y tiene funcion colateral. 
	Para contador = 1 Hasta tamanio Hacer
		
		numeros[contador] = azar(9);
		
	FinPara
	
FinFuncion
Funcion darVueltaVector(numeros, tamanio)
	
	contAux = tamanio;
	
	Para contador = 1 Hasta tamanio/2 Hacer
		
		aux = numeros[contador];		
		numeros[contador] = numeros[contAux];
		numeros[contAux] = aux;
		
		contAux = contAux - 1;
		
	FinPara
	
FinFuncion

Funcion mostrarVector(numeros, tamanio) //por valor le estoy dando una copia de los valores, no me devuelve nada que cambie en la funcion.  
	Para contador = 1 Hasta tamanio Hacer
		Escribir "El numero ", contador," es ",numeros[contador];
	FinPara
	
FinFuncion

Algoritmo valoresPorReferencia
	Definir tamanio como Entero;
	tamanio = 3;
	Dimension  numeros[tamanio];
	
	
	cargarVector(numeros, tamanio);
	Escribir"Primer vuelta del vector:";	
	darVueltaVector(numeros, tamanio);
	mostrarVector(numeros, tamanio);
	
	Escribir"----------------------"
	Escribir"Segunda vuelta del vector: ";
	darVueltaVector(numeros, tamanio);
	mostrarVector(numeros, tamanio);
	
FinAlgoritmo
