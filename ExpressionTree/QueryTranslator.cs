using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExpressionTree;

public class QueryTranslator:ExpressionVisitor
{
    private StringBuilder sb;
    
    internal string Translate(Expression expression)
    {
        this.sb = new StringBuilder();
        this.Visit(expression);
        return this.sb.ToString();
    }

    private static Expression StripQuotes(Expression e)
    {
        while (e.NodeType == ExpressionType.Quote)
        {
            e = ((UnaryExpression)e).Operand;
        }
        return e;
    }

    
    protected override Expression VisitMethodCall(MethodCallExpression m)
    {
        if (m.Method.DeclaringType == typeof(QueryExtension) && m.Method.Name == "Where")
        {
            sb.Append("SELECT * FROM (");
            this.Visit(m.Arguments[0]);
            sb.Append(") AS T WHERE");
            LambdaExpression lambda = (LambdaExpression)StripQuotes(m.Arguments[1]);
            this.Visit(lambda.Body);
            return m;
        }

        throw new NotSupportedException($"方法{m.Method.Name}不支持");
    }

    protected override Expression VisitBinary(BinaryExpression b)
    {
        sb.Append("(");
        this.Visit(b.Left);
        var checkType = b.NodeType switch
        {
            ExpressionType.Add => sb.Append(" AND "),
            ExpressionType.Or => sb.Append(" OR "),
            ExpressionType.Equal => sb.Append(" = "),
            ExpressionType.NotEqual => sb.Append(" <> "),
            ExpressionType.LessThan => sb.Append(" < "),
            ExpressionType.LessThanOrEqual => sb.Append(" <= "),
            ExpressionType.GreaterThan => sb.Append(" > "),
            ExpressionType.GreaterThanOrEqual => sb.Append(" >= "),
            _ => throw new NotSupportedException($"二元运算符{b.NodeType}")
        };
        this.Visit(b.Right);
        sb.Append(")");
        return b;
    }

    protected override Expression VisitConstant(ConstantExpression c)
    {
        IQueryable q = c.Value as IQueryable;
        if (q != null)
        {
            sb.Append("SELECT * FROM ");
            sb.Append(q.ElementType.Name);
        }else if (c.Value == null)
        {
            sb.Append("NULL");
        }
        else
        {
            switch (Type.GetTypeCode(c.Value.GetType()))
            {
                case TypeCode.Boolean:
                    sb.Append(((bool)c.Value) ? 1 : 0);
                    break;
                case TypeCode.String:
                    sb.Append("'");
                    sb.Append(c.Value);
                    sb.Append("'");
                    break;
                case TypeCode.Object:
                    throw new NotSupportedException(string.Format("The constant for '{0}' is not supported", c.Value));
                default:
                    sb.Append(c.Value);
                    break;
            }
        }
        
        return c;
    }

    protected override Expression VisitMember(MemberExpression m)
    {
        if (m.Expression != null && m.Expression.NodeType == ExpressionType.Parameter)
        {
            sb.Append(m.Member.Name);
            return m;
        }

        throw new NotSupportedException("");
    }
}