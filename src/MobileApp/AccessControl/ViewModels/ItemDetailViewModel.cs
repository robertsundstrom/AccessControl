﻿using System;
using AppService;

namespace AccessControl.ViewModels
{
    public class ItemDetailViewModel : BindableBase
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
