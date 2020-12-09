

// preguntarle al usuario la operacion a realizar
//puede ser suma, resta, multiplicacion o division.

Funcion elNumero <- obtenerNumero()
	Escribir "Ingrese un numero:";
	Leer elNumero;
	
FinFuncion


Funcion resta <- restar ( numero1, numero2 )
	resta = numero1 - numero2;
	
Fin Funcion

Funcion resultado <- multiplicar ( numero1, numero2 )
	resultado = numero1 * numero2;
	
Fin Funcion

Funcion suma <- sumar (numero1, numero2)
	suma = numero1 + numero2;
	
FinFuncion

Funcion division <- dividir(numero1, numero2)
	si numero2 == 0 Entonces
		Escribir "El divisor no puede ser cero.";
		numero2 = obtenerNumero();
		
	FinSi
	division = numero1/numero2;
	
FinFuncion

Funcion promedio <- promediar(numero1, numero2)
	promedio = (numero1 + numero2)/2;
	
FinFuncion

Algoritmo calculadora
	
	Definir numero1 Como Entero;
	Definir numero2 Como Entero;
	
	numero1 = obtenerNumero();
	numero2 = obtenerNumero();

	Escribir "Ingrese que operacion quiere realizar(1=suma, 2= resta, 3=multiplicacion, 4=division)";
	Leer operacion;
	
	Segun operacion Hacer
		1:
			Escribir "La suma es: ", sumar(numero1, numero2);
		2:
			Escribir "La resta es: ", restar(numero1, numero2);
		3:
			Escribir "La multiplicacion es: ", multiplicar(numero1, numero2);
		4:
			Escribir "La division es: ", dividir(numero1, numero2);
		5:
			Escribir "El promedio es: ", promediar(numero1, numero2);
		De Otro Modo:
			Escribir "Ingrese una operacion válida";
	FinSegun
	
	
FinAlgoritmo
