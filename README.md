# Morfeo
Los humanos necesitan 8 horas de sueño para llevar acabo de manera eficiente las actividades del día y mantenenerse saludables. Muchas estudios llevados a cabo por la NASA y MMR, muestran que los astronautos duermen en promedio 6 horas diarias, lo que genera fatiga, disminusión en la actividad cognitiva y las habilidades motoras. Morfeo es una aplicación diseñada para ayudar a los austrnautos a mejorar su calidad de sueño. La idea es monitorear cuanto dura en cada fase del sueño, su alimento, el ejercicio que realiza, si consume medicamentos y la descomposición horaria que puede presentar al llegar a la estación espacial. 

## Tabla de contenido
- [Información General](Información general)
- [Diagrama con relación de tablas]
- [Capturas de Pantalla]()
- [Inspiración]()
- [Video de YouTube](https://youtu.be/KdlvJBqiytc)

## Información general
Se desarrolló un algoritmo capaz de reducir el efecto jetlag, a través de un horario que indica las horas recomendadas para que el usuario comience y finalice su día, así como el horario sugerido para que se exponga a una luz azul de menor intensidad conocida por su capacidad para inducir el sueño. El objetivo es que cuando el usuario llegue a su destino (estación espacial) solo le lleve dos días en adaptarse a la nueva zona horaria. Además, el algoritmo puede establecer una rutina de sueño en determinada cantidad de días, aumentando o disminuyendo una hora, dependiendo del sentido de su viaje (este +1, oeste -1).

Asimismo, se programó una función para medir la distancia entre los picos de una señal de ECG, para definir las diferentes etapas del sueño y así poder conocer cuánto tiempo de sueño profundo y sueño ligero tiene el astronauta para asegurar determinar si está descansando lo suficiente. Con base a esto se planea desarrollar una pulsera con fotodiodos que obtenga la señal del usuario para guardar toda la información de su viaje al espacio.

## Diagrama con relación de tablas
Se creó una base de datos relacional en SQL Server. Esta base de datos tiene 17 tablas. La base de datos está conectada a una interfaz (hecha en Visual Studio), por lo que es fácil para el usuario registrar su información.

Este diagrama muestra la relación entre las tablas.
![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/MorfeoDiagram.png "Diagrama de relación)


Los ritmos circadianos regulan los cambios en las características físicas y mentales que ocurren en el transcurso de un día. El reloj biológico de su organismo controla la mayoría de los ritmos circadianos. Este reloj se encuentra en una región del cerebro llamada hipotálamo. El cambio en la melatonina durante el ciclo sueño/vigilia refleja los ritmos circadianos. El hipotálamo también controla los cambios en la temperatura corporal y la presión arterial que ocurren durante el sueño.
Para estimar la fase circadiana usaremos el software de simulación de desempeño circadiano ((CPSS versión 2.1, Brigham y Women’s Hospital, Boston, MA, EE. UU.) La mayoría de las variables que se están considerando tienen una entrada en esta interfaz, pero hay otras variables como la exposición a la luz que calcularse utilizando un sensor de luz.
## Capturas de Pantalla
![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/MorfeoAstro.JPG "Astronauta")
![alt text](https://github.com/dianaespinosar/Morfeo/blob/main/Info.JPG "Información")
## Inspiración
