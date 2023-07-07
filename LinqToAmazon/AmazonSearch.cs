using System.Linq.Expressions;
using LinqToAmazon.BusinessObjec;

namespace LinqToAmazon;

public class AmazonSearch
{
    private AmazonBookQueryCriteria _Criteria;

    public AmazonSearch Where(Expression<Func<AmazonBook, bool>> predicate)
    {
        var visitor = new AmazonBookExpressionVisitor();

        _Criteria = visitor.ProcessExporession(predicate);
        return this;
    }

    public AmazonSearch Select<TResult>(Expression<Func<AmazonBook, TResult>> seletor)
    {
        return this;
    }
}