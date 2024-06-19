using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceis420FinalProject
{
    public class SalesPerson : ISalesPerson
    {
        private string name;
        private string title;
        private List<double> sales;

        public SalesPerson(string name, string title)
        {
            this.name = name;
            this.title = title;
            sales = new List<double>();
        }

        public SalesPerson()
        {
            sales = new List<double>();
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public List<double> Sales
        {
            get { return sales; }
            set { sales = value; }
        }


        public Iterator CreateSalesIerator()
        {
            return new SalesIterator(this.sales);
        }

        public void CreateReport(List<SalesPerson> spList)
        {
            Console.Clear();
            Double totalSales = 0d;

            foreach (SalesPerson sp in spList)
            {
                double total = 0d;
                double min = 0d;
                double max = 0d;
                double avg = 0d;

                Console.WriteLine($"Sales Name: {sp.name}");
                Console.WriteLine($"Title: {sp.title}");
                var iterator = sp.CreateSalesIerator();
                int counter = 0;
                while (!iterator.IsDone())
                {
                    counter++;
                    Console.WriteLine($"    » Sales {counter}: {iterator.CurrentItem()}");
                    total += Double.Parse(iterator.CurrentItem().ToString());

                    if (Double.Parse(iterator.CurrentItem().ToString()) > max)
                    {
                        max = Double.Parse(iterator.CurrentItem().ToString());
                    }

                    if (min == 0d)
                    {
                        min = Double.Parse(iterator.CurrentItem().ToString());
                    }
                    else
                    {
                        if (Double.Parse(iterator.CurrentItem().ToString()) < min)
                        {
                            min = Double.Parse(iterator.CurrentItem().ToString());
                        }
                    }


                    iterator.Next();
                }
                avg = total / counter;
                totalSales += total;
                Console.WriteLine($"Total Sales: {total.ToString("C2")}");
                Console.WriteLine($"Min Sales: {min.ToString("C2")}");
                Console.WriteLine($"Max Sales: {max.ToString("C2")}");
                Console.WriteLine($"Average Sales: {avg.ToString("C2")}");
                Console.WriteLine("──────────────────────────────");
                Console.WriteLine();
            }
            Console.WriteLine($"Company Total Sales: {totalSales.ToString("C2")}");
        }

        public override string ToString()
        {
            return $"Name: {name}, Title: {title}";
        }
    }
}
