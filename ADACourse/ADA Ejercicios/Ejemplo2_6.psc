Algoritmo Ejemplo2_6
	
	Escribir "Gracias por contactar a -La Langosta Ahumada-.Por favor, ingrese la cantidad de personas que tendrá el evento";
	Leer cantidadPersonasEvento;
	costoPorPlatillo = 0;
	costoTotalEvento = 0;
	
	Si (cantidadPersonasEvento > 300) Entonces
		costoPorPlatillo = 750;
	
	SiNo
		si (cantidadPersonasEvento > 200) Entonces
			costoPorPlatillo = 850;
		SiNo
			costoPorPlatillo = 950;
			
		FinSi
	FinSi
	
	costoTotalEvento = cantidadPersonasEvento*costoPorPlatillo;
	
	Escribir "para ",cantidadPersonasEvento," de personas que asistirán al evento, el costo por platillo es de $ ",costoPorPlatillo," y el precio final es de $ ",costoTotalEvento; 
	
FinAlgoritmo
