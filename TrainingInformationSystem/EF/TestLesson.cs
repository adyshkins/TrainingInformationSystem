//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingInformationSystem.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestLesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestLesson()
        {
            this.UserTestLesson = new HashSet<UserTestLesson>();
        }
    
        public int IDTestLesson { get; set; }
        public int IDLesson { get; set; }
        public string Question { get; set; }
        public string PossibleAnswerOne { get; set; }
        public string PossibleAnswerTwo { get; set; }
        public string PossibleAnswerThree { get; set; }
        public string PossibleAnswerFour { get; set; }
        public int NumberCorrectAnswer { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTestLesson> UserTestLesson { get; set; }
    }
}
