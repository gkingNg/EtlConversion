namespace Conversion.Transform
{
    public class MapDefinition
    {
        public int InputOrdinal { get; set; }
        public string InputName { get; set; }

        public int OutputOrdinal { get; set; }  
        public string OutputName { get; set; }
    }

    class MapDefinitionImpl : MapDefinition
    {
    }
}