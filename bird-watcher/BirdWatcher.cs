using System;
using System.Linq;

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this._birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[]{0,2,5,3,7,8,4};

    //public int Today() => _birdsPerDay[_birdsPerDay.Length-1];
    public int Today() => _birdsPerDay.Last();

    //public void IncrementTodaysCount() => _birdsPerDay[_birdsPerDay.Length - 1]++;
    public void IncrementTodaysCount() => _birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        /*
        bool result = false;
        foreach(int day in _birdsPerDay) {
            if(day == 0)
            {
                result = true;
            }
        }
        return result;
        */
        return _birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        /*
        int result = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            result += _birdsPerDay[i];
        }
        return result; 
        */
        return _birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        /*
        int busyDays = 0;
        foreach (int day in _birdsPerDay)
        {
            if (day >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
        */
        return _birdsPerDay.Count(day => day >= 5);
    }
}
