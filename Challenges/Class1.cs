using System;
using System.ComponentModel;
using System.Collections.Generic;

class Challenges
{
    public static void Main()
    {
            //Lists();
            Classes();

    }

    private static void Lists()
    {

    }

    private static void Classes()
    {
        Game game = new Game();

        Character character = new Character("Player", 3, true);

        game.Start();
    }
}


