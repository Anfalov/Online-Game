using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineGame
{
    public interface Attribute
    {
        // The property which define state of attribute without any effects.
        int NormalState { get; }

        int CurrentState { get; set; }

        // If the attribute is not reversed over time, this property is 0.
        int RateOfRecovery { get; }

        // Function that updates current state of attribute every second if RateOfRecovery is not 0.
        void Update();
    }

    // Some examples of attributes.

    public class Health : Attribute
    {
        public int NormalState { get; }
        public int CurrentState { get; set; }
        public int RateOfRecovery { get; }
        public Health()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class Magic : Attribute
    {
        public int NormalState { get; }
        public int CurrentState { get; set; }
        public int RateOfRecovery { get; }
        public Magic()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    public class Speed : Attribute
    {
        public int NormalState { get; }
        public int CurrentState { get; set; }
        public int RateOfRecovery { get; }
        public Speed()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
