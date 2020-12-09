Algoritmo Ejemplo3_5
	
	Dimension VectorseisElementos[6];
		
	
	Para cont = 1 Hasta 6 Hacer
		
		Escribir"Ingrese el elementos Nro. ",cont;
		Leer VectorseisElementos[cont];
		
		
	FinPara
	
	Escribir "Vector Primer Orden";
	Para cont = 1 Hasta 6 Hacer
		
		Escribir VectorseisElementos[cont];
		
	FinPara
	
	Para cont = 1 Hasta 3 Hacer
		auxiliar = VectorseisElementos[cont];
		VectorseisElementos[cont] = VectorseisElementos[7-cont];
		VectorseisElementos[7-cont] = auxiliar;		
	FinPara
	
	Escribir "Vector Segundo Orden";
	Para cont = 1 Hasta 6 Hacer
		
		Escribir VectorseisElementos[cont];
	FinPara
	
	
FinAlgoritmo
