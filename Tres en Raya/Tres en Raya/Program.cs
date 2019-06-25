using System;

public class TresenRaya
{

    // Tablero de juego
    static int[,] tablero = new int[3, 3];
    // Símbolos del tablero: blanco, jug.1, jug.2
    static char[] simbolo = { ' ', 'O', 'X' };


    //Cuerpo del programa
    public static void Main()
    {
        bool terminado = false;

        // Dibujar el tablero inicial
        DibujarTablero();
        do
        {
            // Turno del jugador 1
            Console.WriteLine("Turno del jugador 1");
            PreguntarPosicion(1);
            // Dibujar la casilla del jugador 1
            DibujarTablero();
            // Comprobar si ha terminado la partida
            terminado = ComprobarGanador();
            if (terminado)
                Console.WriteLine("¡El jugador 1 ha ganado!");
            else
            {
                terminado = ComprobarEmpate();
                if (terminado)
                    Console.WriteLine("¡Ha habido un empate!");
                else
                {
                    // Turno del jugador 2
                    Console.WriteLine("Turno del jugador 2");
                    PreguntarPosicion(2);
                    // Dibujar la casilla del jugador 2
                    DibujarTablero();
                    // Comprobar si ha terminado la partida
                    terminado = ComprobarGanador();
                    if (terminado)
                        Console.WriteLine("¡El jugador 2 ha ganado!");
                }
            }
            // Repetir hasta que se haga un 3 en raya o surja el empate (tablero lleno)
        } while (!terminado);
        Console.ReadLine();
    }


    static void DibujarTablero()
    {
        Console.WriteLine();
        Console.WriteLine("-------------");
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write("|");
            for (int columna = 0; columna < 3; columna++)
                Console.Write(" {0} |", simbolo[tablero[fila, columna]]);
            Console.WriteLine();
            Console.WriteLine("-------------");
        }
    }


    //Pregunta dónde colocar la ficha y lo anota en el tablero
    static void PreguntarPosicion(int jugador) // 1 = Jug.1, 2= Jug.2
    {
        try
        {
            int fila, columna;
            do
            {
                Console.WriteLine();

                // Pido fila
                do
                {
                    Console.Write("¿En qué fila la pones? (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());
                }
                while ((fila < 1) || (fila > 3));

                // Pido columna
                do
                {
                    Console.Write("¿Y en qué columna? (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());
                }
                while ((columna < 1) || (columna > 3));

                if (tablero[fila - 1, columna - 1] != 0) //Si la casilla seleccionada ya está ocupada te advertirá y te volverá a pedir fila y columna
                    Console.WriteLine("¡Esta casilla ya está ocupada!");
            }
            while (tablero[fila - 1, columna - 1] != 0);

            // Si todo es correcto, se la asigno
            tablero[fila - 1, columna - 1] = jugador;
        }
        catch(Exception errorEncontrado) //Si introduces una letra o dejas en blanco la casilla a introducir te dará error y saltará tu turno
        {
            Console.WriteLine("Se ha producido un error: {0}", errorEncontrado.Message);
        }
    }


    // Devuelve "true" si hay tres en raya
    static bool ComprobarGanador()
    {
        bool hay3enRaya = false;

        // Si en alguna fila todas las casillas son iguales y no vacías
        for (int fila = 0; fila < 3; fila++)
            if ((tablero[fila, 0] == tablero[fila, 1])
                    && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] != 0))
                hay3enRaya = true;

        // Lo mismo para las columnas
        for (int columna = 0; columna < 3; columna++)
            if ((tablero[0, columna] == tablero[1, columna])
                    && (tablero[0, columna] == tablero[2, columna])
                    && (tablero[0, columna] != 0))
                hay3enRaya = true;

        // Y finalmente miro las dos diagonales
        if ((tablero[0, 0] == tablero[1, 1])
                && (tablero[0, 0] == tablero[2, 2])
                && (tablero[0, 0] != 0))
            hay3enRaya = true;
        if ((tablero[0, 2] == tablero[1, 1])
                && (tablero[0, 2] == tablero[2, 0])
                && (tablero[0, 2] != 0))
            hay3enRaya = true;

        return hay3enRaya;
    }


    // Devuelve "true" si hay empate 
    static bool ComprobarEmpate()
    {
        // Si no quedan huecos donde mover, es empate
        bool algunHueco = false;

        for (int fila = 0; fila < 3; fila++)
            for (int columna = 0; columna < 3; columna++)
                if (tablero[fila, columna] == 0)
                    algunHueco = true;

        return !algunHueco;
    }
}