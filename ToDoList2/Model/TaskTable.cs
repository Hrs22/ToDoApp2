//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskTable
    {
        public int Id { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public int RegisterID { get; set; }
    
        public virtual RegisterTable RegisterTable { get; set; }
    }
}
