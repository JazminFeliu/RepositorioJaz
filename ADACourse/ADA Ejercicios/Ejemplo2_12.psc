Algoritmo Ejemplo2_12
	Escribir "Bienvenido al consultorio del Dr. Lorenzo T. Mata, por favor ingrese el numero de cita por su tratamiento: ";
	Leer numeroCita;
	
	Si numeroCita <= 3 Entonces
		costoCita = 200;
		costoTratamiento = costoCita*numeroCita;
	Sino 
		Si numeroCita <= 5 Entonces
			costoCita = 150;
			costoTratamiento = (200*3) + costoCita*(numeroCita-3);
		SiNo
			Si numeroCita <= 8 Entonces
				costoCita = 100;
				costoTratamiento = (200*3) + (150*2) + costoCita*(numeroCita-5);
			SiNo
				costoCita = 50;
				costoTratamiento = (200*3) + (150*2) + (100*3) + costoCita*(numeroCita-8);
			FinSi
			
		FinSi
		
	FinSi
	
	Escribir "El costo de la cita es de $ ",costoCita," y su tratamiento tiene un costo de $ ",costoTratamiento;
	
FinAlgoritmo
