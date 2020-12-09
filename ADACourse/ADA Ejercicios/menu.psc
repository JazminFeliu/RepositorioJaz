Funcion verInventario()
	Borrar Pantalla
	Escribir "Este es el inventario";
	Escribir "Presione una tecla para volver al menú";
	Esperar tecla
	Borrar Pantalla
FinFuncion
Funcion cargarArticulo()
	Borrar Pantalla
	Escribir "Acá se cargan los artículos";
	Escribir "Presione una tecla para volver al menú";
	Esperar tecla
	Borrar Pantalla
FinFuncion
Algoritmo menu
	Definir opcionElegida como entero;
	opcionElegida = 1;
	Mientras opcionElegida <> 0 Hacer
		Escribir "Elija una opción: ";
		Escribir "1) Ver inventario";
		Escribir "2) Cargar nuevo artículo";
		Escribir "0) Salir";
		Leer opcionElegida;
		Segun opcionElegida
			1: verInventario();
			2: cargarArticulo();
			0: // salir
			De Otro Modo:
				Escribir "Opción incorrecta.";
		FinSegun
	FinMientras
FinAlgoritmo
