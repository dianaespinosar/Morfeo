# Morfeo 
**NASA´s Space App Challenge 2020, equipo Hydrus**. 

Los humanos necesitan 8 horas de sueño para llevar acabo de manera eficiente las actividades del día y mantenenerse saludables. Muchas estudios llevados a cabo por la NASA y MMR, muestran que los astronautos duermen en promedio 6 horas diarias, lo que genera fatiga, disminusión en la actividad cognitiva y las habilidades motoras. Morfeo es una aplicación diseñada para ayudar a los austrnautos a mejorar su calidad de sueño. La idea es monitorear cuanto dura cada fase del sueño, su alimentación, el ejercicio que realiza, si consume medicamentos y la descomposición horaria que puede presentarse al llegar a la estación espacial. 

## Tabla de contenido
- Información General
- Herramientas, lenguaje de codificación y software utilizados 
- Diagrama relacional 
- Capturas de Pantalla
- Video de YouTube

## Información general
Se desarrolló un algoritmo capaz de reducir el efecto jetlag, a través de un horario que indica las horas recomendadas para que el usuario comience y finalice su día, así como el horario sugerido para que se exponga a una luz azul de menor intensidad conocida por su capacidad para inducir el sueño. El objetivo es que cuando el usuario llegue a su destino (estación espacial) solo le lleve dos días en adaptarse a la nueva zona horaria. Además, el algoritmo puede establecer una rutina de sueño en determinada cantidad de días, aumentando o disminuyendo una hora, dependiendo del sentido de su viaje (este +1, oeste -1).

Asimismo, se programó una función para medir la distancia entre los picos de una señal de ECG. Así se podrá definir las diferentes etapas del sueño y poder conocer cuánto tiempo de sueño profundo y sueño ligero tiene el astronauta y determinar si está descansando lo suficiente. Con base a esto se planea desarrollar una pulsera con fotodiodos que obtenga la señal del usuario para guardar toda la información de su viaje al espacio.

## Herramientas, lenguaje de codificación y software utilizados
- Java
- Matlab 
- SQL Server(relational data base)
- Visual Studio
- Access
- Entity Framework 
- ODBC

## Diagrama relacional
Se creó una base de datos relacional en SQL Server. Esta base de datos tiene 17 tablas. La base de datos está conectada a una interfaz (hecha en Visual Studio), por lo que es fácil para el usuario registrar su información.

El siguiente diagrama muestra la relación entre las tablas.
![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/MorfeoDiagram.png "Diagrama de relación")

## Interfaz
Creamos la interfaz en Visual Studio con C #. El proyecto tiene una página de inicio de sesión, para acceder a su nombre de usuario y contraseña debe estar en la base de datos. Una vez que haya iniciado sesión, existen diferentes opciones, puede elegir entre algunas opciones:

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/MainWindow.JPG "MainWindow")


**Perfil:** esta ventana muestra la información personal del astronauta.

**Comidas:** se registra cada una de las comidas: la hora y el tipo de comida.

**Sueño:** se registra cómo fue su sueño, la hora a la que se fueron a dormir, a qué hora se despertaron, si se despertaron durante la noche y las razones por las que esto sucedió. También responden qué tipo de luz usaban, si tenían música y si usaron pastillas para dormir. Se generó un método en MatLab que dice cuántas horas estuvieron en sueño profundo. En caso de que el astronauta haya tenido menos de 6:30 horas, la aplicación programa automáticamente una siesta teniendo en cuenta su rutina de ejercicios.

**Ejercicio:** la aplicación automáticamente da el horario de ejercicio.

**Información del viaje:** dada la importancia de estar descansados, en esta sección se encuentra el itinerario con las horas de dormir que debe seguir el astronauta antes del lanzamiento. Con el objetivo de evitar el jetlag y que se adapten mejor a su nuevo horario de sueño.

**Cerrar sesión:** esto es para cerrar sesión en Morfeo.

Todos los cambios se guardan automáticamente en nuestra base de datos.

## Capturas de Pantalla
### Perfil

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/MorfeoAstro.JPG "Astronauta")
### Comida

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/Meal.JPG "Comida")
### Sueño

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/Info.JPG "Información")

### Ejercicio

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/Ejercicio.JPG "Ejercicio")
### Información del viaje

![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/TripInformationEast.JPG "Viaje")

## Vídeo de YouTube
[Click](https://youtu.be/KdlvJBqiytc)
