using System;

class RemoteControlCar
{
    private int _meters;
    private int _battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay()
    {
        if (_meters < 1980)
        {
            return $"Driven {_meters} meters";
        } else 
        {
            return "Driven 2000 meters";
        }
    }

    public string BatteryDisplay()
    {
        if (_battery > 0)
        {
            return $"Battery at {_battery}%";
        }
        else
        {
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if (_meters < 1980)
        {
            _meters += 20;
        }
        if (_battery > 0)
        {
            _battery--;
        }
    }
}
