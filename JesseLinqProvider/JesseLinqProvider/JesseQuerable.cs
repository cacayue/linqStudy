//************************************************************
//Copyright: http://jesse2013.cnblogs.com
//************************************************************
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JesseLinqProvider
{
    public class JesseQuerable<T> :IQueryable<T>
    {
        public JesseQuerable()
        {
            Provider = new JesseQueryProvider();
            Expression = Expression.Constant(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (Provider.Execute<IEnumerable<T>>(Expression)).GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return (Provider.Execute<IEnumerable>(Expression)).GetEnumerator();
        }

        public Type ElementType
        {
            get { return typeof (T); }
        }

        public Expression Expression
        {
            get;
            private set;
        }

        public IQueryProvider Provider
        {
            get; private set;
        }
    }
}
