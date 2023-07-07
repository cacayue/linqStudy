using LinqToAmazon.BusinessObjec;

namespace LinqToAmazon;

public class AmazonBookQueryCriteria
{
    public BookCondition? Condition { get; set; }
    public Decimal? MaximumPrice { get; set; }
    public String Publisher { get; set; }
    public String Title { get; set; }
}