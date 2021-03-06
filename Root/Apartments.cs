//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Root
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apartments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apartments()
        {
            this.Offers = new HashSet<Offers>();
        }
    
        public int Id { get; set; }
        public int CityId { get; set; }
        public int StreetsId { get; set; }
        public string House { get; set; }
        public string Number { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> TotalArea { get; set; }
        public Nullable<int> Rooms { get; set; }
        public Nullable<int> Floor { get; set; }
    
        public virtual Cities Cities { get; set; }
        public virtual Streets Streets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
