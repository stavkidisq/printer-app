using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public interface IInteractionWithJson
    {
        public void SerializeConnectionConfiguration(string name);
        public void DeserializeConnectionConfiguration(string name);
    }
}
