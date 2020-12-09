

Algoritmo Ejemplo_3_3
	Escribir "Ingrese la cantidad de alumnos de la escuela";
	Leer cantidadElementosArreglo;
	
	Dimension nombres[cantidadElementosArreglo];
	Dimension promedios[cantidadElementosArreglo];
	
	Para contPrimerElemento = 1 hasta cantidadElementosArreglo Hacer
		Escribir "Ingrese el nombre del alumno:";
		Leer nombres[contPrimerElemento];
		
		Escribir "Ingrese el promedio de notas de ",nombres[contPrimerElemento],":";
		Leer promedios[contPrimerElemento];
	FinPara
	
	Para contPrimerElemento = 1 Hasta cantidadElementosArreglo-1 Hacer
		
		Para contSegundoElemento = 1 Hasta cantidadElementosArreglo-1 Hacer
			Si promedios[contPrimerElemento] > promedios[contSegundoElemento] Entonces
				promedioAux = promedios[contPrimerElemento];
				nombreAuxiliar = nombres[contPrimerElemento];
				promedios[contPrimerElemento] = promedios[contSegundoElemento];
				nombres[contPrimerElemento] = nombres[contSegundoElemento];
				promedios[contSegundoElemento] = promedioAux;
				nombres[contSegundoElemento] = nombreAuxiliar;
			FinSi
		FinPara
	FinPara
	
	Para contPrimerElemento = 1 hasta cantidadElementosArreglo Hacer
		Escribir nombres[contPrimerElemento]," tiene un promedio de :",promedios[contPrimerElemento];
	FinPara
	
FinAlgoritmo
