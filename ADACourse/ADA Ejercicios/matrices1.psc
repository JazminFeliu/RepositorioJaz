Funcion promedio <- promediar(edades, cantidad)
	
	Para cont=1 hasta cantidad Hacer
		
		suma = suma + edades[cont];
		
	FinPara;
	
	promedio = suma/cantidad;	
	
Fin Funcion

Algoritmo formularioDeDatos
	
	Dimension personas[3,4]; //Matriz de texto
	Dimension edades[3]; //Vector de numeros, paralelo a la Matriz.
	cantidad = 3;
	
	// Carga de datos
	Para cont = 1 hasta 3 Hacer
		
		Escribir "Ingrese el nombre: ";
		Leer personas[cont, 1];
		
		//Escribir "Ingrese el apellido: ";
		//Leer personas[cont,2];
		
		Escribir "Ingrese la escuela: ";
		Leer personas[cont,3];
		
		//Escribir "Ingrese la materia preferida: ";
		//Leer personas[cont,4];
		
		Escribir "Ingrese la edad: ";
		Leer edades[cont];
	
	FinPara
	
	// Impresion de resultados
	
	Para cont = 1 hasta 3 Hacer
		
		Escribir "La escuela ",personas[cont,3]," participa en la Olimpiada.";
		
	FinPara
	
	Escribir "El promedio de edades es: ",promediar(edades, cantidad);
	
FinAlgoritmo
