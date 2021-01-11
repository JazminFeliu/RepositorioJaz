Funcion promedio = promediar(notas, cantidadAlumnos, cantidadNotas)

	Para i = 1 Hasta cantidadAlumnos Hacer
		
		Escribir cantidadNotas," notas del alumno ",i," generadas al azar: ";
		Para j= 1 Hasta cantidadNotas Hacer			
			Escribir"Ingrese la nota numero: ", j;
			Leer notas[i,j] 
			
			totalAlumno = totalAlumno + notas[i,j];
		FinPara
		promedioAlumno = totalAlumno/cantidadNotas;
		Escribir"El promedio de notas del alumno Santiago es: ",promedioAlumno;
		totalCurso = totalCurso + promedioAlumno;
	FinPara
	promedio = totalCurso/cantidadAlumnos;
FinFuncion


Algoritmo PromedioDeNotasconMatriz
	Escribir "ingrese la cantidad de alumnos del curso: ";
	Leer cantidadAlumnos;	
	Escribir "ingrese la cantidad de notas por alumno: ";
	Leer cantidadNotas;	
	Dimension notas[cantidadAlumnos, cantidadNotas];
	
	promedio = promediar(notas, cantidadAlumnos, cantidadNotas);	
	Escribir" El promedio del curso es: ", promedio;
	
FinAlgoritmo
