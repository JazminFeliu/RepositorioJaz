Algoritmo Ordenar_TresNumeros_MenoraMayor
	
	Dimension numeros[3];
	Escribir "Ingrese tres números distintos que quiera ordenar de menor a mayor: ";
	i=0;
	Mientras (i < 4) Hacer
		Leer n;
		numeros[i] = n;
		i = i + 1;		
	FinMientras
	
	ordenados = Falso;
	
	Mientras (ordenados == Falso) Hacer
		
		Mientras (i < 4) Hacer
			Si numeros[i] < numeros[i+1] Entonces
				naux = numeros[i];
				numeros[i] = numeros[i+1];
				numeros[i] = naux;
			FinSi
			i = i + 1;		
		FinMientras
		
		
		
		//Si (n1 < n2) y (n1 < n3) Entonces
		//	si (n2 < n3) Entonces
		//		numeroMenor = n1;
		//		numeroMedio = n2;
		//		numeroMayor = n3;
		//		ordenados = Verdadero;
		//	sino 
		//		numeroMenor = n1;
		//		numeroMedio = n3;
		//		numeroMayor = n2;
		//		ordenados = Verdadero;
		//	finSi;
		//sino si (n1 >n2) entonces
		//			naux = n1;
		//			n1 = n2;
		//			n2 = naux;
		//		sino 
		//			naux = n1;
		//			n1 = n3;
		//			n3 = naux;
		//		FinSi
		//		
		//FinSi
	
	FinMientras
	Escribir "Los numeros ordenados de menor a mayor son: ", numeroMenor,"-",numeroMedio,"-",numeroMayor, ".";
	
FinAlgoritmo
