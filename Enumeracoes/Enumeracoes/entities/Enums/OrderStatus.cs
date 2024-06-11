using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracoes.entities.Enums
{
    enum OrderStatus : int
    {   
        PendingPayment = 0,
        Procesing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
