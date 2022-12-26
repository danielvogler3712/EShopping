using ApplicationCore.Entities;
using BlazorShared.Interfaces;

namespace BlazorAdmin.Services
{
    public class CatalogItemService : ICatalogItemService
    {
        private readonly ICatalogLookupDataService<CatalogBrand> _brandService;
        private readonly ICatalogLookupDataService<CatalogItem> _typeService;
        private readonly HttpService _httpService;
    }
}
