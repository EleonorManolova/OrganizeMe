﻿namespace OrganizeMe.Services.Data.Habits
{
    using System.Threading.Tasks;

    using OrganizeMe.Web.ViewModels.Habits;

    public interface IHabitService
    {
        Task<bool> CreateAsync(HabitInputViewModel habitViewModel);

        T GetEnum<T>(string description);

        HabitCreateViewModel GetHabitViewModel(string username);
    }
}
