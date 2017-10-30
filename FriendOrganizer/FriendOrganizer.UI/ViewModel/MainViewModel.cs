﻿using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        
        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }

        public INavigationViewModel NavigationViewModel { get; }
    }
}
