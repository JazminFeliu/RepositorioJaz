Algoritmo Ejemplo2_5
	// determinar cual de tres cantidades proporcionadas es mayor.
	
	Escribir "Ingrese tres cantidades para determinar cual es la mayor";
	Leer cantidad1, cantidad2, cantidad3;
	
	Si cantidad1 > cantidad2 Entonces
		
		Si cantidad1 > cantidad3 Entonces
			cantidadMayor = cantidad1;
		sino 
			cantidadMayor = cantidad3;
			
		FinSi
	SiNo 
		
		Si cantidad2 > cantidad3 Entonces
			cantidadMayor = cantidad2;
		SiNo
			cantidadMayor = cantidad3;
		FinSi
		
	FinSi
	
	Escribir "De los tres números ingresados, el mayor es ",cantidadMayor;

FinAlgoritmo
