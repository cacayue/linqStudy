// See https://aka.ms/new-console-template for more information



using System.Linq.Expressions;

namespace ExpressionTree // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            ExecuteExpressionHasReturn();
            
        }
        
        public static void ExecuteExpressionVoid()
        {
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
        }

        public static void ExecuteExpressionHasReturn()
        {
            List<User> myUsers = new List<User>();
            var userSql = myUsers.AsQueryable().Where(u => u.Age > 2);
            Console.WriteLine(userSql);
            // SELECT * FROM (SELECT * FROM User) AS T WHERE (Age>2)

            List<User> myUsers2 = new List<User>();
            var userSql2 = myUsers.AsQueryable().Where(u => u.Name=="Jesse");
            Console.WriteLine(userSql2);
            //SELECT * FROM (SELECT * FROM USER) AS T WHERE (Name='Jesse')


        }
    }
}
