using System;

namespace UntitledCubeGame.ModApi.Core
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class ModEntryPointAttribute : Attribute
    {
        public string Name { get; }
        public string Author { get; }
        public string ApiVersion { get; }

        public ModEntryPointAttribute(string name, string author, string apiVersion)
        {
            Name = name;
            Author = author;
            ApiVersion = apiVersion;
        }
    }
}
