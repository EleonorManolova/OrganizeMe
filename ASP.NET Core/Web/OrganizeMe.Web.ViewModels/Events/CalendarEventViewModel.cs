﻿namespace OrganizeMe.Web.ViewModels.Events
{
    using OrganizeMe.Data.Models;
    using OrganizeMe.Services.Mapping;

    public class CalendarEventViewModel : IMapFrom<Calendar>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string DefaultCalendarColorId { get; set; }

        public string DefaultCalendarColorHex { get; set; }

        public string DefaultCalendarColorName { get; set; }
    }
}
