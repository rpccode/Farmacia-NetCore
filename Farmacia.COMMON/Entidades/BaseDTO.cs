using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Entidades
{
    public class BaseDTO : IDisposable
    {
        private bool _isDisposed;
        public void Dispose()
        {
            if (_isDisposed)
            {
                this._isDisposed = true;
                GC.SuppressFinalize(this);

            }
            
        }
    }
}
