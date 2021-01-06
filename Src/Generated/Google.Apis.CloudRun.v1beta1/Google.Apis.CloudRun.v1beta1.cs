// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudRun.v1beta1
{
    /// <summary>The CloudRun Service.</summary>
    public class CloudRunService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRunService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRunService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Customresourcedefinitions = new CustomresourcedefinitionsResource(this);
            Namespaces = new NamespacesResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "run";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://run.googleapis.com/";
        #else
            "https://run.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://run.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Run Admin API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Run Admin API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Customresourcedefinitions resource.</summary>
        public virtual CustomresourcedefinitionsResource Customresourcedefinitions { get; }

        /// <summary>Gets the Namespaces resource.</summary>
        public virtual NamespacesResource Namespaces { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudRun requests.</summary>
    public abstract class CloudRunBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudRunBaseServiceRequest instance.</summary>
        protected CloudRunBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudRun parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "customresourcedefinitions" collection of methods.</summary>
    public class CustomresourcedefinitionsResource
    {
        private const string Resource = "customresourcedefinitions";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomresourcedefinitionsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Rpc to list custom resource definitions.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Rpc to list custom resource definitions.</summary>
        public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1beta1.Data.ListCustomResourceDefinitionsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Optional encoded string to continue paging.</summary>
            [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Continue { get; set; }

            /// <summary>
            /// Allows to filter resources based on a specific value for a field name. Send this in a query string
            /// format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string FieldSelector { get; set; }

            /// <summary>Not currently used by Cloud Run.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

            /// <summary>
            /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and notIn.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string LabelSelector { get; set; }

            [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> Limit { get; set; }

            /// <summary>The project ID or project number from which the storages should be listed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>
            /// The baseline resource version from which the list or watch operation should start. Not currently used by
            /// Cloud Run.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ResourceVersion { get; set; }

            /// <summary>
            /// Flag that indicates that the client expects to watch this resource as well. Not currently used by Cloud
            /// Run.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Watch { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "apis/apiextensions.k8s.io/v1beta1/customresourcedefinitions";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                {
                    Name = "continue",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                {
                    Name = "fieldSelector",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                {
                    Name = "includeUninitialized",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                {
                    Name = "labelSelector",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                {
                    Name = "limit",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                {
                    Name = "resourceVersion",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                {
                    Name = "watch",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "namespaces" collection of methods.</summary>
    public class NamespacesResource
    {
        private const string Resource = "namespaces";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public NamespacesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Customresourcedefinitions = new CustomresourcedefinitionsResource(service);
        }

        /// <summary>Gets the Customresourcedefinitions resource.</summary>
        public virtual CustomresourcedefinitionsResource Customresourcedefinitions { get; }

        /// <summary>The "customresourcedefinitions" collection of methods.</summary>
        public class CustomresourcedefinitionsResource
        {
            private const string Resource = "customresourcedefinitions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CustomresourcedefinitionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Rpc to get information about a CustomResourceDefinition.</summary>
            /// <param name="name">
            /// The name of the CustomResourceDefinition being retrieved. If needed, replace {namespace_id} with the
            /// project ID.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Rpc to get information about a CustomResourceDefinition.</summary>
            public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1beta1.Data.CustomResourceDefinition>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// The name of the CustomResourceDefinition being retrieved. If needed, replace {namespace_id} with the
                /// project ID.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "apis/apiextensions.k8s.io/v1beta1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^namespaces/[^/]+/customresourcedefinitions/[^/]+$",
                    });
                }
            }
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Customresourcedefinitions = new CustomresourcedefinitionsResource(service);
            }

            /// <summary>Gets the Customresourcedefinitions resource.</summary>
            public virtual CustomresourcedefinitionsResource Customresourcedefinitions { get; }

            /// <summary>The "customresourcedefinitions" collection of methods.</summary>
            public class CustomresourcedefinitionsResource
            {
                private const string Resource = "customresourcedefinitions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomresourcedefinitionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Rpc to get information about a CustomResourceDefinition.</summary>
                /// <param name="name">
                /// The name of the CustomResourceDefinition being retrieved. If needed, replace {namespace_id} with the
                /// project ID.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Rpc to get information about a CustomResourceDefinition.</summary>
                public class GetRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1beta1.Data.CustomResourceDefinition>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// The name of the CustomResourceDefinition being retrieved. If needed, replace {namespace_id} with
                    /// the project ID.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/customresourcedefinitions/[^/]+$",
                        });
                    }
                }

                /// <summary>Rpc to list custom resource definitions.</summary>
                /// <param name="parent">
                /// The project ID or project number from which the storages should be listed.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Rpc to list custom resource definitions.</summary>
                public class ListRequest : CloudRunBaseServiceRequest<Google.Apis.CloudRun.v1beta1.Data.ListCustomResourceDefinitionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>The project ID or project number from which the storages should be listed.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Optional encoded string to continue paging.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("continue", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Continue { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a specific value for a field name. Send this in a query
                    /// string format. i.e. 'metadata.name%3Dlorem'. Not currently used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FieldSelector { get; set; }

                    /// <summary>Not currently used by Cloud Run.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("includeUninitialized", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> IncludeUninitialized { get; set; }

                    /// <summary>
                    /// Allows to filter resources based on a label. Supported operations are =, !=, exists, in, and
                    /// notIn.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("labelSelector", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string LabelSelector { get; set; }

                    [Google.Apis.Util.RequestParameterAttribute("limit", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> Limit { get; set; }

                    /// <summary>
                    /// The baseline resource version from which the list or watch operation should start. Not currently
                    /// used by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resourceVersion", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string ResourceVersion { get; set; }

                    /// <summary>
                    /// Flag that indicates that the client expects to watch this resource as well. Not currently used
                    /// by Cloud Run.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("watch", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<bool> Watch { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta1/{+parent}/customresourcedefinitions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("continue", new Google.Apis.Discovery.Parameter
                        {
                            Name = "continue",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("includeUninitialized", new Google.Apis.Discovery.Parameter
                        {
                            Name = "includeUninitialized",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("labelSelector", new Google.Apis.Discovery.Parameter
                        {
                            Name = "labelSelector",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("limit", new Google.Apis.Discovery.Parameter
                        {
                            Name = "limit",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("resourceVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resourceVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("watch", new Google.Apis.Discovery.Parameter
                        {
                            Name = "watch",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.CloudRun.v1beta1.Data
{
    /// <summary>CustomResourceColumnDefinition specifies a column for server side printing.</summary>
    public class CustomResourceColumnDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>description is a human readable description of this column. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// format is an optional OpenAPI type definition for this column. The 'name' format is applied to the primary
        /// identifier column to assist in clients identifying column is the resource name. See
        /// https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for more. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>JSONPath is a simple JSON path, i.e. with array notation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("jsonPath")]
        public virtual string JsonPath { get; set; }

        /// <summary>name is a human readable name for the column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// priority is an integer defining the relative importance of this column compared to others. Lower numbers are
        /// considered higher priority. Columns that may be omitted in limited space scenarios should be given a higher
        /// priority. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; }

        /// <summary>
        /// type is an OpenAPI type definition for this column. See
        /// https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types for more.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CustomResourceDefinition represents a resource that should be exposed on the API server. Its name MUST be in the
    /// format &amp;lt;.spec.name&amp;gt;.&amp;lt;.spec.group&amp;gt;.
    /// </summary>
    public class CustomResourceDefinition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "k8s.apiextensions.io/v1beta1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>The kind of resource, in this case always "CustomResourceDefinition".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this CustomResourceDefinition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ObjectMeta Metadata { get; set; }

        /// <summary>Spec describes how the user wants the resources to appear</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual CustomResourceDefinitionSpec Spec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition</summary>
    public class CustomResourceDefinitionNames : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Categories is a list of grouped resources custom resources belong to (e.g. 'all') +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("categories")]
        public virtual System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>Kind is the serialized kind of the resource. It is normally CamelCase and singular.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>
        /// ListKind is the serialized kind of the list for this resource. Defaults to List. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listKind")]
        public virtual string ListKind { get; set; }

        /// <summary>
        /// Plural is the plural name of the resource to serve. It must match the name of the
        /// CustomResourceDefinition-registration too: plural.group and it must be all lowercase.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("plural")]
        public virtual string Plural { get; set; }

        /// <summary>ShortNames are short names for the resource. It must be all lowercase. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortNames")]
        public virtual System.Collections.Generic.IList<string> ShortNames { get; set; }

        /// <summary>
        /// Singular is the singular name of the resource. It must be all lowercase Defaults to lowercased +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singular")]
        public virtual string Singular { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomResourceDefinitionSpec describes how a user wants their resource to appear</summary>
    public class CustomResourceDefinitionSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// AdditionalPrinterColumns are additional columns shown e.g. in kubectl next to the name. Defaults to a
        /// created-at column. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalPrinterColumns")]
        public virtual System.Collections.Generic.IList<CustomResourceColumnDefinition> AdditionalPrinterColumns { get; set; }

        /// <summary>Group is the group this resource belongs in</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Names are the names used to describe this custom resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("names")]
        public virtual CustomResourceDefinitionNames Names { get; set; }

        /// <summary>
        /// Scope indicates whether this resource is cluster or namespace scoped. Default is namespaced
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>Subresources describes the subresources for CustomResources +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subresources")]
        public virtual CustomResourceSubresources Subresources { get; set; }

        /// <summary>Validation describes the validation methods for CustomResources +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("validation")]
        public virtual CustomResourceValidation Validation { get; set; }

        /// <summary>
        /// Version is the version this resource belongs in Should be always first item in Versions field if provided.
        /// Optional, but at least one of Version or Versions must be set. Deprecated: Please use `Versions`. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>
        /// Versions is the list of all supported versions for this resource. If Version field is provided, this field
        /// is optional. Validation: All versions must use the same validation schema for now. i.e., top level
        /// Validation field is applied to all of these versions. Order: The version name will be used to compute the
        /// order. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are
        /// ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major
        /// version), then optionally the string "alpha" or "beta" and another number (the minor version). These are
        /// sorted first by GA &amp;gt; beta &amp;gt; alpha (where GA is a version with no suffix such as beta or
        /// alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10,
        /// v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<CustomResourceDefinitionVersion> Versions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class CustomResourceDefinitionVersion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name is the version name, e.g. “v1”, “v2beta1”, etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Served is a flag enabling/disabling this version from being served via REST APIs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("served")]
        public virtual System.Nullable<bool> Served { get; set; }

        /// <summary>
        /// Storage flags the version as storage version. There must be exactly one flagged as storage version.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("storage")]
        public virtual System.Nullable<bool> Storage { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CustomResourceSubresourceScale defines how to serve the scale subresource for CustomResources.
    /// </summary>
    public class CustomResourceSubresourceScale : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// LabelSelectorPath defines the JSON path inside of a CustomResource that corresponds to
        /// Scale.Status.Selector. Only JSON paths without the array notation are allowed. Must be a JSON Path under
        /// .status. Must be set to work with HPA. If there is no value under the given path in the CustomResource, the
        /// status label selector value in the /scale subresource will default to the empty string. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labelSelectorPath")]
        public virtual string LabelSelectorPath { get; set; }

        /// <summary>
        /// SpecReplicasPath defines the JSON path inside of a CustomResource that corresponds to Scale.Spec.Replicas.
        /// Only JSON paths without the array notation are allowed. Must be a JSON Path under .spec. If there is no
        /// value under the given path in the CustomResource, the /scale subresource will return an error on GET.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("specReplicasPath")]
        public virtual string SpecReplicasPath { get; set; }

        /// <summary>
        /// StatusReplicasPath defines the JSON path inside of a CustomResource that corresponds to
        /// Scale.Status.Replicas. Only JSON paths without the array notation are allowed. Must be a JSON Path under
        /// .status. If there is no value under the given path in the CustomResource, the status replica value in the
        /// /scale subresource will default to 0.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusReplicasPath")]
        public virtual string StatusReplicasPath { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// CustomResourceSubresourceStatus defines how to serve the status subresource for CustomResources. Status is
    /// represented by the `.status` JSON path inside of a CustomResource. When set, * exposes a /status subresource for
    /// the custom resource * PUT requests to the /status subresource take a custom resource object, and ignore changes
    /// to anything except the status stanza * PUT/POST/PATCH requests to the custom resource ignore changes to the
    /// status stanza
    /// </summary>
    public class CustomResourceSubresourceStatus : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomResourceSubresources defines the status and scale subresources for CustomResources.</summary>
    public class CustomResourceSubresources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Scale denotes the scale subresource for CustomResources +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scale")]
        public virtual CustomResourceSubresourceScale Scale { get; set; }

        /// <summary>Status denotes the status subresource for CustomResources +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual CustomResourceSubresourceStatus Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CustomResourceValidation is a list of validation methods for CustomResources.</summary>
    public class CustomResourceValidation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OpenAPIV3Schema is the OpenAPI v3 schema to be validated against. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openAPIV3Schema")]
        public virtual JSONSchemaProps OpenAPIV3Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>ExternalDocumentation allows referencing an external resource for extended documentation.</summary>
    public class ExternalDocumentation : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSON represents any valid JSON value. These types are supported: bool, int64, float64, string, []interface{},
    /// map[string]interface{} and nil.
    /// </summary>
    public class JSON : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("raw")]
        public virtual string Raw { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSONSchemaProps is a JSON-Schema following Specification Draft 4 (http://json-schema.org/).</summary>
    public class JSONSchemaProps : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("additionalItems")]
        public virtual JSONSchemaPropsOrBool AdditionalItems { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("additionalProperties")]
        public virtual JSONSchemaPropsOrBool AdditionalProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("allOf")]
        public virtual System.Collections.Generic.IList<JSONSchemaProps> AllOf { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("anyOf")]
        public virtual System.Collections.Generic.IList<JSONSchemaProps> AnyOf { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("default")]
        public virtual JSON Default__ { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("definitions")]
        public virtual System.Collections.Generic.IDictionary<string, JSONSchemaProps> Definitions { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("dependencies")]
        public virtual System.Collections.Generic.IDictionary<string, JSONSchemaPropsOrStringArray> Dependencies { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("enum")]
        public virtual System.Collections.Generic.IList<string> Enum__ { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("example")]
        public virtual JSON Example { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveMaximum")]
        public virtual System.Nullable<bool> ExclusiveMaximum { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("exclusiveMinimum")]
        public virtual System.Nullable<bool> ExclusiveMinimum { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("externalDocs")]
        public virtual ExternalDocumentation ExternalDocs { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual JSONSchemaPropsOrArray Items { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxItems")]
        public virtual System.Nullable<long> MaxItems { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxLength")]
        public virtual System.Nullable<long> MaxLength { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maxProperties")]
        public virtual System.Nullable<long> MaxProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("maximum")]
        public virtual System.Nullable<double> Maximum { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minItems")]
        public virtual System.Nullable<long> MinItems { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minLength")]
        public virtual System.Nullable<long> MinLength { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minProperties")]
        public virtual System.Nullable<long> MinProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("minimum")]
        public virtual System.Nullable<double> Minimum { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("multipleOf")]
        public virtual System.Nullable<double> MultipleOf { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("not")]
        public virtual JSONSchemaProps Not { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("oneOf")]
        public virtual System.Collections.Generic.IList<JSONSchemaProps> OneOf { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("pattern")]
        public virtual string Pattern { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("patternProperties")]
        public virtual System.Collections.Generic.IDictionary<string, JSONSchemaProps> PatternProperties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, JSONSchemaProps> Properties { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("ref")]
        public virtual string Ref__ { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Collections.Generic.IList<string> Required { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual string Schema { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("uniqueItems")]
        public virtual System.Nullable<bool> UniqueItems { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSONSchemaPropsOrArray represents a value that can either be a JSONSchemaProps or an array of JSONSchemaProps.
    /// Mainly here for serialization purposes.
    /// </summary>
    public class JSONSchemaPropsOrArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("jsonSchemas")]
        public virtual System.Collections.Generic.IList<JSONSchemaProps> JsonSchemas { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual JSONSchemaProps Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// JSONSchemaPropsOrBool represents JSONSchemaProps or a boolean value. Defaults to true for the boolean property.
    /// </summary>
    public class JSONSchemaPropsOrBool : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("allows")]
        public virtual System.Nullable<bool> Allows { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual JSONSchemaProps Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>JSONSchemaPropsOrStringArray represents a JSONSchemaProps or a string array.</summary>
    public class JSONSchemaPropsOrStringArray : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("property")]
        public virtual System.Collections.Generic.IList<string> Property { get; set; }

        [Newtonsoft.Json.JsonPropertyAttribute("schema")]
        public virtual JSONSchemaProps Schema { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class ListCustomResourceDefinitionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API version for this call such as "k8s.apiextensions.io/v1beta1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>List of CustomResourceDefinitions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CustomResourceDefinition> Items { get; set; }

        /// <summary>The kind of this resource, in this case "CustomResourceDefinitionList".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Metadata associated with this CustomResourceDefinition list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual ListMeta Metadata { get; set; }

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A
    /// resource may have only one of {ObjectMeta, ListMeta}.
    /// </summary>
    public class ListMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// continue may be set if the user set a limit on the number of items returned, and indicates that the server
        /// has more data available. The value is opaque and may be used to issue another request to the endpoint that
        /// served this list to retrieve the next set of available objects. Continuing a list may not be possible if the
        /// server configuration has changed or more than a few minutes have passed. The resourceVersion field returned
        /// when using this continue value will be identical to the value in the first response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("continue")]
        public virtual string Continue__ { get; set; }

        /// <summary>
        /// String that identifies the server's internal version of this object that can be used by clients to determine
        /// when objects have changed. Value must be treated as opaque by clients and passed unmodified back to the
        /// server. Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#concurrency-control-and-consistency
        /// +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>SelfLink is a URL representing this object. Populated by the system. Read-only. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// k8s.io.apimachinery.pkg.apis.meta.v1.ObjectMeta is metadata that all persisted resources must have, which
    /// includes all objects users must create.
    /// </summary>
    public class ObjectMeta : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// (Optional) Annotations is an unstructured key value map stored with a resource that may be set by external
        /// tools to store and retrieve arbitrary metadata. They are not queryable and should be preserved when
        /// modifying objects. More info: http://kubernetes.io/docs/user-guide/annotations
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotations")]
        public virtual System.Collections.Generic.IDictionary<string, string> Annotations { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported The name of the cluster
        /// which the object belongs to. This is used to distinguish resources with same name and namespace in different
        /// clusters. This field is not set anywhere right now and apiserver is going to ignore it if set in create or
        /// update request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clusterName")]
        public virtual string ClusterName { get; set; }

        /// <summary>
        /// (Optional) CreationTimestamp is a timestamp representing the server time when this object was created. It is
        /// not guaranteed to be set in happens-before order across separate operations. Clients may not set this value.
        /// It is represented in RFC3339 form and is in UTC. Populated by the system. Read-only. Null for lists. More
        /// info: https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTimestamp")]
        public virtual object CreationTimestamp { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported Number of seconds allowed
        /// for this object to gracefully terminate before it will be removed from the system. Only set when
        /// deletionTimestamp is also set. May only be shortened. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionGracePeriodSeconds")]
        public virtual System.Nullable<int> DeletionGracePeriodSeconds { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported DeletionTimestamp is RFC
        /// 3339 date and time at which this resource will be deleted. This field is set by the server when a graceful
        /// deletion is requested by the user, and is not directly settable by a client. The resource is expected to be
        /// deleted (no longer visible from resource lists, and not reachable by name) after the time in this field,
        /// once the finalizers list is empty. As long as the finalizers list contains items, deletion is blocked. Once
        /// the deletionTimestamp is set, this value may not be unset or be set further into the future, although it may
        /// be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod
        /// is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers
        /// in the pod. After that 30 seconds, the Kubelet will send a hard termination signal (SIGKILL) to the
        /// container and after cleanup, remove the pod from the API. In the presence of network partitions, this object
        /// may still exist after this timestamp, until an administrator or automated process can determine the resource
        /// is fully terminated. If not set, graceful deletion of the object has not been requested. Populated by the
        /// system when a graceful deletion is requested. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deletionTimestamp")]
        public virtual object DeletionTimestamp { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported Must be empty before the
        /// object is deleted from the registry. Each entry is an identifier for the responsible component that will
        /// remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can
        /// only be removed. +patchStrategy=merge
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finalizers")]
        public virtual System.Collections.Generic.IList<string> Finalizers { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported GenerateName is an
        /// optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided.
        /// If this field is used, the name returned to the client will be different than the name passed. This value
        /// will also be combined with a unique suffix. The provided value has the same validation rules as the Name
        /// field, and may be truncated by the length of the suffix required to make the value unique on the server. If
        /// this field is specified and the generated name exists, the server will NOT return a 409 - instead, it will
        /// either return 201 Created or 500 with Reason ServerTimeout indicating a unique name could not be found in
        /// the time allotted, and the client should retry (optionally after the time indicated in the Retry-After
        /// header). Applied only if Name is not specified. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#idempotency string generateName = 2;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generateName")]
        public virtual string GenerateName { get; set; }

        /// <summary>
        /// (Optional) A sequence number representing a specific generation of the desired state. Populated by the
        /// system. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generation")]
        public virtual System.Nullable<int> Generation { get; set; }

        /// <summary>
        /// (Optional) Map of string keys and values that can be used to organize and categorize (scope and select)
        /// objects. May match selectors of replication controllers and routes. More info:
        /// http://kubernetes.io/docs/user-guide/labels
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Name must be unique within a namespace, within a Cloud Run region. Is required when creating resources,
        /// although some resources may allow a client to request the generation of an appropriate name automatically.
        /// Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More
        /// info: http://kubernetes.io/docs/user-guide/identifiers#names +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace defines the space within each name must be unique, within a Cloud Run region. In Cloud Run the
        /// namespace must be equal to either the project ID or project number.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; }

        /// <summary>
        /// (Optional) Cloud Run fully managed: not supported Cloud Run for Anthos: supported List of objects that own
        /// this object. If ALL objects in the list have been deleted, this object will be garbage collected.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerReferences")]
        public virtual System.Collections.Generic.IList<OwnerReference> OwnerReferences { get; set; }

        /// <summary>
        /// (Optional) An opaque value that represents the internal version of this object that can be used by clients
        /// to determine when objects have changed. May be used for optimistic concurrency, change detection, and the
        /// watch operation on a resource or set of resources. Clients must treat these values as opaque and passed
        /// unmodified back to the server. They may only be valid for a particular resource or set of resources.
        /// Populated by the system. Read-only. Value must be treated as opaque by clients. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceVersion")]
        public virtual string ResourceVersion { get; set; }

        /// <summary>
        /// (Optional) SelfLink is a URL representing this object. Populated by the system. Read-only. string selfLink =
        /// 4;
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("selfLink")]
        public virtual string SelfLink { get; set; }

        /// <summary>
        /// (Optional) UID is the unique in time and space value for this object. It is typically generated by the
        /// server on successful creation of a resource and is not allowed to change on PUT operations. Populated by the
        /// system. Read-only. More info: http://kubernetes.io/docs/user-guide/identifiers#uids
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// OwnerReference contains enough information to let you identify an owning object. Currently, an owning object
    /// must be in the same namespace, so there is no namespace field.
    /// </summary>
    public class OwnerReference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version of the referent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; }

        /// <summary>
        /// If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the
        /// key-value store until this reference is removed. Defaults to false. To set this field, a user needs "delete"
        /// permission of the owner, otherwise 422 (Unprocessable Entity) will be returned. +optional
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockOwnerDeletion")]
        public virtual System.Nullable<bool> BlockOwnerDeletion { get; set; }

        /// <summary>If true, this reference points to the managing controller. +optional</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("controller")]
        public virtual System.Nullable<bool> Controller { get; set; }

        /// <summary>
        /// Kind of the referent. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#names</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>UID of the referent. More info: http://kubernetes.io/docs/user-guide/identifiers#uids</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual string Uid { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
