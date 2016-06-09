﻿using System;
using System.Collections.Generic;
using System.Text;

namespace System.NetworkToolkit
{
    /// <summary>
    /// Represents asynchronous operation.
    /// </summary>
    public interface IAsyncOP
    {
        /// <summary>
        /// Gets asynchronous operation state.
        /// </summary>
        AsyncOP_State State
        {
            get;
        }

        /// <summary>
        /// Gets error happened during operation. Returns null if no error.
        /// </summary>
        Exception Error
        {
            get;
        }
    }
}