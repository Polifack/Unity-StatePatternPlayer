# Unity2D State Pattern aplicado a Player
Aplicacion del State Pattern a un Player. El State Pattern es un patrón de diseño que se utiliza principalmente cuando el comportamiento de un objeto depende del estado en el que se encuentre. Este estado puede facilitar la implementación del controlador de un Jugador en un videojuego debido a que el estado de un personaje varía segun como se encuentre (Agachado, en el aire, en el suelo, atacando...). Esto es una implementación simple del Patrón que considera los estados "Saltar", "Agacharse" y "EnElSuelo" (Que es el estado predeterminado).

![StatePattern](https://upload.wikimedia.org/wikipedia/commons/e/e8/State_Design_Pattern_UML_Class_Diagram.svg)

Para el desarrollo se ha utilizado Unity pero se podría aplicar esta idea a cualquier motor de desarrollo de videojuegos. 

# IPlayerState
Interfaz del estado. En esta clase declaramos los metodos que se tendrán que redefinir en cada estado del Jugador. El nombre de la clase es IPlayerState porque la convención de nomenclatura en CSharp es usar una I mayuscula para las interfaces.

# PlayerState
Clase abstracta que define comportamiento comun para todos los estados. La principal función que daremos a esta clase será asegurarnos que siempre la llamada de ToState cambie el estado ejecutando tanto OnEnterState como OnExitState. Aquí declararemos tambien las clases de los estados de forma que puedan ser siempre accedidas. Para ello las declararemos como estaticas y las declararemos de solo lectura por seguridad. En esta clase tambien se declararán todos los valores y funciones que son comunes a todos los estados, como por ejemplo el movimiento.

# Estados
Los estados que se consideraron para el jugador en el ejemplo son:
- PlayerOnGroundState
- PlayerCrouchState
- PlayerJumpingState

Cada uno define un posible estado del jugador y se encarga de las transiciones de estados así como de calcular cosas como el movimiento.

# Player
Clase del jugador, será la que se incorpore al GameObject del player. Guarda un parametro que es el estado en el que se encuentra actualmente. Al iniciarse (Awake) necesita cargar un estado, en este caso se cargará el estado de "PlayerOnGroundState". En el Update se ejecutará el Update del estado en el que se encuentre el jugador. En esta clase tambien se declararían las acciones que no son inherentes a un estado del jugador, si no que son propias de él, como por ejemplo comprobar si está en el suelo y similares.
