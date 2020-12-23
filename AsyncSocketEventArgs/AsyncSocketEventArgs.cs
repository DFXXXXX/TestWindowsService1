using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService1
{
    public class AsyncSocketEventArgs
    {
        /// </summary>
        public string _msg;

        /// <summary>
        /// 客户端状态封装类
        /// </summary>
        public AsyncSocketState _state;

        /// <summary>
        /// 是否已经处理过了
        /// </summary>
        public bool IsHandled { get; set; }

        public AsyncSocketEventArgs(string msg)
        {
            this._msg = msg;
            IsHandled = false;
        }
        public AsyncSocketEventArgs(AsyncSocketState state)
        {
            this._state = state;
            IsHandled = false;
        }
        public AsyncSocketEventArgs(string msg, AsyncSocketState state)
        {
            this._msg = msg;
            this._state = state;
            IsHandled = false;

        }
    }
}
