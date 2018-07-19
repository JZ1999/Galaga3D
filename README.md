# Prototipo

## Bases del juego

>* **_Género_**: Top-down shooter, Action, Multiplayer
>* **_Temática e historia_**:
>* **_Plataformas_**: Windows, Linux
>* **_Modelo Comercial_**:
>* **_Público Objetivo_**:
* **_Version de Juego_**: 0.1.1.1


	El juego consiste en poder usar de una selección de naves; el cual cada nave contiene sus diferencias ya sea en velocidad, velocidad de disparar, habilidad y otras cosas. Podrás escojer una selección de niveles donde puedes escojer jugar **__solo__** o **__multijugador online__**. Cada nave va tener su niche, y tal podrá ser beneficio en algunos niveles mas que en otros y tambien se podrá crear sinergía usando una combinación de naves al jugar multijugador para poder crear estrategias para pasar los niveles. El juego esta basado en el game design y modelos de los siguientes juegos:
	1. ![Referencia #1](https://image.winudf.com/v2/image/Y29tLmxpYmVyc29mdC5nYWxhZ2Ffc2NyZWVuXzZfMTUxODczNzc1OV8wNTg/screen-6.jpg?h=355&fakeurl=1&type=.jpg)
	2. ![Referencia #2](https://static.giantbomb.com/uploads/original/1/19947/1659365-aspaceshooterfor2bucks__preview2.jpg)
	3. ![Referencia #3](http://romhustler.net/img/screenshots/n64/ingame/4fe4994dca8bf.jpg)

## Links
**[Repositorio en github](https://github.com/JZ1999/Galaga3D)**
```sh
git clone http://github.com/JZ1999/Galaga3D.git
```
**[Descarga de Juego]()**

## Estandar de Versiones

* **_Versión de Unity_**: 2018.1.8
***
[**_Número de compilación principal_**].[**_Número de compilación menor_**].[**_Revisión_**].[**_Paquete_**]
 
*Ejemplo*: 2.15.1.3


* **_Número de compilación principal_**: Esto indica un hito importante en el juego, incremente esto cuando vaya de versión beta a versión de producción, desde versión de producción hasta actualizaciones importantes.

* **_Número de compilación menor_**: Se usa para actualizaciones de funciones, correcciones de errores grandes, etc.

* **_Revisión_**: Pequeñas modificaciones en las características existentes, pequeñas correcciones de errores, etc.

* **_Paquete_**: Su código permanece igual, cambios en la biblioteca externa o actualización de archivos de activos.
***

## Estándares de codigo y workflow de programación

Muchos de los estándares vienen del libro **Clean Code: A Handbook of Agile Software Craftsmanship: Robert C**.

> 1. Utilizar el #region para funciones de Unity y para las Variables

> 2. Utilizar barra baja para variables que no sean de las clases de Unity ejemplo: private int __var;

> 3. Evitar clases mas grandes que 100 lineas

> 4. Evitar lineas mas de 81 columnas

> 5. Evitar funciones con mas de 6 lineas

> 6. Usar nombres de funciones descriptivos, que hagan exclusivamente lo que dicen

> 7. Escribir nombre de variables descriptivos

> 8. Escribir nombre de clases descriptivos

> 9. **Nunca** dejar codigo comentado al hacer un git commit

> 10. Hacer git commits frecuentes con mensajes semi detallados ejemplo: "Actualizar ataque de nave basica y editar el README"

> 11. Evitar cantidad excesiva de comentarios, el codigo debe hablar por si mismo

> 12. Todo codigo debe ser en español

> 13. Evitar hacer un git commit con bugs del codigo que editaste, o que buguee el codigo de alguien mas

> 14. Por modularización, no hacer variables publicos (Hay excepciones), utilize el decorador [Serializable] en vez

> 15. Poner el codigo en sus carpetas respectivas (Scripts de objetos, de manejo y de informacion). Los de objetos son los que tienen una relacion directa con objetos.
>Los de manejo son los que controlan la escena como los objetos Managers. De ultimo, los de información guardan cosas como la información de las naves para poder tener acceso
>a esa información estatica.

> 16. Todas las clases que sean pronombres y que la primer letra sea mayúscula

> 17. Las funciones deben ser verbos y ser camel-case con la primer letra minúscula

> 18. Evitar el uso del try catch y no devolver codigos de errores. Devuelva un objeto descriptivo del error.

> 19. Usar formato CRLF

> 20. los if, switch, for, while y funciones deben estar formateados con sus corchetes de tal manera:
>```c#
>if(booleano)
>{
> var++;
>}
>```

> 21. Hacer git pull lo mas posible

> 22. Utilizar el siguiente codigo para un indicador de "sin terminar" o cosas que hacer en ese script:
>```c#
>//TODO:
>//Cosa que hacer
>```

> 23. Para los objetos AudioSource al final del variable poner SND, para los de texto poner TXT y los transform poner TR.
## Controles

* Movimiento: A izquierda, D derecha
* Ataque: Barra de espacio
* Habilidad: Q
* Pausa: Esc

### Creditos
***
#### Ricardo
[LinkedIn](https://www.linkedin.com/in/joseph-david-zamora-murillo-3645a7148/)
[Github](https://www.github.com/JZ1999)
***
#### Joseph David Zamora Murillo
[LinkedIn](https://www.linkedin.com/in/joseph-david-zamora-murillo-3645a7148/)
[Github](https://www.github.com/JZ1999)
***
### Sharon 
[LinkedIn](https://www.linkedin.com/in/joseph-david-zamora-murillo-3645a7148/)
[Github](https://www.github.com/JZ1999)
***
### Alejandro
[LinkedIn](https://www.linkedin.com/in/joseph-david-zamora-murillo-3645a7148/)
[Github](https://www.github.com/JZ1999)
***