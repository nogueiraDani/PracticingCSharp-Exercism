using System;

public class Player
{
    public int RollDie()
    {
        Random play = new Random();
        return play.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random play = new Random();
        return play.NextDouble()*100;
    }
}
