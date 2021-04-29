﻿//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2021年4月29日 18:46:18
//------------------------------------------------------------

namespace ET
{
    public class NumericWatcherAttribute : BaseAttribute
    {
        public NumericType NumericType { get; }

        public NumericWatcherAttribute(NumericType type)
        {
            this.NumericType = type;
        }
    }
}