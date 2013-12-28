using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    public interface IMain_RecentViewModel
    {
        /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        Visibility IsInternetAvalaible { get; }
        /// <summary>
        /// Gets/Sets the Main_RecentListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.RssSearchResult> Main_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedMain_RecentListControlCollection property.
        /// </summary>
        EntitiesBase.RssSearchResult SelectedMain_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the RecentFeed_RecentListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.RssSearchResult> RecentFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedRecentFeed_RecentListControlCollection property.
        /// </summary>
        EntitiesBase.RssSearchResult SelectedRecentFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the ReviewsFeed_RecentListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.RssSearchResult> ReviewsFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedReviewsFeed_RecentListControlCollection property.
        /// </summary>
        EntitiesBase.RssSearchResult SelectedReviewsFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the GiveawaysFeed_RecentListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.RssSearchResult> GiveawaysFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedGiveawaysFeed_RecentListControlCollection property.
        /// </summary>
        EntitiesBase.RssSearchResult SelectedGiveawaysFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the EditorialFeed_RecentListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.RssSearchResult> EditorialFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedEditorialFeed_RecentListControlCollection property.
        /// </summary>
        EntitiesBase.RssSearchResult SelectedEditorialFeed_RecentListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_videosListControlCollection property.
        /// </summary>
        ObservableCollection<EntitiesBase.YouTubeVideo> Videos_videosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Videos_videosListControlCollectionPageNumber property.
        /// </summary>
        int Videos_videosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedVideos_videosListControlCollection property.
        /// </summary>
        EntitiesBase.YouTubeVideo SelectedVideos_videosListControlCollection { get; set; }

        /// <summary>
        /// Gets the RefreshMain_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshMain_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetMain_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand GetMain_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the RefreshRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshRecentFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetRecentFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand GetRecentFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the RefreshReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshReviewsFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetReviewsFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand GetReviewsFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the RefreshGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshGiveawaysFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetGiveawaysFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand GetGiveawaysFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the RefreshEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshEditorialFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetEditorialFeed_RecentListControlCollectionCommand command.
        /// </summary>
        ICommand GetEditorialFeed_RecentListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the RefreshVideos_videosListControlCollectionCommand command.
        /// </summary>
        ICommand RefreshVideos_videosListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the GetVideos_videosListControlCollectionCommand command.
        /// </summary>
        ICommand GetVideos_videosListControlCollectionCommand { get; }


        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        ICommand SetLockScreenCommand { get; }


        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        ICommand AboutCommand { get; }
    }
}
