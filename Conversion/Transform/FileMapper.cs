using System;
using System.Collections.Generic;

namespace Conversion.Transform
{
    public class FileMapper
    {
        public IList<OutPutRow> Map(IList<object> inputList, IList<MapDefinition> mapDefinitions, Type userType)
        {
            IList<OutPutRow> result = new List<OutPutRow>();


            return result;
        }
    }

    public class OutPutRow  
    {
        public string BarcodeId { get; set; }
        public string AnimalId { get; set; }
        public string SexOfAnimal { get; set; }

    }
}