using System;
using System.Collections.Generic;

namespace Task_4_4.Models;

class BlogEntity
{
    public string Article { get; set; }

    public string Text { get; set; }

    public List<string> Tags { get; set; }

    public string ImagePath { get; set; }
}