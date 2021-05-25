using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.DesignPatterns.Iterator
{
    class ObjectIterator
    {
        private List<int> m_source;
        private int m_current;

        public ObjectIterator(List<int> source)
        {
            m_source = source;
            m_current = 0;
        }

        public bool hasNext()
        {
            return m_current < m_source.Count;
        }

        public int next()
        {
            return m_source[m_current++];
        }
    }
}
