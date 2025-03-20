using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes.Services;

namespace ObjectOrientedPractics.Model.Classes
{
    public class StringEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
    //Хранит данные об адрессе покупателя. 
    public class Address : ICloneable, IEquatable<Address>
    {
        public event EventHandler<EventArgs> AddressChanged;
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private string _index;
        /// <summary>
        /// Хранит данные об почтовый индексе. Целое шестизначное число.
        /// </summary>
        public string Index
        {
            get { return _index; }
            set
            {
                if (ValueValidator.IsPostalIndex(value, Index))
                {
                    if (_index != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged?.Invoke(this, args);
                        _index = value;
                    }
                }
            }
        }

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;
        /// <summary>
        /// Хранит данные о стране/регионе. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                if (ValueValidator.IsLessThanOrEqual(value, 50, Country))
                {
                    if (_country != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged.Invoke(this, args);
                        _country = value;
                    }
                }
            }
        }

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;
        /// <summary>
        /// Хранит данные о городе (населенном пункте). Не более 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                if (ValueValidator.IsLessThanOrEqual(value, 50, City))
                {                   
                    if (_city != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged.Invoke(this, args);
                        _city = value;
                    }
                }
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;
        /// <summary>
        /// Хранит данные об улице. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                if (ValueValidator.IsLessThanOrEqual(value, 100, Street))
                {
                    if (_street != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged.Invoke(this, args);
                        _street = value;
                    }
                }
            }
        }

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Хранит данные о номере дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                if (ValueValidator.IsLessThanOrEqual(value, 10, Building))
                {
                    if (_building != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged.Invoke(this, args);
                        _building = value;
                    }
                }
            }
        }

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;
        /// <summary>
        /// Хранит данные о номере квартиры/помещения. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                if (ValueValidator.IsLessThanOrEqual(value, 50, Apartment))
                {
                    if (_apartment != value)
                    {
                        var args = new StringEventArgs();
                        args.Value = value;
                        AddressChanged.Invoke(this, args);
                        _apartment = value;
                    }
                }
            }
        }

        public string ConvertToString()
        {
            return (Index + ", " + Country + ", " + City + ", " + Street + ", " + Building + ", " + Apartment);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна/регион. Не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Не более 50 символов.</param>
        /// <param name="street">Улица. Не более 100 символов.</param>
        /// <param name="building">Номер дома. Не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Не более 10 символов.</param>
        public Address(string index, string country, string city, string street, string building, string apartment)
        {
            _index = index;
            _country = country;
            _city = city;
            _street = street;
            _building = building;
            _apartment = apartment;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            _index = "000000";
            _country = "";
            _city = "";
            _street = "";
            _building = "";
            _apartment = "";
        }

        /// <summary>
        /// Копирует экземпляр класса <see cref="Address"/>.
        /// </summary>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Перегрузка стандартного метода Equals.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public override bool Equals(object other)
        {
            if (other == null) 
                return false;
            if (other is not Address) 
                return false;
            if (ReferenceEquals(this, other))
                return true;
            var otherAddress = (Address)other;
            return (this.Index == otherAddress.Index && this.Country == otherAddress.Country &&
                this.City == otherAddress.City && this.Street == otherAddress.Street &&
                this.Building == otherAddress.Building && this.Apartment == otherAddress.Apartment);
        }

        /// <summary>
        /// Проверяет, схож ли оригианальный объект с входящим. Реализация стандартного интерфейса IEquatable<T>.
        /// </summary>
        /// <param name="other">Проверяемый объект.</param>
        /// <returns>true, если объекты схожи, иначе - false.</returns>
        public bool Equals(Address other)
        {
            if (other == null) 
                return false;
            if (this.Index == other.Index && this.Country == other.Country &&
                this.City == other.City && this.Street == other.Street &&
                this.Building == other.Building && this.Apartment == other.Apartment) 
                return true;
            else 
                return false;
        }
    }

}
