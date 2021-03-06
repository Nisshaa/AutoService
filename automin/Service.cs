//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace automin
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ServicePhoto = new HashSet<ServicePhoto>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string Description { get; set; }
        public Nullable<double> Discount { get; set; }
        public string MainImagePath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicePhoto> ServicePhoto { get; set; }
        public Uri ImageUri
        {
            get
            {
                return new Uri(Path.Combine(Environment.CurrentDirectory, MainImagePath ?? ""));
            }
        }
        public string CostString
        {
            get
            {
                // тут должно быть понятно - преобразование в строку с нужной точностью
                return Cost.ToString("#.##");
            }
        }

        public string CostWithDiscount
        {
            get
            {
                // Convert.ToDecimal - преобразует double в decimal
                // Discount ?? 0 - разнуливает "Nullable" переменную
                var DiscountValue = Discount ?? 0;
                var CostString = (Cost * Convert.ToDecimal(1 - DiscountValue)).ToString("#.##");
                if (CostString == "") return "0";
                return CostString;
            }
        }

        // ну и сразу пишем геттер на наличие скидки
        public Boolean HasDiscount
        {
            get
            {
                return Discount > 0;
            }
        }

        // и перечёркивание старой цены
        public string CostTextDecoration
        {
            get
            {
                return HasDiscount ? "Strikethrough" : "None";
            }
        }
        public float DiscountFloat
        {
            get
            {
                return Convert.ToSingle(Discount ?? 0);
            }
        }
        public string DescriptionString
        {
            get
            {
                return Description ?? "";
            }
        }
    }
}
