using System;

namespace AleaPRNG
{
    public class Alea
    {
        private string seed;
        private AleaState state;
        
        
        public Alea(string seed)
        {
            this.seed = seed;
            state = AleaHandler.InitializeState(seed);
        }


        public AleaState ExportState()
        {
            return state;
        }


        public Alea ImportState(AleaState state)
        {
            this.state = state;
            return this;
        }


        public double Next()
        {
            var data = AleaHandler.AdvanceState(state);
            state = data.Value;
            return data.Key;
        }


        public double Random()
        {
            return Next();
        }


        public Alea Clone()
        {
            return new Alea(seed).ImportState(ExportState());
        }
    }
}