objeto: es una instancia de una clase
	Un objeto es un caso particular de una Clase.
	Un objeto es una instancia de una clase.
	
clase: Es una abstraccion a partir de la cual se crean objetos. Es el "molde" de los objetos.
	En java los objetos pertenecen a una sola clase
	
instanciar: es crear un objeto a partir de una clase.
	
	vector en pseudocodigo es un conjunto de variables del mismo tipo agrupadas en un
	vector en POO es un conjunto de objetos del mismo tipo agrupadas en una clase.
	
	
	mensajes, métodos
	Un mensaje es lo que "entiende" un objeto.
	Los metodos son mensajes. 
	Un metodo es una porcion de codigo que agrupa las acciones que puede ejecutar un objeto o clase.
	Es lo que le "enseñamos" que puede hacer.
	
	parametro = es informacion que necesita un metodo para funcionar. Es lo mismo que argumento
	
	
	estado
	Es el conjunto de valores de los atributos del objeto.
	
	caracteristicas, atributos
	Los atributos son lo que antes llamabamos variables, en pseudocodigo. Son las caracteristicas de las clases.
	
	una Persona tiene un nombre; //ejemplos de caracteristicas
	una Persona tiene una direccion;
	una Persona tiene una edad;
	una Persona esta caminando;
	una Persona esta despierta;
	
	Persona{
	Definir edad como Entero;
	Definir nombre como Texto;
	Definir direccion como Texto;
	Definir estaCaminando como Logico;
	Definir estaDespierto como Logico;
	}
	pablo es una Persona(99,"pablo","av. siempreviva", No,Si); // este es el estado del objeto Pablo
		
		pablo.caminar(); // utilizo el punto para diferenciar el objeto del mensaje y eso hace que podamos aplicarlo.
		pablo es una Persona (99,"pablo","av. siempreviva", Si, Si) // este es el estado nuevo del objeto Pablo, luego que aplicar el metodo caminar
				
			
				caminar(){
				estaCaminando = si;
					}
					caminar(metros){
					posicion = posicion + metros;
					}
					
		
	



Algoritmo programacionOrientadaaObjetos
	
	//ejemplos de paradigmas de objetos. Buscar wikipedia POO
	
	// clase Gato y clase Persona
	felix es un Gato
	garfield es un Gato
	
	pablo es una Persona
	jazmin es una Persona
	
	felix.caminar(10 metros);
	felix.caminar();
	
	Si felix.estaCaminando Entonces
		
		felix.frenar();
		
	FinSi
FinAlgoritmo
