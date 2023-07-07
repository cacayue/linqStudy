// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

LabelTarget labelBreak = Expression.Label();
ParameterExpression loopIndex = Expression.Parameter(typeof(int), "index");

BlockExpression block = Expression.Block(
    new[] { loopIndex },
    Expression.Assign(loopIndex, Expression.Constant(1)),
    Expression.Loop(
        Expression.IfThenElse(
            Expression.LessThanOrEqual(loopIndex, Expression.Constant(3)),
            Expression.Block(
                Expression.Call(null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) })!,
                    Expression.Constant("Hellp")),
                Expression.PostIncrementAssign(loopIndex)),
            Expression.Break(labelBreak)), 
        labelBreak
    )
);

Expression<Action> lambdaExpression = Expression.Lambda<Action>(block);
lambdaExpression.Compile().Invoke();