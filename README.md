#Laboratorio 5 de Juegos

Este laboratorio usa el laboratorio anterior como base. Los efectos de sonido están colocados en la escena ```Shooter```

Los efectos agregados son: disparos, sonido metalico al hacer que una moneda caiga al suelo, y un sonido de victoria cuando se eliminan 16 monedas.

Musica de fondo de [Overwatch](https://www.youtube.com/watch?v=3wc9vZzY72g)

El slider para controlar el volumen se encuentra en el menu de pausa (que a vaces aparece defectuoso, ver descripción abajo)


# Laboratorio 4 de Juegos

En este laboratorio se muestra el uso de rayos de la pantalla para detectar colisiones con objetos. Consta de 3 escenas: Menú principal, Shooter y Test

## Menú Principal
Su funcion es de dar a elegir al usuario que escena quiere probar.

## Shooter
En el proyecto, la escena tiene el nombre de ```CharacterFirstPerson```, pero al usuario se le enseña con el nombre de ```Shooter```. En esta escena el movimiento se logra a través de WASD o las flechas, saltos con ```Espacio```, se apunta con el ratón y se dispara usando el click izquierdo. El fin es disparar a todos los targets flotantes del mundo. Cuando se dispare a uno, éste saldrá de su posición y caerá al suelo, destruyéndose al hacer contacto con el suelo.

Para regresar a la escena de Menú Principal, el usuario puede presionar ```Esc``` y se mostrará el menú de pausa. Este menú no siempre detecta los clics del usuario, y a veces es necesario presionar ```Esc``` de nuevo para que sí los detecte (desconozco la razón).



## Test
En esta escena se encuentran varias pelotas y cubos puestos en un plano. Al pasar el mouse sobre ellos, su color cambia, y cuando se hace clic en ellos, se aplica una fuerza en la dirección del clic que hace que se muevan.


## Datos
Marco Fuentes - 18188
