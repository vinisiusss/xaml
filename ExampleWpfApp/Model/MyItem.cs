using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWpfApp.Model
{
    class MyItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ActionDate { get; set; }
        public string Description { get; set; }

        public MyItem() {}

        public MyItem(int id, string title, DateTime date, string description)
        {
            this.ActionDate = date;
            this.Description = description;
            this.ID = id;
            this.Title = title;
        }
    }
}
