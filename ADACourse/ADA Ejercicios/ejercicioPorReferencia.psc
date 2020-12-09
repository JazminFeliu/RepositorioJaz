Funcion cargarCalificaciones(calificaciones)
	Para contador = 1 Hasta 3 Hacer
		calificaciones[contador] = azar(10);
	FinPara
	
	
FinFuncion

Algoritmo ejercicioPorReferencia
	Dimension  calificaciones[3];
	cargarCalificaciones(calificaciones);
	
	Para contador = 1 Hasta 3 Hacer
		
		Escribir "La nota ",contador," es ", calificaciones[contador];
	FinPara
	
FinAlgoritmo
