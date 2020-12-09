Algoritmo Ejemplo2_3
	
	Escribir "ingresá la cantidad de lápices para calcular el precio a pagar";
	Leer cantidad;
	precio = 0;
	
	Si cantidad < 1000 Entonces
		
		precio = 90*cantidad;
	sino
		precio = 85*cantidad;
		
	FinSi
	
	Escribir "para la cantidad ingresada, el precio a abonar es de $ ",precio;
	
FinAlgoritmo
