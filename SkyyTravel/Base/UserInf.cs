//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SkyyTravel.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserInf()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int ID_User { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> ID_Passport { get; set; }
        public Nullable<int> PhoneNum { get; set; }
        public string Email { get; set; }
        public Nullable<int> IDRole { get; set; }
        public Nullable<int> TicketUser { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual Ticket Ticket1 { get; set; }
    }
}
