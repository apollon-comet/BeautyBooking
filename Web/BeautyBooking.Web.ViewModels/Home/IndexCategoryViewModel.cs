﻿namespace BeautyBooking.Web.ViewModels.Home
{
    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;

    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
