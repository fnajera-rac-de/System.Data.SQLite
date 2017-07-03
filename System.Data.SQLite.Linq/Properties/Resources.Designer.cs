/********************************************************
 * ADO.NET 2.0 Data Provider for SQLite Version 3.X
 * Written by Robert Simpson (robert@blackcastlesoft.com)
 *
 * Released to the public domain, use at your own risk!
 ********************************************************/

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#if USE_ENTITY_FRAMEWORK_6
namespace System.Data.SQLite.EF6.Properties
#else
namespace System.Data.SQLite.Linq.Properties
#endif
{
    using System;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal sealed class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Data.SQLite.Properties", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CREATE TEMP VIEW SCHEMACONSTRAINTCOLUMNS AS
        ///SELECT CONSTRAINT_CATALOG, NULL AS CONSTRAINT_SCHEMA, CONSTRAINT_NAME, TABLE_CATALOG, NULL AS TABLE_SCHEMA, TABLE_NAME, COLUMN_NAME
        ///FROM TEMP.SCHEMAINDEXCOLUMNS
        ///UNION
        ///SELECT CONSTRAINT_CATALOG, NULL, CONSTRAINT_NAME, TABLE_CATALOG, NULL, TABLE_NAME, FKEY_FROM_COLUMN
        ///FROM TEMP.SCHEMAFOREIGNKEYS;.
        /// </summary>
        internal static string SQL_CONSTRAINTCOLUMNS {
            get {
                return ResourceManager.GetString("SQL_CONSTRAINTCOLUMNS", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CREATE TEMP VIEW SCHEMACONSTRAINTS AS
        ///SELECT INDEX_CATALOG AS CONSTRAINT_CATALOG, NULL AS CONSTRAINT_SCHEMA, INDEX_NAME AS CONSTRAINT_NAME, TABLE_CATALOG, NULL AS TABLE_SCHEMA, TABLE_NAME, &apos;PRIMARY KEY&apos; AS CONSTRAINT_TYPE, 0 AS IS_DEFERRABLE, 0 AS INITIALLY_DEFERRED, NULL AS CHECK_CLAUSE
        ///FROM TEMP.SCHEMAINDEXES WHERE PRIMARY_KEY = 1
        ///UNION
        ///SELECT INDEX_CATALOG, NULL, INDEX_NAME, TABLE_CATALOG, NULL, TABLE_NAME, &apos;UNIQUE&apos;, 0, 0, NULL
        ///FROM TEMP.SCHEMAINDEXES WHERE PRIMARY_KEY = 0 AND [UNIQUE] = 1
        ///UNION
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SQL_CONSTRAINTS {
            get {
                return ResourceManager.GetString("SQL_CONSTRAINTS", resourceCulture);
            }
        }
    }
}
