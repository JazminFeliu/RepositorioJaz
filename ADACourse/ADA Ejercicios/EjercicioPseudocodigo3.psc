// dado el numero de dia, indicar si es fin de semana o dia laboral. Lunes =1, domingo = 7

Algoritmo esFindeOLaboral	
	
	dia = 0;
	
	Mientras (dia < 1 o dia >7) Hacer		
		Escribir " Ingrese el dia (1 para lunes, 2 para martes, etc)";
		Leer dia;
	FinMientras
	
	Si (dia == 1) Entonces
		Escribir "El dia es lunes, es un dia laboral";
	FinSi
	si (dia == 2) Entonces
		Escribir "El dia es martes, es un dia laboral";
	FinSi
	si (dia ==3) Entonces
		Escribir "El dia es miercoles, es un dia laboral";
	FinSi
	si (dia ==4) Entonces
		Escribir "El dia es jueves, es un dia laboral";
	FinSi
	si (dia == 5) Entonces
		Escribir "El dia es viernes, es un dia laboral";
	FinSi
	si (dia == 6) Entonces
		Escribir "El dia es sabado, es fin de semana";
	FinSi
	si (dia == 7) Entonces
		Escribir "El dia es domingo, es fin de semana";
	FinSi
	

FinAlgoritmo
