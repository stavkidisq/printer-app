using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCache
{
    public class Cache : AbstractCache
    {
        public override IDictionary<int, IForm> ConnectionCollect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

    }
}
