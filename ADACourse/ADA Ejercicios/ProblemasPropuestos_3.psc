Algoritmo ProblemasPropuestos_3
	
	Escribir "Feliz dia de los Enamorados! Ingrese cuanto dinero quiere gastar en su regalo:";
	Leer dinero;
	
	Si dinero > 250 Entonces
		
		Escribir "Puede regalar un anillo";
	SiNo
		si dinero > 100 Entonces
			
			Escribir "Puede comprar un ramo de flores";
		SiNo
			si dinero > 10 Entonces
				
				Escribir "Puede regalar chocolates";
			SiNo
				
				Escribir "Solo le alcanza para regalar una tarjeta";
				
			FinSi
		FinSi
		
	FinSi
FinAlgoritmo
