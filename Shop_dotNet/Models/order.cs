//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_dotNet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order()
        {
            this.detail_orders = new HashSet<detail_orders>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> time { get; set; }
        public string name_receive { get; set; }
        public string phone_receive { get; set; }
        public string address_receive { get; set; }
        public string note { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<double> total_price { get; set; }
        public Nullable<int> customer_id { get; set; }
        public string type_payment { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detail_orders> detail_orders { get; set; }
    }
}
