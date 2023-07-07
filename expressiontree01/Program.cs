// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

LoopExpression loop = Expression.Loop(
    Expression.Call(null,
        typeof(Console).GetMethod("WriteLine", new Type[]{ typeof(string) })!, 
        Expression.Constant(("Hello")))
);
    
BlockExpression block = Expression.Block(loop);

Expression<Action> lambdaExpression = Expression.Lambda<Action>(block);

lambdaExpression.Compile().Invoke();