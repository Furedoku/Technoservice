//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoServiceProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователь
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователь()
        {
            this.Заявки = new HashSet<Заявки>();
            this.Заявки1 = new HashSet<Заявки>();
        }
    
        public int Код { get; set; }
        public string Имя { get; set; }
        public string Логин { get; set; }
        public string Пароль { get; set; }
        public string Телефон { get; set; }
        public string Карта { get; set; }
        public int Код_роли { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявки> Заявки { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заявки> Заявки1 { get; set; }
        public virtual Роли Роли { get; set; }
    }
}
