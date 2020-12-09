Algoritmo Ejemplo2_4
	
	Escribir "Aprovechá la promo de -El Harapiento Distinguido-. Ingresa el precio del traje que querés comprar: ";
	Leer precioTraje;
	
	precioConDescuento = 0;
	descuento = 0;
	
	Si (precioTraje > 2500) Entonces
		precioConDescuento = (precioTraje - (precioTraje*15)/100);
		descuento = 15;
	SiNo
		precioConDescuento = (precioTraje - (precioTraje*8)/100);
		descuento = 8;
	FinSi
	
	Escribir "Felicitaciones! Por elegir un traje con un valor de $",precioTraje," se realizará un descuento del ",descuento,"%, y el precio final a pagar es de $ ",precioConDescuento
	
FinAlgoritmo
