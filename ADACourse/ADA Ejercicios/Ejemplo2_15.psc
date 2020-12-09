Algoritmo Ejemplo2_15
	
	Escribir "Ingrese el tipo de tarjeta del cliente(1/2/3/4)";
	Leer tipoDeTarjeta;
	
	Escribir "Ingrese el limite actual del cliente:";
	Leer limiteActual;
	
	Segun tipoDeTarjeta Hacer
		1:
			montoAumento = limiteActual*0.25;
		2: 
			montoAumento = limiteActual*0.35;
		3:
			montoAumento = limiteActual*0.40;
		De Otro Modo:
			montoAumento = limiteActual*0.50;
	FinSegun
	
	limiteConAumento = limiteActual + montoAumento;
	
	Escribir "La tarjeta tiene un limite actualizado de $ ",limiteConAumento," y obtuvo un aumento de $ ",montoAumento;
	
FinAlgoritmo
