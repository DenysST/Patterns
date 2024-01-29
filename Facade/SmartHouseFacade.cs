namespace Facade;

public class SmartHomeFacade {
    private readonly Lighting _lighting = new();
    private readonly MusicSystem _musicSystem = new();
    private readonly ClimateControl _climateControl = new();

    public void StartEveningRoutine() {
        _lighting.On();
        _musicSystem.PlayMusic();
        _climateControl.SetTemperature(22);
    }

    public void EndEveningRoutine() {
        _lighting.Off();
        _musicSystem.StopMusic();
    }
}