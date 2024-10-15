using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Classes
{
    /// <summary>
    /// Хранит данные о приоритетном товаре.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки приоритетного товара.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }
        /// <summary>
        /// Желаемое время доставки приоритетного товара.
        /// </summary>
        public Enums.PriorityOrderDeliveryTime DesiredDeliveryTime 
        { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="desiredDeliveyDate">Желаемая дата доставки 
        /// приоритетного товара.</param>
        /// <param name="priorityOrderDeliveryDate">Желаемое время доставки 
        /// приоритетного товара.</param>
        public PriorityOrder (DateTime desiredDeliveyDate, 
            Enums.PriorityOrderDeliveryTime priorityOrderDeliveryDate)
        {
            DesiredDeliveryDate = desiredDeliveyDate;
            DesiredDeliveryTime = priorityOrderDeliveryDate;
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() 
        {
            DesiredDeliveryDate = DateTime.Today;
            DesiredDeliveryTime = 0;
        }
    }
}
