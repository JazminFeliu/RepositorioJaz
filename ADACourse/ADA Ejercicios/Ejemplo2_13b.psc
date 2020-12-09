Algoritmo Ejemplo2_13b
	
	Escribir "Ingrese la clave del articulo que fabricará El cometa (1/2/3/4/5/6)";
	Leer claveArticulo;
	
	Escribir "Ingrese el precio de la materia prima con la que realizara el producto";
	Leer materiaPrima;
	
	Segun claveArticulo Hacer
		1:
			manoDeObra = materiaPrima*1.80;
			gastoDeFabricacion = materiaPrima*1.28;
		2:
			manoDeObra = materiaPrima*1.85;	
			gastoDeFabricacion = materiaPrima*1.30;
		3:
			manoDeObra = materiaPrima*1.75;
			gastoDeFabricacion = materiaPrima*1.35;
		4:
			manoDeObra = materiaPrima*1.75;
			gastoDeFabricacion = materiaPrima*1.28;
		5:
			manoDeObra = materiaPrima*1.80;
			gastoDeFabricacion = materiaPrima*1.30;
		6:
			manoDeObra = materiaPrima*1.85;	
			gastoDeFabricacion = materiaPrima*1.35;
	Fin Segun
	
	costoDeProduccion = materiaPrima + manoDeObra + gastoDeFabricacion;
	precioDeVenta = costoDeProduccion + costoDeProduccion*1.45;
	
	Escribir "El costo de produccion es de $ ",costoDeProduccion," y su precio de Venta es de $ ",precioDeVenta;
	
FinAlgoritmo
