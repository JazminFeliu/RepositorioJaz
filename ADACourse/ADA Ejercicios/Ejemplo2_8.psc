Algoritmo Ejemplo2_8
	
	Escribir"Ingrese la cantidad de alumnos que viajar�n";
	Leer cantidadAlumnos;
	
	Si cantidadAlumnos >= 100 Entonces
		costoPorAlumno = 65;
		
	Sino 
		Si cantidadAlumnos >= 50 Entonces
			costoPorAlumno = 70;
			
		sino 
			Si cantidadAlumnos >= 30 Entonces
				costoPorAlumno = 95;
			SiNo
				costoPorAlumno = 4000/cantidadAlumnos;
			FinSi
		FinSi
	FinSi
	
	costoRentaAutobus = cantidadAlumnos * costoPorAlumno;
	
	Escribir "Para un viaje de ",cantidadAlumnos," alumnos, se deber� pagar a la compa��a de viajes $ ",costoRentaAutobus," y cada alumno debera pagar $ ",costoPorAlumno; 

	
FinAlgoritmo
