Algoritmo ProblemasPropuestos_6
	i= 1;
	nombrePersonaMenor = "";
	edadMenor = 200;
	
	Dimension Nombres[3];
	Dimension Edades[3];
	
	Mientras (i<=3) Hacer
		Escribir "Ingrese el nombre de la persona:";
		Leer nombre;
		Nombres[i] = nombre;
		
		Escribir "Ingrese la edad de ",Nombres[i];
		Leer edad;
		Edades[i] = edad;
		
		Si Edades[i] < edadMenor Entonces
			edadMenor = Edades[i];
			nombrePersonaMenor = Nombres[i];
		FinSi
		
		i = i+1;		
	FinMientras
	
	Escribir nombrePersonaMenor," es la persona mas joven, con una edad de ",edadMenor," años";
	
FinAlgoritmo
