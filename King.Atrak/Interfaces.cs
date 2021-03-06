﻿namespace King.ATrak
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region IStorageItem
    /// <summary>
    /// Interface for storage items
    /// </summary>
    public interface IStorageItem
    {
        #region Properties
        /// <summary>
        /// Gets the MD5 Hash
        /// </summary>
        string MD5
        {
            get;
        }

        /// <summary>
        /// Gets the Content Type
        /// </summary>
        string ContentType
        {
            get;
        }

        /// <summary>
        /// Gets the Path
        /// </summary>
        string Path
        {
            get;
        }

        /// <summary>
        /// Gets the Relative Path
        /// </summary>
        string RelativePath
        {
            get;
        }

        /// <summary>
        /// Get Data
        /// </summary>
        byte[] Data
        {
            get;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load MD5
        /// </summary>
        /// <returns>Task</returns>
        Task LoadMD5();

        /// <summary>
        /// Load object from data source
        /// </summary>
        /// <returns>Task</returns>
        Task Load();

        /// <summary>
        /// Delete Item
        /// </summary>
        /// <returns>Task</returns>
        Task Delete();
        #endregion
    }
    #endregion

    #region IDataLister
    /// <summary>
    /// Data Listing Operation
    /// </summary>
    public interface IDataLister
    {
        #region Methods
        /// <summary>
        /// List Data Items
        /// </summary>
        /// <returns>Storage Items</returns>
        IEnumerable<IStorageItem> List();
        #endregion
    }
    #endregion

    #region ISynchronizer
    /// <summary>
    /// Data Synchronizer Interface
    /// </summary>
    public interface ISynchronizer
    {
        #region Methods
        /// <summary>
        /// Run Synchronization
        /// </summary>
        /// <returns>Task</returns>
        Task Run();
        #endregion
    }
    #endregion

    #region IDataWriter
    /// <summary>
    /// Data Writer
    /// </summary>
    public interface IDataWriter
    {
        #region Methods
        /// <summary>
        /// Initialize Container
        /// </summary>
        /// <returns>Success</returns>
        Task<bool> Initialize();

        /// <summary>
        /// Store Items
        /// </summary>
        /// <param name="items">Items</param>
        Task Store(IEnumerable<IStorageItem> items);
        #endregion
    }
    #endregion

    #region IContentTypes
    /// <summary>
    /// Content Types Interface
    /// </summary>
    public interface IContentTypes
    {
        #region Methods
        /// <summary>
        /// Content Type
        /// </summary>
        /// <param name="filepath">File Path</param>
        /// <returns>Content Type</returns>
        string ContentType(string filepath);
        #endregion
    }
    #endregion

    #region IEchoer
    /// <summary>
    /// Echo Interface deletions to destination
    /// </summary>
    public interface IEchoer
    {
        #region Methods
        /// <summary>
        /// Clean Destination
        /// </summary>
        /// <param name="sourceItems">Source Items</param>
        Task CleanDestination(IEnumerable<IStorageItem> sourceItems);
        #endregion
    }
    #endregion
}