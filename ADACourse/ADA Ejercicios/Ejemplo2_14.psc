Algoritmo Ejemplo2_14
	Escribir "Ingrese el peso del paquete que quiere enviar en gramos (1kg = 1000)";
	Leer pesoPaquete;
	
	Escribir "Ingrese la zona a la que enviaré el paquete (1=America del Norte/2=America Central/3=America del Sur/4=Europa/5=Asia):";
	Leer idZona;
	
	Si pesoPaquete >= 5000 Entonces
		Escribir "La empresa no envia paquetes con un peso de 5 kg o superior. Por favor, elija otra compañia. Muchas gracias.";
	SiNo
		Segun idZona Hacer
			1: 
				costoPaquete = 11*pesoPaquete;
				Escribir "El paquete que desea enviar a America del Norte y pesa ",pesoPaquete/1000," kg, tiene un costo de envio de $ ",costoPaquete;
			2:
				costoPaquete = 10*pesoPaquete;
				Escribir "El paquete que desea enviar a America Central y pesa ",pesoPaquete/1000," kg, tiene un costo de envio de $ ",costoPaquete;
			3:
				costoPaquete = 12*pesoPaquete;
				Escribir "El paquete que desea enviar a America del Sur y pesa ",pesoPaquete/1000," kg, tiene un costo de envio de $ ",costoPaquete;
			4:
				costoPaquete = 24*pesoPaquete;
				Escribir "El paquete que desea enviar a Europa y pesa ",pesoPaquete/1000," kg, tiene un costo de envio de $ ",costoPaquete;
			De Otro Modo:
				costoPaquete = 27*pesoPaquete;
				Escribir "El paquete que desea enviar a Asia y pesa ",pesoPaquete/1000," kg, tiene un costo de envio de $ ",costoPaquete;
		FinSegun
	FinSi
	
		
FinAlgoritmo
