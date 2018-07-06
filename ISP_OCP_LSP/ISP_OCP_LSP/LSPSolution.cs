using System;
using System.Collections.Generic;
using System.Text;

namespace ISP_OCP_LSP
{
    class BirdP
    {
        private int numberLegs;
    }

    interface IFlying {
        void Fly();
    }

    class SparrowP : IFlying
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    class OstrichP : Bird
    {

    }
}
