// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// RSS data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class GiveawaysFeed_GiveawaysFeed : IGiveawaysFeed_GiveawaysFeed 
    {
		private static bool AlreadyAccessed = false;
        private RepositoriesBase.IXmlDataSource _xmlDataSource; 
	    private IServices.IStorageService _storageService;
        private IServices.IInternetService _internetService;

		private const string RssUrl = "http://gadgtspot.com/category/giveaways/feed";

        /// <summary>
        /// Initializes a new instance of the <see cref="GiveawaysFeed_GiveawaysFeed" /> class.
        /// </summary>
        /// <param name="xmlDataSource">A XML based data source.</param>
		/// <param name="internetService">Internet service.</param>
        /// <param name="storageService">Storage service.</param>
        public GiveawaysFeed_GiveawaysFeed(RepositoriesBase.IXmlDataSource xmlDataSource, IServices.IInternetService internetService, IServices.IStorageService storageService)
        {
            _xmlDataSource = xmlDataSource;
		    _storageService = storageService;
            _internetService = internetService;
        }

        /// <summary>
        /// Retrieves the data from a RSS data source (http://gadgtspot.com/category/giveaways/feed), in an observable collection of RssSearchResult items.
        /// </summary>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<EntitiesBase.RssSearchResult>> GetData()
        {
			if(!AlreadyAccessed)
			{
				AlreadyAccessed = true;
				return await Refresh();
			}
			
            var data = LoadData();
            return data != null && data.Any() ? data : await Refresh();
        }

        /// <summary>
        /// Retrieves the data from a RSS data source (http://gadgtspot.com/category/giveaways/feed), in an observable collection of RssSearchResult items.
        /// </summary>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<EntitiesBase.RssSearchResult>> Refresh()
        {
            SyndicationFeed feed;
			
            if (_internetService.IsNetworkAvailable())
            {
				feed = await _xmlDataSource.LoadRemote<System.ServiceModel.Syndication.SyndicationFeed>(RssUrl);
				var defaultImage = feed.ImageUrl != null ? feed.ImageUrl.AbsoluteUri : null;
				var items = feed != null ? new ObservableCollection<EntitiesBase.RssSearchResult>(feed.Items.Select(i=>new EntitiesBase.RssSearchResult(i, defaultImage))) : new ObservableCollection<EntitiesBase.RssSearchResult>();
				_storageService.Save("GiveawaysFeed_GiveawaysFeed", items);
				
				return items;
			}

			return _storageService.Load<ObservableCollection<EntitiesBase.RssSearchResult>>("GiveawaysFeed_GiveawaysFeed");
        }
						
		/// <summary>
        /// Retrieves the data from a RSS data source (http://gadgtspot.com/category/giveaways/feed), filtered by a filter specification, in an observable collection of RssSearchResult items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<EntitiesBase.RssSearchResult>> Search(FilterSpecification filter)
        {
			var data = await GetData();
            return RepositoriesBase.Filter<EntitiesBase.RssSearchResult>.FilterCollection(filter, data);
        }
		
		/// <summary>
        /// Checks if data source has a element before the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a previous element, false if there is not</returns>
		public async Task<bool> HasPrevious(EntitiesBase.RssSearchResult current)
        {
			var data = await GetData();
			
            if (current == null || !data.Any()) return false;

            return data.IndexOf(current) > 0;
        }
		
		/// <summary>
        /// Checks if data source has a element after the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a next element, false if there is not</returns>
		public async Task<bool> HasNext(EntitiesBase.RssSearchResult current)
        {
			var data = await GetData();
			
            if (current == null || !data.Any()) return false;

            return data.IndexOf(current) < data.Count - 1;
        }
		
		/// <summary>
        /// Retrieves the previous element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The previous element from items, if it exists. Otherwise, returns null</returns>
        public async Task<EntitiesBase.RssSearchResult> Previous(EntitiesBase.RssSearchResult current)
        {
			var data = await GetData();
		
            if (current == null || !data.Any()) return null;

		    var index = data.IndexOf(current);

            if (index == -1 || index == 0) return null;

            return data[index - 1];
        }
		
		/// <summary>
        /// Retrieves the next element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The next element from items, if it exists. Otherwise, returns null</returns>
        public async Task<EntitiesBase.RssSearchResult> Next(EntitiesBase.RssSearchResult current)
        {
			var data = await GetData();
			
            if (current == null || !data.Any()) return null;

		    var index = data.IndexOf(current);

            if (index == -1 || index == data.Count - 1) return null;

            return data[index + 1];
        }

        private ObservableCollection<EntitiesBase.RssSearchResult> LoadData()
        {
			return _storageService.Load<ObservableCollection<EntitiesBase.RssSearchResult>>("GiveawaysFeed_GiveawaysFeed");
		}
	}	
}

