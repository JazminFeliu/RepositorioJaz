Algoritmo edades2
	
	Definir sonTodosMayores Como Logico;
	Definir contador como Numero;
	Dimension edades[4];
	Dimension  nombres[4];
	
	Dimension  edadesMenores[4];
	Dimension  nombresMenores[4];
	
	Para contador = 1 Hasta 4 Hacer
		edadesMenores[contador] = 0;
		
	Fin Para
	
	sonTodosMayores = Verdadero;
	cantidadMenores = 0;
	
	Para contador=1 Hasta 4  Hacer
		Escribir "Ingrese la edad: ";
		
		Leer edades[contador];
		
		Escribir "Ingrese el nombre:";
		Leer nombres[contador];
		
		Si edades[contador] < 18 Entonces
			sonTodosMayores = Falso;
			edadesMenores[contador] = edades[contador]; //vectores paralelos
			nombresMenores[contador] = nombres[contador];
			cantidadMenores = cantidadMenores + 1;
		FinSi
	Fin Para
	
	
	Si sonTodosMayores Entonces
		Escribir "Pueden entrar, son todos mayores de edad.";
		Escribir "Lista de ingresantes:";
		Para contador = 1 Hasta 4 Hacer
			Escribir nombres[contador]," tiene ",edades[contador]," años.";
		FinPara
	SiNo
		
		Escribir "No pueden ingresar, hay ",cantidadMenores," menor/es de edad en la lista de ingreso";
		Para contador = 1 Hasta 4 Hacer
			Si edadesMenores[contador] <> 0 Entonces
				Escribir nombresMenores[contador]," tiene ",edadesMenores[contador]," años.";
			FinSi
		FinPara
	FinSi
	
FinAlgoritmo
