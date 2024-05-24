class Lasagna
{
    // define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven() => 40;

    // define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int minutes) => 40 - minutes;

    // define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int layers) => 2 * layers;

    // define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutesInTheOven) => PreparationTimeInMinutes(layers) + minutesInTheOven;
    
}
