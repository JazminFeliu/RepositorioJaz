Algoritmo Ejemplo2_10
	
	Escribir "Bienvenido a Viajes Silvita! Por favor ingrese la cantidad de personas que viajarán, recuerde que el minimo es de 20 personas";
	Leer cantidadPersonas;
	
	Escribir "Ingrese la cantidad de kilometros que desea recorrer";
	Leer cantidadKm;
	
	Escribir "Ingrese 1 si el autobus es tipo A, 2 si el autobús es tipo B y 3 si el autobús es tipo C";
	Leer tipoAutobus;
	
	Si cantidadPersonas > 20 Entonces
		Si tipoAutobus == 1 Entonces
			costoPorViaje = 2 * cantidadPersonas * cantidadKm;
			costoPorPersona = costoPorViaje/cantidadPersonas;
		SiNo
			Si tipoAutobus == 2 Entonces
				costoPorViaje = 2.5 * cantidadPersonas * cantidadKm;
				
			SiNo
				costoPorViaje = 3 * cantidadPersonas * cantidadKm;
			FinSi
			
		FinSi
		costoPorPersona = costoPorViaje/cantidadPersonas;
		
		SiNo
		Si tipoAutobus == 1 Entonces
			costoPorViaje = 2 * 20 * cantidadKm;
		SiNo
			Si tipoAutobus == 2 Entonces
				costoPorViaje = 2.5 * 20 * cantidadKm;
			SiNo
				costoPorViaje = 3 * 20 * cantidadKm;
			FinSi
			
		FinSi
		costoPorPersona = costoPorViaje/20;
		
	FinSi
	
	Escribir "El costo del viaje para ",cantidadPersonas," personas, que viajaran ",cantidadKm," km en un Autobus tipo ",tipoAutobus," es de $ ",costoPorViaje," y cada persona deberá abonar $ ",costoPorPersona;
	
FinAlgoritmo
