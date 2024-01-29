namespace Facade;

public class Lighting {
    public void On() {
        Console.WriteLine("Lights are on");
    }
    public void Off() {
        Console.WriteLine("Lights are off");
    }
}

public class MusicSystem {
    public void PlayMusic() {
        Console.WriteLine("Music is playing");
    }
    public void StopMusic() {
        Console.WriteLine("Music is stopped");
    }
}

public class ClimateControl {
    public void SetTemperature(int temp) {
        Console.WriteLine("Temperature set to " + temp + " degrees");
    }
}