﻿using UnityEngine;

/// <summary>
///     Contains folder paths for various types of files.
/// </summary>
public class FilePath {

    #region Root Directories

    /// <summary>
    ///     Root directory path of where persistent (remains after application
    ///     is closed) cached files are stored.
    /// </summary>
    public static readonly string PersistentRoot = Application.persistentDataPath;

    /// <summary>
    ///     Root directory path of where temporary cached files are stored.
    /// </summary>
    public static readonly string TemporaryRoot = Application.temporaryCachePath;

    /// <summary>
    ///     Root directory path of where asset files that are shipped with the applications are stored.
    /// </summary>
    public static readonly string StreamingAssetsRoot = Application.streamingAssetsPath;

    #endregion


    #region File Type Specific

    public const string DigitalElevationModel = "dem";

    public const string Texture = "textures";

    public const string Test = "test";

    #endregion


    #region Vendor Specific

    public const string JetPropulsionLaboratory = "jpl";

    #endregion

}