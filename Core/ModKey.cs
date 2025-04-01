namespace ModApi.Core
{
    public class ModKey
    {
        public readonly IMod Mod;
        public readonly string Name;

        public ModKey(IMod mod, string name)
        {
            Mod = mod;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Mod}:{Name}";
        }
    }
}
