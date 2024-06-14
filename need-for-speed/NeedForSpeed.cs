using System;

class RemoteControlCar
{
    
    public readonly int _speed = 0;
    public readonly int _batteryDrain = 0;
    private int _batteryCharge = 100;
    private int _drivenDistance = 0;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryCharge < _batteryDrain;

    public int DistanceDriven() => _drivenDistance;

    public void Drive()
    {
        if (_batteryCharge >= _batteryDrain)
        {
            _drivenDistance += _speed;
            _batteryCharge -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance) => this._distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int restSpeed = _distance / car._speed;
        int restBattery = _distance / car._batteryDrain;

        return restBattery >= restSpeed || car._speed == restBattery;
    }
}
