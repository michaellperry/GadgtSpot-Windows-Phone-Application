using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    public partial class Main_RecentViewModel : ViewModelsBase.VMBase, IViewModels.IMain_RecentViewModel
    {
        private readonly IServices.IDialogService _dialogService;
        private readonly IServices.INavigationService _navigationService;
        private readonly IServices.ILockScreenService _lockScreenService;
        private readonly Repositories.IMain_mainrssfeed _main_mainrssfeed;
        private readonly Repositories.INewsFeed_NewsFeed _RecentFeed_RecentFeed;
        private readonly Repositories.IReviewsFeed_ReviewsFeed _reviewsFeed_ReviewsFeed;
        private readonly Repositories.IGiveawaysFeed_GiveawaysFeed _giveawaysFeed_GiveawaysFeed;
        private readonly Repositories.IEditorialFeed_EditorialFeed _editorialFeed_EditorialFeed;
        private readonly Repositories.IVideos_Videos _videos_Videos;
        private readonly IServices.IInternetService _internetService;


        public Main_RecentViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService, Repositories.IMain_mainrssfeed main_mainrssfeed, Repositories.INewsFeed_NewsFeed RecentFeed_RecentFeed, Repositories.IReviewsFeed_ReviewsFeed reviewsFeed_ReviewsFeed, Repositories.IGiveawaysFeed_GiveawaysFeed giveawaysFeed_GiveawaysFeed, Repositories.IEditorialFeed_EditorialFeed editorialFeed_EditorialFeed, Repositories.IVideos_Videos videos_Videos, IServices.IInternetService internetService)
        {
            _dialogService = dialogService;
            _navigationService = navigationService;
            _lockScreenService = lockScreenService;
            _main_mainrssfeed = main_mainrssfeed;
            _RecentFeed_RecentFeed = RecentFeed_RecentFeed;
            _reviewsFeed_ReviewsFeed = reviewsFeed_ReviewsFeed;
            _giveawaysFeed_GiveawaysFeed = giveawaysFeed_GiveawaysFeed;
            _editorialFeed_EditorialFeed = editorialFeed_EditorialFeed;
            _videos_Videos = videos_Videos;
            _internetService = internetService;
        }

        public Visibility IsInternetAvalaible
        {
            get
            {
                return _internetService.IsNetworkAvailable() ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> _main_RecentListControlCollection;

        public ObservableCollection<EntitiesBase.RssSearchResult> Main_RecentListControlCollection
        {
            get
            {

                if (_main_RecentListControlCollection == null)
                    GetMain_RecentListControlCollectionData();
                return _main_RecentListControlCollection;
            }
            set
            {
                SetProperty(ref _main_RecentListControlCollection, value);
            }
        }

        private EntitiesBase.RssSearchResult _selectedMain_RecentListControlCollection;

        /// <summary>
        /// SelectedMain_RecentListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedMain_RecentListControlCollection
        {
            get
            {
                return _selectedMain_RecentListControlCollection;
            }
            set
            {
                _selectedMain_RecentListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IMain_DetailViewModel>(_selectedMain_RecentListControlCollection);
            }
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> _RecentFeed_RecentListControlCollection;

        /// <summary>
        /// RecentFeed_RecentListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> RecentFeed_RecentListControlCollection
        {
            get
            {

                if (_RecentFeed_RecentListControlCollection == null)
                    GetRecentFeed_RecentListControlCollectionData();
                return _RecentFeed_RecentListControlCollection;
            }
            set
            {
                SetProperty(ref _RecentFeed_RecentListControlCollection, value);
            }
        }

        private EntitiesBase.RssSearchResult _selectedRecentFeed_RecentListControlCollection;

        /// <summary>
        /// SelectedRecentFeed_RecentListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedRecentFeed_RecentListControlCollection
        {
            get
            {
                return _selectedRecentFeed_RecentListControlCollection;
            }
            set
            {
                _selectedRecentFeed_RecentListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.INewsFeed_DetailViewModel>(_selectedRecentFeed_RecentListControlCollection);
            }
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> _reviewsFeed_RecentListControlCollection;

        /// <summary>
        /// ReviewsFeed_RecentListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> ReviewsFeed_RecentListControlCollection
        {
            get
            {

                if (_reviewsFeed_RecentListControlCollection == null)
                    GetReviewsFeed_RecentListControlCollectionData();
                return _reviewsFeed_RecentListControlCollection;
            }
            set
            {
                SetProperty(ref _reviewsFeed_RecentListControlCollection, value);
            }
        }

        private EntitiesBase.RssSearchResult _selectedReviewsFeed_RecentListControlCollection;

        /// <summary>
        /// SelectedReviewsFeed_RecentListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedReviewsFeed_RecentListControlCollection
        {
            get
            {
                return _selectedReviewsFeed_RecentListControlCollection;
            }
            set
            {
                _selectedReviewsFeed_RecentListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IReviewsFeed_DetailViewModel>(_selectedReviewsFeed_RecentListControlCollection);
            }
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> _giveawaysFeed_RecentListControlCollection;

        /// <summary>
        /// GiveawaysFeed_RecentListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> GiveawaysFeed_RecentListControlCollection
        {
            get
            {

                if (_giveawaysFeed_RecentListControlCollection == null)
                    GetGiveawaysFeed_RecentListControlCollectionData();
                return _giveawaysFeed_RecentListControlCollection;
            }
            set
            {
                SetProperty(ref _giveawaysFeed_RecentListControlCollection, value);
            }
        }

        private EntitiesBase.RssSearchResult _selectedGiveawaysFeed_RecentListControlCollection;

        /// <summary>
        /// SelectedGiveawaysFeed_RecentListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedGiveawaysFeed_RecentListControlCollection
        {
            get
            {
                return _selectedGiveawaysFeed_RecentListControlCollection;
            }
            set
            {
                _selectedGiveawaysFeed_RecentListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IGiveawaysFeed_DetailViewModel>(_selectedGiveawaysFeed_RecentListControlCollection);
            }
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> _editorialFeed_RecentListControlCollection;

        /// <summary>
        /// EditorialFeed_RecentListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> EditorialFeed_RecentListControlCollection
        {
            get
            {

                if (_editorialFeed_RecentListControlCollection == null)
                    GetEditorialFeed_RecentListControlCollectionData();
                return _editorialFeed_RecentListControlCollection;
            }
            set
            {
                SetProperty(ref _editorialFeed_RecentListControlCollection, value);
            }
        }

        private EntitiesBase.RssSearchResult _selectedEditorialFeed_RecentListControlCollection;

        /// <summary>
        /// SelectedEditorialFeed_RecentListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedEditorialFeed_RecentListControlCollection
        {
            get
            {
                return _selectedEditorialFeed_RecentListControlCollection;
            }
            set
            {
                _selectedEditorialFeed_RecentListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IEditorialFeed_DetailViewModel>(_selectedEditorialFeed_RecentListControlCollection);
            }
        }

        private ObservableCollection<EntitiesBase.YouTubeVideo> _videos_videosListControlCollection;

        /// <summary>
        /// Videos_videosListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.YouTubeVideo> Videos_videosListControlCollection
        {
            get
            {

                if (_videos_videosListControlCollection == null)
                    GetVideos_videosListControlCollectionData();
                return _videos_videosListControlCollection;
            }
            set
            {
                SetProperty(ref _videos_videosListControlCollection, value);
            }
        }

        private int _videos_videosListControlCollectionPageNumber;

        /// <summary>
        /// Videos_videosListControlCollectionPageNumber property.
        /// </summary>		
        public int Videos_videosListControlCollectionPageNumber
        {
            get
            {
                return _videos_videosListControlCollectionPageNumber;
            }
            set
            {
                SetProperty(ref _videos_videosListControlCollectionPageNumber, value);
            }
        }

        private EntitiesBase.YouTubeVideo _selectedVideos_videosListControlCollection;

        /// <summary>
        /// SelectedVideos_videosListControlCollection property.
        /// </summary>		
        public EntitiesBase.YouTubeVideo SelectedVideos_videosListControlCollection
        {
            get
            {
                return _selectedVideos_videosListControlCollection;
            }
            set
            {
                _selectedVideos_videosListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IVideos_DetailVideosViewModel>(_selectedVideos_videosListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshMain_RecentListControlCollectionCommand command.
        /// </summary>
        public async void RefreshMain_RecentListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingMain_RecentListControlCollection = true;
                var items = await _main_mainrssfeed.Refresh();
                Main_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                Main_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingMain_RecentListControlCollection = false;
            }
        }


        private bool _loadingMain_RecentListControlCollection;

        public bool LoadingMain_RecentListControlCollection
        {
            get { return _loadingMain_RecentListControlCollection; }
            set { SetProperty(ref _loadingMain_RecentListControlCollection, value); }
        }

        private ICommand _refreshMain_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshMain_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshMain_RecentListControlCollectionCommand
        {
            get { return _refreshMain_RecentListControlCollectionCommand = _refreshMain_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshMain_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetMain_RecentListControlCollectionCommand command.
        /// </summary>
        public void GetMain_RecentListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetMain_RecentListControlCollectionData(pageNumber);
        }


        private ICommand _getMain_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the GetMain_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand GetMain_RecentListControlCollectionCommand
        {
            get { return _getMain_RecentListControlCollectionCommand = _getMain_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetMain_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public async void RefreshRecentFeed_RecentListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingRecentFeed_RecentListControlCollection = true;
                var items = await _RecentFeed_RecentFeed.Refresh();
                RecentFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                RecentFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingRecentFeed_RecentListControlCollection = false;
            }
        }


        private bool _loadingRecentFeed_RecentListControlCollection;

        public bool LoadingRecentFeed_RecentListControlCollection
        {
            get { return _loadingRecentFeed_RecentListControlCollection; }
            set { SetProperty(ref _loadingRecentFeed_RecentListControlCollection, value); }
        }

        private ICommand _refreshRecentFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshRecentFeed_RecentListControlCollectionCommand
        {
            get { return _refreshRecentFeed_RecentListControlCollectionCommand = _refreshRecentFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshRecentFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public void GetRecentFeed_RecentListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetRecentFeed_RecentListControlCollectionData(pageNumber);
        }


        private ICommand _getRecentFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the GetRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand GetRecentFeed_RecentListControlCollectionCommand
        {
            get { return _getRecentFeed_RecentListControlCollectionCommand = _getRecentFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetRecentFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public async void RefreshReviewsFeed_RecentListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingReviewsFeed_RecentListControlCollection = true;
                var items = await _reviewsFeed_ReviewsFeed.Refresh();
                ReviewsFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                ReviewsFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingReviewsFeed_RecentListControlCollection = false;
            }
        }


        private bool _loadingReviewsFeed_RecentListControlCollection;

        public bool LoadingReviewsFeed_RecentListControlCollection
        {
            get { return _loadingReviewsFeed_RecentListControlCollection; }
            set { SetProperty(ref _loadingReviewsFeed_RecentListControlCollection, value); }
        }

        private ICommand _refreshReviewsFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshReviewsFeed_RecentListControlCollectionCommand
        {
            get { return _refreshReviewsFeed_RecentListControlCollectionCommand = _refreshReviewsFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshReviewsFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public void GetReviewsFeed_RecentListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetReviewsFeed_RecentListControlCollectionData(pageNumber);
        }


        private ICommand _getReviewsFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the GetReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand GetReviewsFeed_RecentListControlCollectionCommand
        {
            get { return _getReviewsFeed_RecentListControlCollectionCommand = _getReviewsFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetReviewsFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public async void RefreshGiveawaysFeed_RecentListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingGiveawaysFeed_RecentListControlCollection = true;
                var items = await _giveawaysFeed_GiveawaysFeed.Refresh();
                GiveawaysFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                GiveawaysFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingGiveawaysFeed_RecentListControlCollection = false;
            }
        }


        private bool _loadingGiveawaysFeed_RecentListControlCollection;

        public bool LoadingGiveawaysFeed_RecentListControlCollection
        {
            get { return _loadingGiveawaysFeed_RecentListControlCollection; }
            set { SetProperty(ref _loadingGiveawaysFeed_RecentListControlCollection, value); }
        }

        private ICommand _refreshGiveawaysFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshGiveawaysFeed_RecentListControlCollectionCommand
        {
            get { return _refreshGiveawaysFeed_RecentListControlCollectionCommand = _refreshGiveawaysFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshGiveawaysFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public void GetGiveawaysFeed_RecentListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetGiveawaysFeed_RecentListControlCollectionData(pageNumber);
        }


        private ICommand _getGiveawaysFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the GetGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand GetGiveawaysFeed_RecentListControlCollectionCommand
        {
            get { return _getGiveawaysFeed_RecentListControlCollectionCommand = _getGiveawaysFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetGiveawaysFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public async void RefreshEditorialFeed_RecentListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingEditorialFeed_RecentListControlCollection = true;
                var items = await _editorialFeed_EditorialFeed.Refresh();
                EditorialFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                EditorialFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingEditorialFeed_RecentListControlCollection = false;
            }
        }


        private bool _loadingEditorialFeed_RecentListControlCollection;

        public bool LoadingEditorialFeed_RecentListControlCollection
        {
            get { return _loadingEditorialFeed_RecentListControlCollection; }
            set { SetProperty(ref _loadingEditorialFeed_RecentListControlCollection, value); }
        }

        private ICommand _refreshEditorialFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshEditorialFeed_RecentListControlCollectionCommand
        {
            get { return _refreshEditorialFeed_RecentListControlCollectionCommand = _refreshEditorialFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshEditorialFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public void GetEditorialFeed_RecentListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetEditorialFeed_RecentListControlCollectionData(pageNumber);
        }


        private ICommand _getEditorialFeed_RecentListControlCollectionCommand;

        /// <summary>
        /// Gets the GetEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        public ICommand GetEditorialFeed_RecentListControlCollectionCommand
        {
            get { return _getEditorialFeed_RecentListControlCollectionCommand = _getEditorialFeed_RecentListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetEditorialFeed_RecentListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
        public async void RefreshVideos_videosListControlCollectionCommandDelegate()
        {
            try
            {
                LoadingVideos_videosListControlCollection = true;
                var items = await _videos_Videos.Refresh();
                Videos_videosListControlCollection = items;
                Videos_videosListControlCollectionPageNumber = 0;
            }
            catch (Exception ex)
            {
                Videos_videosListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingVideos_videosListControlCollection = false;
            }
        }


        private bool _loadingVideos_videosListControlCollection;

        public bool LoadingVideos_videosListControlCollection
        {
            get { return _loadingVideos_videosListControlCollection; }
            set { SetProperty(ref _loadingVideos_videosListControlCollection, value); }
        }

        private ICommand _refreshVideos_videosListControlCollectionCommand;

        /// <summary>
        /// Gets the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
        public ICommand RefreshVideos_videosListControlCollectionCommand
        {
            get { return _refreshVideos_videosListControlCollectionCommand = _refreshVideos_videosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(RefreshVideos_videosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
        public void GetVideos_videosListControlCollectionCommandDelegate(int pageNumber = 0)
        {
            GetVideos_videosListControlCollectionData(pageNumber);
        }


        private ICommand _getVideos_videosListControlCollectionCommand;

        /// <summary>
        /// Gets the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
        public ICommand GetVideos_videosListControlCollectionCommand
        {
            get { return _getVideos_videosListControlCollectionCommand = _getVideos_videosListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(GetVideos_videosListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public void SetLockScreenCommandDelegate()
        {
            _lockScreenService.SetLockScreen("LockScreen-419db029-832e-40f5-b5e8-3f908ffccbac.jpg");
        }


        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public void AboutCommandDelegate()
        {
            _navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }


        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }

        private async void GetMain_RecentListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingMain_RecentListControlCollection = true;

                var items = await _main_mainrssfeed.GetData();
                Main_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                Main_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingMain_RecentListControlCollection = false;
            }
        }

        private async void GetRecentFeed_RecentListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingRecentFeed_RecentListControlCollection = true;

                var items = await _RecentFeed_RecentFeed.GetData();
                RecentFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                RecentFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingRecentFeed_RecentListControlCollection = false;
            }
        }

        private async void GetReviewsFeed_RecentListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingReviewsFeed_RecentListControlCollection = true;

                var items = await _reviewsFeed_ReviewsFeed.GetData();
                ReviewsFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                ReviewsFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingReviewsFeed_RecentListControlCollection = false;
            }
        }

        private async void GetGiveawaysFeed_RecentListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingGiveawaysFeed_RecentListControlCollection = true;

                var items = await _giveawaysFeed_GiveawaysFeed.GetData();
                GiveawaysFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                GiveawaysFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingGiveawaysFeed_RecentListControlCollection = false;
            }
        }

        private async void GetEditorialFeed_RecentListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingEditorialFeed_RecentListControlCollection = true;

                var items = await _editorialFeed_EditorialFeed.GetData();
                EditorialFeed_RecentListControlCollection = items;
            }
            catch (Exception ex)
            {
                EditorialFeed_RecentListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingEditorialFeed_RecentListControlCollection = false;
            }
        }

        private async void GetVideos_videosListControlCollectionData(int pageNumber = 0)
        {

            try
            {
                LoadingVideos_videosListControlCollection = true;
                Videos_videosListControlCollectionPageNumber = pageNumber;

                if (pageNumber == 0)
                {
                    var items = await _videos_Videos.GetData(pageNumber);
                    Videos_videosListControlCollection = items;
                }
                else
                {
                    var items = await _videos_Videos.GetData(pageNumber);
                    foreach (var item in items)
                        Videos_videosListControlCollection.Add(item);
                }
            }
            catch (Exception ex)
            {
                Videos_videosListControlCollection = null;

                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.youtubeError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
                LoadingVideos_videosListControlCollection = false;
            }
        }


    }
}
