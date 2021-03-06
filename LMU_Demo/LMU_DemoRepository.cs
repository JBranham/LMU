﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace LMU_Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the LMU_DemoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("fe32db1c-b71f-4941-9261-db2e4bebf7f1")]
    public partial class LMU_DemoRepository : RepoGenBaseFolder
    {
        static LMU_DemoRepository instance = new LMU_DemoRepository();
        LMU_DemoRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        LMU_DemoRepositoryFolders.ExplorerAppFolder _explorer;

        /// <summary>
        /// Gets the singleton class instance representing the LMU_DemoRepository element repository.
        /// </summary>
        [RepositoryFolder("fe32db1c-b71f-4941-9261-db2e4bebf7f1")]
        public static LMU_DemoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public LMU_DemoRepository() 
            : base("LMU_DemoRepository", "/", null, 0, false, "fe32db1c-b71f-4941-9261-db2e4bebf7f1", ".\\RepositoryImages\\LMU_DemoRepositoryfe32db1c.rximgres")
        {
            _applicationundertest = new LMU_DemoRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _explorer = new LMU_DemoRepositoryFolders.ExplorerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("fe32db1c-b71f-4941-9261-db2e4bebf7f1")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("217d2646-e3ce-4113-b195-ff52ac80b4a5")]
        public virtual LMU_DemoRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("c461f858-0cd2-455d-a7ac-40a02e770e2f")]
        public virtual LMU_DemoRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class LMU_DemoRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("217d2646-e3ce-4113-b195-ff52ac80b4a5")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _firstnameInfo;
            RepoItemInfo _lastnameInfo;
            RepoItemInfo _musicInfo;
            RepoItemInfo _genderInfo;
            RepoItemInfo _inputtagaddInfo;
            RepoItemInfo _countInfo;
            RepoItemInfo _clearInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "217d2646-e3ce-4113-b195-ff52ac80b4a5", "")
            {
                _firstnameInfo = new RepoItemInfo(this, "FirstName", ".//input[#'FirstName']", 60000, null, "254859b6-d55a-4a81-ac27-5f09750e334d");
                _lastnameInfo = new RepoItemInfo(this, "LastName", ".//input[#'LastName']", 60000, null, "1be1ea6c-766a-436a-97e8-84ca9e7b9618");
                _musicInfo = new RepoItemInfo(this, "Music", ".//select[#'Category']/option[@value='Music']", 60000, null, "9e1785f5-cf07-4939-b6ab-88edc6b2119b");
                _genderInfo = new RepoItemInfo(this, "Gender", ".//td[#'gender']//input[@name='Gender' and @type='radio' and @value='male']", 60000, null, "efa32a0f-7810-47cc-9e96-ec46bd2a8568");
                _inputtagaddInfo = new RepoItemInfo(this, "InputTagAdd", ".//input[#'Add']", 60000, null, "0a43ac4a-4423-4f23-9e16-aae7cc71dd32");
                _countInfo = new RepoItemInfo(this, "Count", ".//td[#'count']", 60000, null, "6a6769ff-a175-4fa5-8e59-43ce58705729");
                _clearInfo = new RepoItemInfo(this, "Clear", ".//input[#'Clear']", 60000, null, "527bcdb1-0194-4e14-99e5-31f161b5eac5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("217d2646-e3ce-4113-b195-ff52ac80b4a5")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("217d2646-e3ce-4113-b195-ff52ac80b4a5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FirstName item.
            /// </summary>
            [RepositoryItem("254859b6-d55a-4a81-ac27-5f09750e334d")]
            public virtual Ranorex.InputTag FirstName
            {
                get
                {
                    return _firstnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FirstName item info.
            /// </summary>
            [RepositoryItemInfo("254859b6-d55a-4a81-ac27-5f09750e334d")]
            public virtual RepoItemInfo FirstNameInfo
            {
                get
                {
                    return _firstnameInfo;
                }
            }

            /// <summary>
            /// The LastName item.
            /// </summary>
            [RepositoryItem("1be1ea6c-766a-436a-97e8-84ca9e7b9618")]
            public virtual Ranorex.InputTag LastName
            {
                get
                {
                    return _lastnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LastName item info.
            /// </summary>
            [RepositoryItemInfo("1be1ea6c-766a-436a-97e8-84ca9e7b9618")]
            public virtual RepoItemInfo LastNameInfo
            {
                get
                {
                    return _lastnameInfo;
                }
            }

            /// <summary>
            /// The Music item.
            /// </summary>
            [RepositoryItem("9e1785f5-cf07-4939-b6ab-88edc6b2119b")]
            public virtual Ranorex.OptionTag Music
            {
                get
                {
                    return _musicInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Music item info.
            /// </summary>
            [RepositoryItemInfo("9e1785f5-cf07-4939-b6ab-88edc6b2119b")]
            public virtual RepoItemInfo MusicInfo
            {
                get
                {
                    return _musicInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("efa32a0f-7810-47cc-9e96-ec46bd2a8568")]
            public virtual Ranorex.InputTag Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("efa32a0f-7810-47cc-9e96-ec46bd2a8568")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }

            /// <summary>
            /// The InputTagAdd item.
            /// </summary>
            [RepositoryItem("0a43ac4a-4423-4f23-9e16-aae7cc71dd32")]
            public virtual Ranorex.InputTag InputTagAdd
            {
                get
                {
                    return _inputtagaddInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagAdd item info.
            /// </summary>
            [RepositoryItemInfo("0a43ac4a-4423-4f23-9e16-aae7cc71dd32")]
            public virtual RepoItemInfo InputTagAddInfo
            {
                get
                {
                    return _inputtagaddInfo;
                }
            }

            /// <summary>
            /// The Count item.
            /// </summary>
            [RepositoryItem("6a6769ff-a175-4fa5-8e59-43ce58705729")]
            public virtual Ranorex.TdTag Count
            {
                get
                {
                    return _countInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The Count item info.
            /// </summary>
            [RepositoryItemInfo("6a6769ff-a175-4fa5-8e59-43ce58705729")]
            public virtual RepoItemInfo CountInfo
            {
                get
                {
                    return _countInfo;
                }
            }

            /// <summary>
            /// The Clear item.
            /// </summary>
            [RepositoryItem("527bcdb1-0194-4e14-99e5-31f161b5eac5")]
            public virtual Ranorex.InputTag Clear
            {
                get
                {
                    return _clearInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Clear item info.
            /// </summary>
            [RepositoryItemInfo("527bcdb1-0194-4e14-99e5-31f161b5eac5")]
            public virtual RepoItemInfo ClearInfo
            {
                get
                {
                    return _clearInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("c461f858-0cd2-455d-a7ac-40a02e770e2f")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _startInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "c461f858-0cd2-455d-a7ac-40a02e770e2f", "")
            {
                _startInfo = new RepoItemInfo(this, "Start", "?/?/button[@accessiblename='Start']", 60000, null, "8db4fd11-01e6-48e8-a812-bbd4c8a71ba9");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c461f858-0cd2-455d-a7ac-40a02e770e2f")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c461f858-0cd2-455d-a7ac-40a02e770e2f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Start item.
            /// </summary>
            [RepositoryItem("8db4fd11-01e6-48e8-a812-bbd4c8a71ba9")]
            public virtual Ranorex.Button Start
            {
                get
                {
                    return _startInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Start item info.
            /// </summary>
            [RepositoryItemInfo("8db4fd11-01e6-48e8-a812-bbd4c8a71ba9")]
            public virtual RepoItemInfo StartInfo
            {
                get
                {
                    return _startInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
