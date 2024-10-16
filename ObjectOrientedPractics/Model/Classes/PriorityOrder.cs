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
        public Enums.PriorityOrderDeliveryTime DesiredDeliveryTime { get; set; }

        /// <summary>
        /// Создаёт объект класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Хранит данные об адрессе покупателя. Объект класса <see cref="Classes.Address"/>.</param>
        /// <param name="items">Хранит список объектов класса <see cref="Item"/>.</param>
        public PriorityOrder(Address address, List<Item> items) : base()
        {
            Address = address;
            Items = items;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="desiredDeliveyDate">Желаемая дата доставки 
        /// приоритетного товара.</param>
        /// <param name="priorityOrderDeliveryDate">Желаемое время доставки 
        /// приоритетного товара.</param>
        public PriorityOrder (DateTime desiredDeliveyDate, 
            Enums.PriorityOrderDeliveryTime priorityOrderDeliveryDate) : base ()
        {
            DesiredDeliveryDate = desiredDeliveyDate;
            DesiredDeliveryTime = priorityOrderDeliveryDate;
        }
        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() : base()
        {
            DesiredDeliveryDate = DateTime.Today;
            DesiredDeliveryTime = 0;
        }
    }
}
