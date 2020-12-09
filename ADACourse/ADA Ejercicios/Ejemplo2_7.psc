Algoritmo Ejemplo2_7
	
	Escribir "Ingrese el precio del kilo de uva";
	Leer precioKiloUva;
	
	Escribir "Ingrese si es tipo A o B";
	Leer tipoDeUva;
	
	Escribir "Ingrese si el tamaño es 1 o 2";
	Leer tamanioUva;
	
	Si (tipoDeUva == "A") Entonces
		si (tamanioUva == 1) Entonces
			precioClasificado = precioKiloUva + 20;
		SiNo
			precioClasificado = precioKiloUva + 30;
		FinSi
	SiNo
		si (tamanioUva == 1) Entonces
			precioClasificado = precioKiloUva - 30;
		SiNo
			precioClasificado = precioKiloUva - 50;
		FinSi 
		
	FinSi
	
	Escribir "Ingrese la cantidad de uvas que tiene el embarque";
	Leer cantidadUvas;
	
	precioTotal = cantidadUvas*precioClasificado;
	
	Escribir "El precio total del embarque es de $ ",precioTotal," para la uva tipo ",tipoDeUva," y de tamaño ",tamanioUva; 
	
FinAlgoritmo
