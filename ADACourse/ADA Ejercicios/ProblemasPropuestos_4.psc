Algoritmo ProblemasPropuestos_4
	
	Escribir "Ingrese cuanto tiempo permanecio en el estacionamiento, fraccionado por horas:";
	leer tiempoEstadia;
	
	Si tiempoEstadia <= 2 Entonces
		
		costoEstadia = tiempoEstadia*5;
	SiNo
		Si tiempoEstadia <= 5 Entonces
			
			costoEstadia = 10 + (tiempoEstadia-2)*4;
			
		SiNo
			Si tiempoEstadia <= 10 Entonces
				
				costoEstadia = 22 + (tiempoEstadia-5)*3;
				
			SiNo
				costoEstadia = 37 + (tiempoEstadia-10)*2;
			FinSi
		FinSi
	FinSi
	
	Escribir "El costo a abonar es de $ ",costoEstadia," por permanecer ",tiempoEstadia," hora/s.";
FinAlgoritmo
