¿Qué es una ruta?
Es una cadena de texto (URI) que funciona como una dirección unívoca para identificar y localizar una página específica dentro de la estructura de navegación de Shell.

¿Para qué sirve Routing.RegisterRoute?   
Sirve para vincular/asociar un nombre de ruta en texto (ej. "informacion") con el tipo de clase C# correspondiente a una página (ej. typeof(InformacionPage)).   

¿Qué significa ".." al navegar?   
Es una ruta relativa especial que indica desapilar la página actual y regresar al nivel/pantalla inmediatamente anterior en la pila de navegación.   

¿Por qué xmlns:views y views:InicioPage deben utilizar el mismo prefijo?   
Porque xmlns:views declara un alias o espacio de nombres XML personalizado. views:InicioPage utiliza ese alias exacto para indicarle al compilador en qué namespace de C# debe buscar la clase InicioPage.   
