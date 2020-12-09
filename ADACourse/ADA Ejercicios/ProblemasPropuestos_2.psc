Algoritmo ProblemasPropuestos_2
	//Determinar el sueldo semanal de un trabajador
	
	Escribir "Ingrese la cantidad de horas trabajadas:";
	Leer horasTrabajadas;
	
	Escribir "Ingrese el costo de su hora profesional";
	Leer costoHora;
	
	Si horasTrabajadas > 40 Entonces
		
		horasExtras = horasTrabajadas - 40;
		costoHorasExtras = horasExtras * costoHora*2
		sueldoSemanal = 40*costoHora + costoHorasExtras;
		
	SiNo
		sueldoSemanal = 40*costoHora;
	FinSi
	
	Escribir "El sueldo semanal es de $ ",sueldoSemanal," y cuenta con ",horasExtras," horas extras, que incrementan el sueldo en $ ",costoHorasExtras;

FinAlgoritmo
