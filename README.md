### Primer Parcial Laboratorio de Programación II por Mauro Luciano.
---
# Sobre la aplicación
**Titulo:** Cruceros 'El Dorado'

**Sobre mí:** Soy Mauro, estudiante del segundo cuatrimestre de la carrera, y alumno de la comisión 2A con Maximiliano Neiner a cargo. El desarrollo de la aplicación fue un desafío desde el principio: el proceso de abstracción para poder pensarlo en clases y objetos. Se trató mucho de pensar más que de codear en sí, plantear bien el encapsulamiento de las clases y cómo iban a interactuar entre sí fue lo más complicado. Aprender a usar los controles de Windows Forms también resultó ser un desafío, aunque me limité a no utilizar controles muy complejos para poder emplear el tiempo ese tiempo en el código. Para escribirlo, tuve en cuenta más que nada la legibilidad, intentando mantener la mayor parte del tiempo un código limpio y mantenible a futuro. Evité en la medida de lo posible, no tener lógica de negocio dentro de los eventos de Windows Forms, aunque a veces se me escapaba. Me divertí haciendo el programa, debatiendo con mis compañeros y compañeros de otras divisiones sobre los requerimentos del programa, qué pensaba cada uno de cómo se debería hacer y qué interpretaban por el enunciado. Aprendí bastante sobre C# y POO en el proceso y me gustó cómo resultó el programa final.

**Resumen, diagrama de calses y justificación técnica:** Se encuentra en el pdf documentación.

**A tener en cuenta:**
- Se implementó una funcionalidad de manejo de hora para simular el tiempo. La fecha del sistema es la fecha que comparten todos los viajes, para avanzar en el tiempo se debe ir a Viajes -> Simular paso del tiempo.

**Pros y contras:**


**Pros:**
- :heavy_check_mark: Interfaz sencilla.
- :heavy_check_mark: Tiene un jueguito.

**Contras:**
- :x: Como se pensó para que los datos se muestren a traves de las propiedades, se repite código para entidades que mantienen una relación de composición
- :x: Como se eligió el tipo de dato BindingSource en la jerarquía de herencia de los formularios para contener las listas a mostrar, este tipo de dato al no tener implementación de ordenamiento y filtro, los métodos utilizados para ordenar y filtrar son rebuscados.

**Propuesta de valor agregado para promoción:** Se agregó a la lógica del negocio la posibilidad de editar un viaje, pudiendo cambiar la fecha de salida y el destino del viaje.

**Hecho con :heart: por maurnl.**
