namespace UntitledCubeGame.ModApi.Core
{
    public interface IMod
    {
        public void OnLoad();
        public void OnEnable();
        public void OnDisable();
    }
}
