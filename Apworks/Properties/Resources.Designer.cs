﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apworks.Properties {
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
    internal class Resources {
        
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Apworks.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Failed to add the aggregate(s) to the repository..
        /// </summary>
        internal static string EX_ADD_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_ADD_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to begin the transaction for the domain repository..
        /// </summary>
        internal static string EX_BEGIN_TRANS_DOMAIN_REPOSITORY_FAIL {
            get {
                return ResourceManager.GetString("EX_BEGIN_TRANS_DOMAIN_REPOSITORY_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to begin transaction with the isolation level {0}..
        /// </summary>
        internal static string EX_BEGIN_TRANS_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_BEGIN_TRANS_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The where clause builder failed to build the field name for member {0}..
        /// </summary>
        internal static string EX_BUILD_FIELD_NAME_FAIL {
            get {
                return ResourceManager.GetString("EX_BUILD_FIELD_NAME_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to check the existance of the aggregate..
        /// </summary>
        internal static string EX_CHECK_EXIST_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_CHECK_EXIST_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to close the connection..
        /// </summary>
        internal static string EX_CLOSE_CONN_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_CLOSE_CONN_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to commit the domain repository Unit of Work..
        /// </summary>
        internal static string EX_COMMIT_DOMAIN_REPOSITORY_CONTEXT_FAIL {
            get {
                return ResourceManager.GetString("EX_COMMIT_DOMAIN_REPOSITORY_CONTEXT_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Either commit or rollback fails when disposing the storage device object..
        /// </summary>
        internal static string EX_COMMIT_ROLLBACK_WHEN_DISPOSE_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_COMMIT_ROLLBACK_WHEN_DISPOSE_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to commit the transaction..
        /// </summary>
        internal static string EX_COMMIT_TRANS_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_COMMIT_TRANS_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to delete the object from storage for type {0}, with the criteria {1}..
        /// </summary>
        internal static string EX_DELETE_FROM_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_DELETE_FROM_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize the object..
        /// </summary>
        internal static string EX_DESERIALIZE_FAIL {
            get {
                return ResourceManager.GetString("EX_DESERIALIZE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to dispose the domain repository..
        /// </summary>
        internal static string EX_DISPOSE_DOMAIN_REPOSITORY_FAIL {
            get {
                return ResourceManager.GetString("EX_DISPOSE_DOMAIN_REPOSITORY_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database connection string was not specified as it must be used by LINQ to SQL Domain Event Store. Check the configuration file to make sure the configuration section for event storage was defined and the connection string was provided properly..
        /// </summary>
        internal static string EX_DOMAINEVENTSTORE_INVALID_CONNSTR {
            get {
                return ResourceManager.GetString("EX_DOMAINEVENTSTORE_INVALID_CONNSTR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LINQ to SQL mapping xml was not defined as it must be used by the LINQ to SQL Domain Event Store. Check the configuration file to make sure the configuration section for event storage was defined and the mapping xml was specified property..
        /// </summary>
        internal static string EX_DOMAINEVENTSTORE_INVALID_MAPPING {
            get {
                return ResourceManager.GetString("EX_DOMAINEVENTSTORE_INVALID_MAPPING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of the configuration section is not valid as required. Required: {0}, Actual: {1}..
        /// </summary>
        internal static string EX_DOMAINEVENTSTORE_INVALID_TYPE {
            get {
                return ResourceManager.GetString("EX_DOMAINEVENTSTORE_INVALID_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression type {0} is not supported by current version of Apworks..
        /// </summary>
        internal static string EX_EXPRESSION_NODE_TYPE_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_EXPRESSION_NODE_TYPE_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurs when trying to find the aggregate(s) from the repository..
        /// </summary>
        internal static string EX_FIND_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_FIND_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find all the aggregates..
        /// </summary>
        internal static string EX_FINDALL_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_FINDALL_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General error occurs when generating the unique identifier..
        /// </summary>
        internal static string EX_GENERATE_UID_FAIL {
            get {
                return ResourceManager.GetString("EX_GENERATE_UID_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The where clause builder failed to generate the where clause for the expression {0}..
        /// </summary>
        internal static string EX_GENERATE_WHERE_CLAUSE_FAIL {
            get {
                return ResourceManager.GetString("EX_GENERATE_WHERE_CLAUSE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are some unsupported operations when generating where clause for the expression {0}..
        /// </summary>
        internal static string EX_GENERATE_WHERE_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_GENERATE_WHERE_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurs when trying to get the aggregate(s) from the repository..
        /// </summary>
        internal static string EX_GET_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_GET_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the identity generator..
        /// </summary>
        internal static string EX_GET_IDENTITY_GENERATOR_FAIL {
            get {
                return ResourceManager.GetString("EX_GET_IDENTITY_GENERATOR_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get all the aggregates from the repository..
        /// </summary>
        internal static string EX_GETALL_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_GETALL_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create the Relational Database Management System Domain Event Storage with the provided type {0}..
        /// </summary>
        internal static string EX_INIT_RDBMS_DOMAIN_EVENT_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_INIT_RDBMS_DOMAIN_EVENT_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize the RDBMS storage device..
        /// </summary>
        internal static string EX_INIT_RDBMS_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_INIT_RDBMS_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize the XML mapping resolver with the given file {0}..
        /// </summary>
        internal static string EX_INIT_XML_STORAGE_MAPPING_FAIL {
            get {
                return ResourceManager.GetString("EX_INIT_XML_STORAGE_MAPPING_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to insert the data object into the storage with the data {0}..
        /// </summary>
        internal static string EX_INSERT_INTO_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_INSERT_INTO_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration element {0}, which is required by Apworks, was not configured properly..
        /// </summary>
        internal static string EX_INVALID_CONFIG_ELEMENT {
            get {
                return ResourceManager.GetString("EX_INVALID_CONFIG_ELEMENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The method {0} going to be used as domain event handler doesn&apos;t have a correct signature..
        /// </summary>
        internal static string EX_INVALID_HANDLER_SIGNATURE {
            get {
                return ResourceManager.GetString("EX_INVALID_HANDLER_SIGNATURE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of the arguments used by the method call should only be one..
        /// </summary>
        internal static string EX_INVALID_METHOD_CALL_ARGUMENT_NUMBER {
            get {
                return ResourceManager.GetString("EX_INVALID_METHOD_CALL_ARGUMENT_NUMBER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize and load the object container..
        /// </summary>
        internal static string EX_LOAD_OBJ_CONTAINER_FAIL {
            get {
                return ResourceManager.GetString("EX_LOAD_OBJ_CONTAINER_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the property member of the given data object and the field member is supported. Current member type is {0}..
        /// </summary>
        internal static string EX_MEMBER_TYPE_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_MEMBER_TYPE_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of the argument that used by the method should be either Constant or Member. Currently it is {0}..
        /// </summary>
        internal static string EX_METHOD_CALL_ARGUMENT_TYPE_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_METHOD_CALL_ARGUMENT_TYPE_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the StartsWith, EndsWith and Equals methods are supported. Currently it is {0}..
        /// </summary>
        internal static string EX_METHOD_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_METHOD_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process of the expression type {0} is not supported..
        /// </summary>
        internal static string EX_PROCESS_NODE_NOT_SUPPORT {
            get {
                return ResourceManager.GetString("EX_PROCESS_NODE_NOT_SUPPORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove the aggregate from the repository..
        /// </summary>
        internal static string EX_REMOVE_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_REMOVE_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to rollback the transaction from the domain repository..
        /// </summary>
        internal static string EX_ROLLBACK_TRANS_DOMAIN_REPOSITORY_FAIL {
            get {
                return ResourceManager.GetString("EX_ROLLBACK_TRANS_DOMAIN_REPOSITORY_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to rollback the transaction..
        /// </summary>
        internal static string EX_ROLLBACK_TRANS_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_ROLLBACK_TRANS_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to select the first only object for data type {0} with the property bag {1}..
        /// </summary>
        internal static string EX_SELECT_FIRSTONLY_FAIL {
            get {
                return ResourceManager.GetString("EX_SELECT_FIRSTONLY_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to select data objects from the storage for data type {0}, with the criteria {1}, sorting fields {2} and sort order {3}..
        /// </summary>
        internal static string EX_SELECT_FROM_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_SELECT_FROM_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to serialize the object..
        /// </summary>
        internal static string EX_SERIALIZE_FAIL {
            get {
                return ResourceManager.GetString("EX_SERIALIZE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The transaction has already completed..
        /// </summary>
        internal static string EX_STORAGE_TRANS_COMPLETED {
            get {
                return ResourceManager.GetString("EX_STORAGE_TRANS_COMPLETED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update the aggregate in the repository..
        /// </summary>
        internal static string EX_UPDATE_AGGREGATE_FAIL {
            get {
                return ResourceManager.GetString("EX_UPDATE_AGGREGATE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update the data object of type {0} from the storage, with the new values {1} and the selection criteria {2}..
        /// </summary>
        internal static string EX_UPDATE_FROM_STORAGE_FAIL {
            get {
                return ResourceManager.GetString("EX_UPDATE_FROM_STORAGE_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process the constant expression {0}..
        /// </summary>
        internal static string EX_VISIT_CONSTANT_FAIL {
            get {
                return ResourceManager.GetString("EX_VISIT_CONSTANT_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process the member expression {0}..
        /// </summary>
        internal static string EX_VISIT_MEMBER_FAIL {
            get {
                return ResourceManager.GetString("EX_VISIT_MEMBER_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to process the method call expression {0}..
        /// </summary>
        internal static string EX_VISIT_METHOD_CALL_FAIL {
            get {
                return ResourceManager.GetString("EX_VISIT_METHOD_CALL_FAIL", resourceCulture);
            }
        }
    }
}
