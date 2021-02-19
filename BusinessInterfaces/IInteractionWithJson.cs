using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessInterfaces
{
    public interface IInteractionWithJson
    {
        public void SerializeConnectionConfiguration();
        public void DeserializeConnectionConfiguration(string name);
        public void ChangingAnExistingText(string name);
    }
}
