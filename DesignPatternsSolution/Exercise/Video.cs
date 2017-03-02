using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise
{
    internal interface IVideo
    {
    }

    class Video : LibraryItem, IVideo
    {
        public Video(string title, int year, int amount) : base(amount, year)
        {
            NameOrTitle = title;
        }
    }
}
