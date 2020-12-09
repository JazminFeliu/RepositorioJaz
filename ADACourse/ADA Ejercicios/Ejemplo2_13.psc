Algoritmo Ejemplo2_13
	
	Escribir "Ingrese la clave del articulo que fabricará El cometa (1/2/3/4/5/6)";
	Leer claveArticulo;
	
	Escribir "Ingrese el precio de la materia prima con la que realizara el producto";
	Leer materiaPrima;
	
	Si claveArticulo == 3 o claveArticulo == 4 Entonces
		
		manoDeObra = materiaPrima*1.75;
		
	SiNo
		Si claveArticulo == 1 o claveArticulo == 5 Entonces
			
			manoDeObra = materiaPrima*1.80;
			
		SiNo
			
			manoDeObra = materiaPrima*1.85;		
			
		FinSi	
		
	FinSi
	
	Si claveArticulo == 2 o claveArticulo == 5 Entonces
		
		gastoDeFabricacion = materiaPrima*1.30;
		
	sino 
		Si claveArticulo == 3 o claveArticulo == 6 Entonces
			
			gastoDeFabricacion = materiaPrima*1.35;
			
		SiNo
			
			gastoDeFabricacion = materiaPrima*1.28;
			
		FinSi
		
	FinSi
	
	costoDeProduccion = materiaPrima + manoDeObra + gastoDeFabricacion;
	precioDeVenta = costoDeProduccion + costoDeProduccion*1.45;
	
	Escribir "El costo de produccion es de $ ",costoDeProduccion," y su precio de Venta es de $ ",precioDeVenta;
	
FinAlgoritmo
