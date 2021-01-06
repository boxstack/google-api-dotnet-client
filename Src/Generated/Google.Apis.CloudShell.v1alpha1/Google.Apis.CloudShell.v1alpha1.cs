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

namespace Google.Apis.CloudShell.v1alpha1
{
    /// <summary>The CloudShell Service.</summary>
    public class CloudShellService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudShellService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudShellService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Users = new UsersResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudshell";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudshell.googleapis.com/";
        #else
            "https://cloudshell.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudshell.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Shell API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Shell API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }
    }

    /// <summary>A base abstract class for CloudShell requests.</summary>
    public abstract class CloudShellBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudShellBaseServiceRequest instance.</summary>
        protected CloudShellBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes CloudShell parameter list.</summary>
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

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Environments = new EnvironmentsResource(service);
        }

        /// <summary>Gets the Environments resource.</summary>
        public virtual EnvironmentsResource Environments { get; }

        /// <summary>The "environments" collection of methods.</summary>
        public class EnvironmentsResource
        {
            private const string Resource = "environments";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EnvironmentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                PublicKeys = new PublicKeysResource(service);
            }

            /// <summary>Gets the PublicKeys resource.</summary>
            public virtual PublicKeysResource PublicKeys { get; }

            /// <summary>The "publicKeys" collection of methods.</summary>
            public class PublicKeysResource
            {
                private const string Resource = "publicKeys";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public PublicKeysResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Adds a public SSH key to an environment, allowing clients with the corresponding private key to
                /// connect to that environment via SSH. If a key with the same format and content already exists, this
                /// will return the existing key.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Parent resource name, e.g. `users/me/environments/default`.</param>
                public virtual CreateRequest Create(Google.Apis.CloudShell.v1alpha1.Data.CreatePublicKeyRequest body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Adds a public SSH key to an environment, allowing clients with the corresponding private key to
                /// connect to that environment via SSH. If a key with the same format and content already exists, this
                /// will return the existing key.
                /// </summary>
                public class CreateRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.PublicKey>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudShell.v1alpha1.Data.CreatePublicKeyRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>Parent resource name, e.g. `users/me/environments/default`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudShell.v1alpha1.Data.CreatePublicKeyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+parent}/publicKeys";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/environments/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Removes a public SSH key from an environment. Clients will no longer be able to connect to the
                /// environment using the corresponding private key.
                /// </summary>
                /// <param name="name">
                /// Name of the resource to be deleted, e.g. `users/me/environments/default/publicKeys/my-key`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Removes a public SSH key from an environment. Clients will no longer be able to connect to the
                /// environment using the corresponding private key.
                /// </summary>
                public class DeleteRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Name of the resource to be deleted, e.g. `users/me/environments/default/publicKeys/my-key`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^users/[^/]+/environments/[^/]+/publicKeys/[^/]+$",
                        });
                    }
                }
            }

            /// <summary>
            /// Sends OAuth credentials to a running environment on behalf of a user. When this completes, the
            /// environment will be authorized to run various Google Cloud command line tools without requiring the user
            /// to manually authenticate.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Name of the resource that should receive the credentials, for example `users/me/environments/default` or
            /// `users/someone@example.com/environments/default`.
            /// </param>
            public virtual AuthorizeRequest Authorize(Google.Apis.CloudShell.v1alpha1.Data.AuthorizeEnvironmentRequest body, string name)
            {
                return new AuthorizeRequest(service, body, name);
            }

            /// <summary>
            /// Sends OAuth credentials to a running environment on behalf of a user. When this completes, the
            /// environment will be authorized to run various Google Cloud command line tools without requiring the user
            /// to manually authenticate.
            /// </summary>
            public class AuthorizeRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.Empty>
            {
                /// <summary>Constructs a new Authorize request.</summary>
                public AuthorizeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudShell.v1alpha1.Data.AuthorizeEnvironmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Name of the resource that should receive the credentials, for example
                /// `users/me/environments/default` or `users/someone@example.com/environments/default`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudShell.v1alpha1.Data.AuthorizeEnvironmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "authorize";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:authorize";

                /// <summary>Initializes Authorize parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+/environments/[^/]+$",
                    });
                }
            }

            /// <summary>Gets an environment. Returns NOT_FOUND if the environment does not exist.</summary>
            /// <param name="name">
            /// Name of the requested resource, for example `users/me/environments/default` or
            /// `users/someone@example.com/environments/default`.
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets an environment. Returns NOT_FOUND if the environment does not exist.</summary>
            public class GetRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.Environment>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Name of the requested resource, for example `users/me/environments/default` or
                /// `users/someone@example.com/environments/default`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

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
                        Pattern = @"^users/[^/]+/environments/[^/]+$",
                    });
                }
            }

            /// <summary>Updates an existing environment.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Name of the resource to be updated, for example `users/me/environments/default` or
            /// `users/someone@example.com/environments/default`.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.CloudShell.v1alpha1.Data.Environment body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an existing environment.</summary>
            public class PatchRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.Environment>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudShell.v1alpha1.Data.Environment body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Name of the resource to be updated, for example `users/me/environments/default` or
                /// `users/someone@example.com/environments/default`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Mask specifying which fields in the environment should be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudShell.v1alpha1.Data.Environment Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+/environments/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Starts an existing environment, allowing clients to connect to it. The returned operation will contain
            /// an instance of StartEnvironmentMetadata in its metadata field. Users can wait for the environment to
            /// start by polling this operation via GetOperation. Once the environment has finished starting and is
            /// ready to accept connections, the operation will contain a StartEnvironmentResponse in its response
            /// field.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Name of the resource that should be started, for example `users/me/environments/default` or
            /// `users/someone@example.com/environments/default`.
            /// </param>
            public virtual StartRequest Start(Google.Apis.CloudShell.v1alpha1.Data.StartEnvironmentRequest body, string name)
            {
                return new StartRequest(service, body, name);
            }

            /// <summary>
            /// Starts an existing environment, allowing clients to connect to it. The returned operation will contain
            /// an instance of StartEnvironmentMetadata in its metadata field. Users can wait for the environment to
            /// start by polling this operation via GetOperation. Once the environment has finished starting and is
            /// ready to accept connections, the operation will contain a StartEnvironmentResponse in its response
            /// field.
            /// </summary>
            public class StartRequest : CloudShellBaseServiceRequest<Google.Apis.CloudShell.v1alpha1.Data.Operation>
            {
                /// <summary>Constructs a new Start request.</summary>
                public StartRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudShell.v1alpha1.Data.StartEnvironmentRequest body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Name of the resource that should be started, for example `users/me/environments/default` or
                /// `users/someone@example.com/environments/default`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudShell.v1alpha1.Data.StartEnvironmentRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "start";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1alpha1/{+name}:start";

                /// <summary>Initializes Start parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^users/[^/]+/environments/[^/]+$",
                    });
                }
            }
        }
    }
}
namespace Google.Apis.CloudShell.v1alpha1.Data
{
    /// <summary>Request message for AuthorizeEnvironment.</summary>
    public class AuthorizeEnvironmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The OAuth access token that should be sent to the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>
        /// The time when the credentials expire. If not set, defaults to one hour from when the server received the
        /// request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; }

        /// <summary>The OAuth ID token that should be sent to the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("idToken")]
        public virtual string IdToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for CreatePublicKey.</summary>
    public class CreatePublicKeyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Key that should be added to the environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual PublicKey Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A Cloud Shell environment, which is defined as the combination of a Docker image specifying what is installed on
    /// the environment and a home directory containing the user's data that will remain across sessions. Each user has
    /// a single environment with the ID "default".
    /// </summary>
    public class Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Full path to the Docker image used to run this environment, e.g.
        /// "gcr.io/dev-con/cloud-devshell:latest".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockerImage")]
        public virtual string DockerImage { get; set; }

        /// <summary>Output only. The environment's identifier, unique among the user's environments.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Output only. Full name of this resource, in the format `users/{owner_email}/environments/{environment_id}`.
        /// `{owner_email}` is the email address of the user to whom this environment belongs, and `{environment_id}` is
        /// the identifier of this environment. For example, `users/someone@example.com/environments/default`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. Public keys associated with the environment. Clients can connect to this environment via SSH
        /// only if they possess a private key corresponding to at least one of these public keys. Keys can be added to
        /// or removed from the environment using the CreatePublicKey and DeletePublicKey methods.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeys")]
        public virtual System.Collections.Generic.IList<PublicKey> PublicKeys { get; set; }

        /// <summary>
        /// Indicates the size of the backing VM running the environment. If set to something other than DEFAULT, it
        /// will be reverted to the default VM size after vm_size_expire_time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual string Size { get; set; }

        /// <summary>
        /// Output only. Host to which clients can connect to initiate SSH sessions with the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshHost")]
        public virtual string SshHost { get; set; }

        /// <summary>
        /// Output only. Port to which clients can connect to initiate SSH sessions with the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPort")]
        public virtual System.Nullable<int> SshPort { get; set; }

        /// <summary>
        /// Output only. Username that clients should use when initiating SSH sessions with the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshUsername")]
        public virtual string SshUsername { get; set; }

        /// <summary>Output only. Current execution state of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>Output only. The time when the Environment will expire back to the default VM size.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vmSizeExpireTime")]
        public virtual object VmSizeExpireTime { get; set; }

        /// <summary>
        /// Output only. Host to which clients can connect to initiate HTTPS or WSS connections with the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webHost")]
        public virtual string WebHost { get; set; }

        /// <summary>
        /// Output only. Ports to which clients can connect to initiate HTTPS or WSS connections with the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webPorts")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> WebPorts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A public SSH key, corresponding to a private SSH key held by the client.</summary>
    public class PublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Format of this key's content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>Required. Content of this key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>
        /// Output only. Full name of this resource, in the format
        /// `users/{owner_email}/environments/{environment_id}/publicKeys/{key_id}`. `{owner_email}` is the email
        /// address of the user to whom the key belongs. `{environment_id}` is the identifier of the environment to
        /// which the key grants access. `{key_id}` is the unique identifier of the key. For example,
        /// `users/someone@example.com/environments/default/publicKeys/myKey`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message included in the metadata field of operations returned from StartEnvironment.</summary>
    public class StartEnvironmentMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Current state of the environment being started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for StartEnvironment.</summary>
    public class StartEnvironmentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The initial access token passed to the environment. If this is present and valid, the environment will be
        /// pre-authenticated with gcloud so that the user can run gcloud commands in Cloud Shell without having to log
        /// in. This code can be updated later by calling AuthorizeEnvironment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessToken")]
        public virtual string AccessToken { get; set; }

        /// <summary>Public keys that should be added to the environment before it is started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeys")]
        public virtual System.Collections.Generic.IList<PublicKey> PublicKeys { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Message included in the response field of operations returned from StartEnvironment once the operation is
    /// complete.
    /// </summary>
    public class StartEnvironmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment that was started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environment")]
        public virtual Environment Environment { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
