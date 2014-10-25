﻿namespace King.ATrak.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IConfigValues
    {
        #region Properties
        /// <summary>
        /// Sync Direction
        /// </summary>
        Direction SyncDirection
        {
            get;
        }
        #endregion
    }
}