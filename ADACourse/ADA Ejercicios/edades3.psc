Algoritmo  entradaAlBar
	Dimension edades[4];
	Dimension  nombres[4];
	
	sonTodosMayores = Verdadero;
	
	Escribir "Ingrese los datos de las personas:";
	
	Para contador = 1 hasta 4 Hacer
		
		Escribir "Nombre:";
		Leer nombres[contador];
		
		Escribir "Edad";
		Leer edades[contador];
		
		si edades[contador] < 18 Entonces
			sonTodosMayores = Falso;
			
		FinSi
	FinPara
	
	Si sonTodosMayores Entonces
		Escribir "Puede entrar";
	SiNo
		Para contador= 1 Hasta 4 Hacer
			Si edades[contador] < 18 Entonces
				Escribir nombres[contador]," es menor de edad, no puede ingresar! Sea responsable.";
				Escribir "Tiene ",edades[contador]," años.";
			FinSi
		FinPara
	FinSi
	
	
FinAlgoritmo
	