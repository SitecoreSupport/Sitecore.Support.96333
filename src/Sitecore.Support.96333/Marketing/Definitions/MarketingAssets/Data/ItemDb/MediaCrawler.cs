namespace Sitecore.Support.Marketing.Definitions.MarketingAssets.Data.ItemDb
{
  using ContentSearch;
  public class MediaCrawler : Sitecore.Marketing.Definitions.MarketingAssets.Data.ItemDb.MediaCrawler
  {
    public override int GetContextIndexRanking(IIndexable indexable)
    {
      return int.MaxValue;
    }
  }
}