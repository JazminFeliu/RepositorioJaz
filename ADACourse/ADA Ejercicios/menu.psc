Funcion verInventario()
	Borrar Pantalla
	Escribir "Este es el inventario";
	Escribir "Presione una tecla para volver al men�";
	Esperar tecla
	Borrar Pantalla
FinFuncion
Funcion cargarArticulo()
	Borrar Pantalla
	Escribir "Ac� se cargan los art�culos";
	Escribir "Presione una tecla para volver al men�";
	Esperar tecla
	Borrar Pantalla
FinFuncion
Algoritmo menu
	Definir opcionElegida como entero;
	opcionElegida = 1;
	Mientras opcionElegida <> 0 Hacer
		Escribir "Elija una opci�n: ";
		Escribir "1) Ver inventario";
		Escribir "2) Cargar nuevo art�culo";
		Escribir "0) Salir";
		Leer opcionElegida;
		Segun opcionElegida
			1: verInventario();
			2: cargarArticulo();
			0: // salir
			De Otro Modo:
				Escribir "Opci�n incorrecta.";
		FinSegun
	FinMientras
FinAlgoritmo
