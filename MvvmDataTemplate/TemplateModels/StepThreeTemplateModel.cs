using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MvvmDataTemplate.TemplateModels
{
    public class StepThreeTemplateModel : BaseTemplateModel
    {
        public StepThreeTemplateModel()
        {
            var items = new List<Item>();
            var rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                var item = new Item
                {
                    BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                    Text = i.ToString()
                };

                items.Add(item);
            }

            Items = new List<Item>(items);
        }

        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string Text { get; set; }

        public Color BackgroundColor { get; set; }
    }
}
