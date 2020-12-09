Algoritmo edades1
	
	Definir sonTodosMayores Como Logico;
	Definir contador como Numero;
	Dimension edades[4];
	
	Escribir "Ingrese las 4 edades: ";
	sonTodosMayores = Verdadero;
	
	Para contador <- 1 hasta 4 Hacer
		Leer edades[contador];
		 
		Si edades[contador] < 18 Entonces
			sonTodosMayores = Falso;
		FinSi
	FinPara
	
	Si sonTodosMayores Entonces
		Escribir "Pueden entrar";
	SiNo
		Escribir "No pueden ingresar";
	FinSi
	
FinAlgoritmo
