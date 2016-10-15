using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OnlineGame
{
    public interface Effect
    {
        DateTime EndTime { get; }

        Attribute ChangedAttribute { get; }

        // A value to which the attribute is changed.
        int Change { get; }

        // If EndTime is reached, method returns normal value to changed attribute.
        void Update();
    }

    public class Slowing : Effect
    {
        public DateTime EndTime { get; }
        public Attribute ChangedAttribute { get; }
        public int Change { get; }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
