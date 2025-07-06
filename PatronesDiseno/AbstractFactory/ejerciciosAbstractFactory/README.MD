💻 Ejercicio de práctica – Tema: Abstract Factory
Enunciado:

Se está desarrollando una aplicación de edición de texto que puede funcionar en dos sistemas operativos distintos: Windows y macOS. Cada sistema tiene su propio estilo visual para botones y menús.

Debes aplicar el patrón Abstract Factory para crear una estructura que permita crear botones y menús de forma independiente del sistema operativo, asegurando que los componentes sean compatibles entre sí.

🎯 Objetivo:
Crear una interfaz para la fábrica de componentes de interfaz.

Crear clases concretas para Windows y macOS.

Crear las interfaces para Button y Menu, con sus respectivas implementaciones.

🧠 Requisitos:
El cliente debe poder cambiar el sistema operativo sin modificar su código.

Al instanciar una fábrica, el cliente debe poder obtener un botón y un menú del mismo estilo.