using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Хранит время доставки для приоритетного заказа.
    /// </summary>
    public enum PriorityOrderDeliveryTime
    {
        None,
        NineAMToElevenAM,
        ElevenAMToOnePM,
        OnePMToThreePM,
        ThreePMToFivePM,
        FivePMToSevenPM,
        SevenPMToNinePM,
    }
}
