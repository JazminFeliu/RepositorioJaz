Algoritmo Ejemplo2_11
	Escribir " Bienvenido a El Naufrago Satisfecho. Por favor ingrese el tipo de hamburguesa que desea consumir (Sencilla/Doble/Triple):";
	Leer tipoHambur;
	
	Escribir "Ingrese la cantidad de hamburguesas ",tipoHambur," que consumirá";
	Leer cantidadHambur;
	
	Escribir "Ingrese el medio de pago, si abona con tarjeta tiene un 5% de recargo (efectivo/tarjeta): ";
	Leer tipoPago;
	
	Si tipoHambur == "Sencilla" Entonces
		precioHambur = 20;
	SiNo
		Si tipoHambur == "Doble" Entonces
			precioHambur = 25;
		SiNo
			precioHambur = 28;			
		FinSi
	FinSi
	
	precioEfectivo = precioHambur * cantidadHambur;
	
	Si tipoPago = "tarjeta" Entonces
		recargoTarjeta = precioEfectivo *0.05;
	SiNo
		recargoTarjeta = 0;
	FinSi
	
	precioFinal = precioEfectivo + recargoTarjeta;
	
	Escribir "El precio de las ",cantidadHambur," hamburguesas ",tipoHambur," para el pago con ",tipoPago," tiene ",recargoTarjeta, " recargo y es de $ ",precioFinal;
	Escribir "El precio de cada hamburguesa es de $ ",precioHambur;	
	
FinAlgoritmo
