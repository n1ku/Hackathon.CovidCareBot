/**

be aware that this code is only developed for some screenshots.. whithing some minuts.. 

created for hackathn <3 by Besnik Istrefi

 */
using System;

using Hackathon.CoronaCare.Models;

namespace Hackathon.CoronaCare.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
