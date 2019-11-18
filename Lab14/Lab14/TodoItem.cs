using SQLite;
using System;
using System.Collections.Generic;
using System.Text;



namespace Lab14
{
   public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int DNI { get; set; }
        public string nombres{ get; set; }
        public string apellidos { get; set; }
        public DateTime fecha { get; set; }
        public bool Done { get; set; }
    }
}
