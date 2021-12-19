using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rack
{
    /// <summary>
    /// перечисление типов объединения полок
    /// </summary>
    public enum CombiningShelvesType
    {
        /// <summary>
        /// объединение сверху
        /// </summary>
        CombiningUp,
        /// <summary>
        /// объединение снизу
        /// </summary>
        CombiningDown,
        /// <summary>
        /// без объединения
        /// </summary>
        NoneCombining
    }
}
