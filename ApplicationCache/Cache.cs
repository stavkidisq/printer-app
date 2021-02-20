using BusinessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCache
{
    public class Cache : AbstractCache
    {
        private Dictionary<int, IForm> connectionCollect;

        public override IDictionary<int, IForm> ConnectionCollect
        {
            get
            {
                return connectionCollect;
            }
            set
            {
                
            }
        }
    }
}
