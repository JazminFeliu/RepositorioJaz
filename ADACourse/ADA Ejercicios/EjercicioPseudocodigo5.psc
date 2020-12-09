//Segun el numreo de mes, escribir cuantos dias tiene


Algoritmo contarDiasdelMes
	
	numeroMes = 0;
	
	Mientras (numeroMes < 1 o numeroMes > 12) Hacer
		
		Escribir "Ingresá el mes ";
		Leer numeroMes;
		
	FinMientras
	
	Segun numeroMes Hacer
		2: Escribir "El mes ",numeroMes," tiene 28 dias, 29 si el año es bisiesto";
		4,6,9,11:
			Escribir "El mes ",numeroMes," tiene 30 dias";
		De Otro Modo:
			Escribir " El mes ",numeroMes," tiene 31 dias";
	FinSegun
	
	//Si (numeroMes ==1) o (numeroMes ==3) o (numeroMes ==5) o (numeroMes ==7) o (numeroMes == 8) o (numeroMes == 10) o (numeroMes ==12) Entonces
	//	Escribir " El mes ",numeroMes," tiene 31 dias";
	//sino si numeroMes = 2 entonces
	//		Escribir "El mes ",numeroMes," tiene 28 dias, 29 si el año es bisiesto";
	//	SiNo
	//		Escribir "El mes ",numeroMes," tiene 30 dias";
	//	finsi;
	//	
	//FinSi
	
FinAlgoritmo
