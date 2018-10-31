using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe001
{
    class test
    {
        public string Title { get; set; }

        public bool Erledigt { get; set; }
        

        public void ToDo(string title, bool erledigt)
        {
            this.Title = title;
            this.Erledigt = erledigt;
            
        }






    }
}
