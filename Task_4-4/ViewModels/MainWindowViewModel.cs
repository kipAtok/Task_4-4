using Task_4_4.Models;

using System;
using System.Collections.Generic;

namespace Task_4_4.ViewModels;

class MainWindowViewModel : ViewModelBase
{
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

    public MainWindowViewModel()
    {
        BlogEntities = new List<BlogEntity>()
        {
            new BlogEntity()
            {
                Article = "Article 1",
                Text = "Praesent leo nunc, scelerisque ut lectus in, iaculis porta metus. Ut bibendum varius efficitur. Donec vel feugiat lorem, a consectetur ex. Suspendisse potenti. Phasellus vitae gravida urna. Proin fermentum, ligula non pretium vulputate, est erat iaculis dui, at dignissim purus libero commodo nunc. Maecenas vel imperdiet mauris. Donec malesuada purus et turpis sodales, sed fermentum turpis aliquet. Fusce a egestas mi, at malesuada felis. Praesent eget molestie est. Quisque ac venenatis libero. Aenean molestie molestie libero, vitae consequat ipsum tempus at.\r\n\t\t\t\tMauris eu est nulla. Sed blandit tellus eu augue congue laoreet. Mauris a lorem lobortis, tincidunt neque eget, feugiat justo. Pellentesque blandit, nulla in bibendum imperdiet, erat elit tincidunt eros, vel hendrerit nibh velit sit amet odio.",
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"},
                ImagePath = "fmbchk.png"
            }
        };

        NewsEntities = new List<NewsEntity>()
        {
            new NewsEntity()
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor massa odio, at pharetra sapien finibus eget. Suspendisse consectetur volutpat mi, eu sodales dui condimentum nec. Pellentesque rhoncus mattis lectus...",
                PublishDate = DateTime.Now
            },

            new NewsEntity()
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed tempor massa odio, at pharetra sapien finibus eget. Suspendisse consectetur volutpat mi, eu sodales dui condimentum nec. Pellentesque rhoncus mattis lectus...",
                PublishDate = DateTime.Now.AddDays(-1)
            }
        };
    }
}
