//Integrador de pseudocódigo
//Crear un sistema que permita controlar el stock de productos en una tienda.
//Condiciones:
//El nro. máximo de productos es 30.
//El sistema debe poder mostrar la cantidad total de artículos, el stock de un producto determinado, los detalles de un producto elegido, el precio.
//Además, debe permitir ingresar nuevos productos (máximo 30) y actualizar el stock de productos existentes.
//Debe existir un menú que ofrezca las distintas opciones del programa.

Algoritmo CRM
	Dimension Articulos(30,4) //Vectores paralelos por tipo de dato (texto, num)
	Dimension (30,3) 
	Nro articulo (Id)
	precio 
	stock
	
	Dimension DetallesArticulos(30) 
	detalle
	//seVendio
	
	// Escribir "Hola";
	// Esperar 2 segundos;
	// Esperar Tecla;
	// Borrar Pantalla;
	// Escribir "Chau";
	
	//Menu de opciones con Segun en el cuerpo principal del menu
	
	Menu
	0-Salir
	1-Cargar Productos
	2-Mostrar Producto
	3-Mostrar cantidad total de Articulos
	4-Actualizar stock productos Existentes
	
	
	
	
	Menu
	0-Salir
	1-Cargar Productos
	2-calcularCantidadProductos
	3-calcularStockCadaProducto
	4-mostrarDetalleProducto
	5-mostrarPrecioProducto
	6-ingresarNuevoProducto
	7-actualizarStockProductoExistente
	
funcion cargarProductos()
	ingresar id, precio, stock
	ingresar detalle		
	
FinFuncion

funcion calcularCantidadProductos()
	
FinFuncion

funcion calcularStockCadaProducto()
	
FinFuncion

funcion mostrarDetalleProducto()
	
FinFuncion

funcion mostrarPrecioProducto()
	
FinFuncion

funcion ingresarNuevoProducto()
	
FinFuncion

funcion actualizarStockProductoExistente()
	
FinFuncion
	
	
	
	
FinAlgoritmo
