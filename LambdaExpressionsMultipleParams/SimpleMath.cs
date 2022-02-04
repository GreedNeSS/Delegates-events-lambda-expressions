using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionsMultipleParams
{
    class SimpleMath
    {
        public delegate void MathMessage(string msd, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage handler)
        {
            mmDelegate = handler;
        }

        public void Add(int arg1, int arg2)
        {
            mmDelegate?.Invoke("Adding has completed!", arg1 + arg2);
        }
    }
}
