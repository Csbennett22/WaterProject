using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public virtual void AddItem(Project proj, int qty) //allows this method to be overridded when this is inherited from
        {
            BasketLineItem Line = Items
                .Where(p => p.Project.ProjectId == proj.ProjectId)
                .FirstOrDefault();

            if (Line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Project = proj,
                    Quantity = qty
                });
            }
            else
            {
                Line.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Project proj)
        {
            Items.RemoveAll(x => x.Project.ProjectId == proj.ProjectId);
        }

        public virtual void ClearBasket()
        {
            Items.Clear();
        }
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * 25); // default donation of $25

            return sum;
        }
    }

 

    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Project Project { get; set; }
        public int Quantity { get; set; }
    }
}
