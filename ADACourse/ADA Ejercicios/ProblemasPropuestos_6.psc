Algoritmo ProblemasPropuestos_6
	
	precioArticulo = 1;
	
	Mientras precioArticulo > 0 Hacer
		Escribir "Ingrese el precio del articulo para calcular el descuento (0 = salir)";
		Leer precioArticulo;
		
		Si precioArticulo >= 200 Entonces
			
			descuento = 15;
			precioConDescuento = precioArticulo - precioArticulo*0.15;
			
		SiNo
			
			Si precioArticulo >= 100 Entonces
				
				descuento = 12;
				precioConDescuento = precioArticulo - precioArticulo*0.12;
				
			SiNo
				
				descuento = 10;
				precioConDescuento = precioArticulo - precioArticulo*0.10;
				
			FinSi
			
		FinSi
		
		Escribir "El precio final es de $ ",precioConDescuento," y se le aplicó un descuento del ",descuento," %.";
		
	FinMientras
	
	
	
FinAlgoritmo
