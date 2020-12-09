Algoritmo Ejemplo2_9
	
	Escribir "Bienvenido a Chimefón:Chismea + x -. Ingrese la duración de su llamada";
	Leer duracionDeLlamada;
	
	Escribir "Ingrese 1 si realizo la llamada un domingo y 2 si no fue ese dia";
	Leer diaDeLlamada;
	
	Escribir "Ingrese 1 si la llamada se realizó de 7 a 13 hs y 2 si la llamada se realizó de 13:01 a 20 hs";
	Leer turnoDeLlamada;
	
	Si (duracionDeLlamada <= 5) Entonces
		precioLlamada = duracionDeLlamada * 1;
	SiNo
		Si (duracionDeLlamada <= 8 ) Entonces
			precioLlamada = (duracionDeLlamada - 5) * 0.80 + 5;
		SiNo
			Si (duracionDeLlamada <= 10) Entonces
				precioLlamada = 5 + 2.4 + (duracionDeLlamada - 8) * 0.70;
			SiNo
				precioLlamada = 5 + 2.4 + 1.4 + (duracionDeLlamada - 10)*0.5; 
			FinSi
		FinSi
		
	FinSi
	
	Si diaDeLlamada == 1 Entonces
		precioLlamada = precioLlamada * 1.05;
		
		Escribir "Gracias por utilizar Chimefón:Chismea + x -. Su llamada de ",duracionDeLlamada," minutos tiene un precio de $ ",precioLlamada," y cuenta con un recargo del 5% por haberse realizado en dia domingo";
	SiNo
		Si turnoDeLlamada == 1 Entonces
			precioLlamada = precioLlamada * 1.15;
			
			Escribir "Gracias por utilizar Chimefón:Chismea + x -. Su llamada de ",duracionDeLlamada," minutos tiene un precio de $ ",precioLlamada," y cuenta con un recargo del 15% por haberse realizado en dia habil y turno matutino";
		SiNo
			precioLlamada = precioLlamada * 1.10;
			
			Escribir "Gracias por utilizar Chimefón:Chismea + x -. Su llamada de ",duracionDeLlamada," minutos tiene un precio de $ ",precioLlamada," y cuenta con un recargo del 10% por haberse realizado en dia habil y turno vespertino";
		FinSi
	FinSi
	
FinAlgoritmo
