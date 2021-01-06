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

namespace Google.Apis.Classroom.v1
{
    /// <summary>The Classroom Service.</summary>
    public class ClassroomService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ClassroomService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ClassroomService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Courses = new CoursesResource(this);
            Invitations = new InvitationsResource(this);
            Registrations = new RegistrationsResource(this);
            UserProfiles = new UserProfilesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "classroom";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://classroom.googleapis.com/";
        #else
            "https://classroom.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://classroom.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Classroom API.</summary>
        public class Scope
        {
            /// <summary>View and manage announcements in Google Classroom</summary>
            public static string ClassroomAnnouncements = "https://www.googleapis.com/auth/classroom.announcements";

            /// <summary>View announcements in Google Classroom</summary>
            public static string ClassroomAnnouncementsReadonly = "https://www.googleapis.com/auth/classroom.announcements.readonly";

            /// <summary>Manage your Google Classroom classes</summary>
            public static string ClassroomCourses = "https://www.googleapis.com/auth/classroom.courses";

            /// <summary>View your Google Classroom classes</summary>
            public static string ClassroomCoursesReadonly = "https://www.googleapis.com/auth/classroom.courses.readonly";

            /// <summary>Manage your course work and view your grades in Google Classroom</summary>
            public static string ClassroomCourseworkMe = "https://www.googleapis.com/auth/classroom.coursework.me";

            /// <summary>View your course work and grades in Google Classroom</summary>
            public static string ClassroomCourseworkMeReadonly = "https://www.googleapis.com/auth/classroom.coursework.me.readonly";

            /// <summary>
            /// Manage course work and grades for students in the Google Classroom classes you teach and view the course
            /// work and grades for classes you administer
            /// </summary>
            public static string ClassroomCourseworkStudents = "https://www.googleapis.com/auth/classroom.coursework.students";

            /// <summary>
            /// View course work and grades for students in the Google Classroom classes you teach or administer
            /// </summary>
            public static string ClassroomCourseworkStudentsReadonly = "https://www.googleapis.com/auth/classroom.coursework.students.readonly";

            /// <summary>See, edit, and create classwork materials in Google Classroom</summary>
            public static string ClassroomCourseworkmaterials = "https://www.googleapis.com/auth/classroom.courseworkmaterials";

            /// <summary>See all classwork materials for your Google Classroom classes</summary>
            public static string ClassroomCourseworkmaterialsReadonly = "https://www.googleapis.com/auth/classroom.courseworkmaterials.readonly";

            /// <summary>View your Google Classroom guardians</summary>
            public static string ClassroomGuardianlinksMeReadonly = "https://www.googleapis.com/auth/classroom.guardianlinks.me.readonly";

            /// <summary>View and manage guardians for students in your Google Classroom classes</summary>
            public static string ClassroomGuardianlinksStudents = "https://www.googleapis.com/auth/classroom.guardianlinks.students";

            /// <summary>View guardians for students in your Google Classroom classes</summary>
            public static string ClassroomGuardianlinksStudentsReadonly = "https://www.googleapis.com/auth/classroom.guardianlinks.students.readonly";

            /// <summary>View the email addresses of people in your classes</summary>
            public static string ClassroomProfileEmails = "https://www.googleapis.com/auth/classroom.profile.emails";

            /// <summary>View the profile photos of people in your classes</summary>
            public static string ClassroomProfilePhotos = "https://www.googleapis.com/auth/classroom.profile.photos";

            /// <summary>Receive notifications about your Google Classroom data</summary>
            public static string ClassroomPushNotifications = "https://www.googleapis.com/auth/classroom.push-notifications";

            /// <summary>Manage your Google Classroom class rosters</summary>
            public static string ClassroomRosters = "https://www.googleapis.com/auth/classroom.rosters";

            /// <summary>View your Google Classroom class rosters</summary>
            public static string ClassroomRostersReadonly = "https://www.googleapis.com/auth/classroom.rosters.readonly";

            /// <summary>View your course work and grades in Google Classroom</summary>
            public static string ClassroomStudentSubmissionsMeReadonly = "https://www.googleapis.com/auth/classroom.student-submissions.me.readonly";

            /// <summary>
            /// View course work and grades for students in the Google Classroom classes you teach or administer
            /// </summary>
            public static string ClassroomStudentSubmissionsStudentsReadonly = "https://www.googleapis.com/auth/classroom.student-submissions.students.readonly";

            /// <summary>See, create, and edit topics in Google Classroom</summary>
            public static string ClassroomTopics = "https://www.googleapis.com/auth/classroom.topics";

            /// <summary>View topics in Google Classroom</summary>
            public static string ClassroomTopicsReadonly = "https://www.googleapis.com/auth/classroom.topics.readonly";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Classroom API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage announcements in Google Classroom</summary>
            public const string ClassroomAnnouncements = "https://www.googleapis.com/auth/classroom.announcements";

            /// <summary>View announcements in Google Classroom</summary>
            public const string ClassroomAnnouncementsReadonly = "https://www.googleapis.com/auth/classroom.announcements.readonly";

            /// <summary>Manage your Google Classroom classes</summary>
            public const string ClassroomCourses = "https://www.googleapis.com/auth/classroom.courses";

            /// <summary>View your Google Classroom classes</summary>
            public const string ClassroomCoursesReadonly = "https://www.googleapis.com/auth/classroom.courses.readonly";

            /// <summary>Manage your course work and view your grades in Google Classroom</summary>
            public const string ClassroomCourseworkMe = "https://www.googleapis.com/auth/classroom.coursework.me";

            /// <summary>View your course work and grades in Google Classroom</summary>
            public const string ClassroomCourseworkMeReadonly = "https://www.googleapis.com/auth/classroom.coursework.me.readonly";

            /// <summary>
            /// Manage course work and grades for students in the Google Classroom classes you teach and view the course
            /// work and grades for classes you administer
            /// </summary>
            public const string ClassroomCourseworkStudents = "https://www.googleapis.com/auth/classroom.coursework.students";

            /// <summary>
            /// View course work and grades for students in the Google Classroom classes you teach or administer
            /// </summary>
            public const string ClassroomCourseworkStudentsReadonly = "https://www.googleapis.com/auth/classroom.coursework.students.readonly";

            /// <summary>See, edit, and create classwork materials in Google Classroom</summary>
            public const string ClassroomCourseworkmaterials = "https://www.googleapis.com/auth/classroom.courseworkmaterials";

            /// <summary>See all classwork materials for your Google Classroom classes</summary>
            public const string ClassroomCourseworkmaterialsReadonly = "https://www.googleapis.com/auth/classroom.courseworkmaterials.readonly";

            /// <summary>View your Google Classroom guardians</summary>
            public const string ClassroomGuardianlinksMeReadonly = "https://www.googleapis.com/auth/classroom.guardianlinks.me.readonly";

            /// <summary>View and manage guardians for students in your Google Classroom classes</summary>
            public const string ClassroomGuardianlinksStudents = "https://www.googleapis.com/auth/classroom.guardianlinks.students";

            /// <summary>View guardians for students in your Google Classroom classes</summary>
            public const string ClassroomGuardianlinksStudentsReadonly = "https://www.googleapis.com/auth/classroom.guardianlinks.students.readonly";

            /// <summary>View the email addresses of people in your classes</summary>
            public const string ClassroomProfileEmails = "https://www.googleapis.com/auth/classroom.profile.emails";

            /// <summary>View the profile photos of people in your classes</summary>
            public const string ClassroomProfilePhotos = "https://www.googleapis.com/auth/classroom.profile.photos";

            /// <summary>Receive notifications about your Google Classroom data</summary>
            public const string ClassroomPushNotifications = "https://www.googleapis.com/auth/classroom.push-notifications";

            /// <summary>Manage your Google Classroom class rosters</summary>
            public const string ClassroomRosters = "https://www.googleapis.com/auth/classroom.rosters";

            /// <summary>View your Google Classroom class rosters</summary>
            public const string ClassroomRostersReadonly = "https://www.googleapis.com/auth/classroom.rosters.readonly";

            /// <summary>View your course work and grades in Google Classroom</summary>
            public const string ClassroomStudentSubmissionsMeReadonly = "https://www.googleapis.com/auth/classroom.student-submissions.me.readonly";

            /// <summary>
            /// View course work and grades for students in the Google Classroom classes you teach or administer
            /// </summary>
            public const string ClassroomStudentSubmissionsStudentsReadonly = "https://www.googleapis.com/auth/classroom.student-submissions.students.readonly";

            /// <summary>See, create, and edit topics in Google Classroom</summary>
            public const string ClassroomTopics = "https://www.googleapis.com/auth/classroom.topics";

            /// <summary>View topics in Google Classroom</summary>
            public const string ClassroomTopicsReadonly = "https://www.googleapis.com/auth/classroom.topics.readonly";
        }

        /// <summary>Gets the Courses resource.</summary>
        public virtual CoursesResource Courses { get; }

        /// <summary>Gets the Invitations resource.</summary>
        public virtual InvitationsResource Invitations { get; }

        /// <summary>Gets the Registrations resource.</summary>
        public virtual RegistrationsResource Registrations { get; }

        /// <summary>Gets the UserProfiles resource.</summary>
        public virtual UserProfilesResource UserProfiles { get; }
    }

    /// <summary>A base abstract class for Classroom requests.</summary>
    public abstract class ClassroomBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ClassroomBaseServiceRequest instance.</summary>
        protected ClassroomBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes Classroom parameter list.</summary>
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

    /// <summary>The "courses" collection of methods.</summary>
    public class CoursesResource
    {
        private const string Resource = "courses";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CoursesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Aliases = new AliasesResource(service);
            Announcements = new AnnouncementsResource(service);
            CourseWork = new CourseWorkResource(service);
            CourseWorkMaterials = new CourseWorkMaterialsResource(service);
            Students = new StudentsResource(service);
            Teachers = new TeachersResource(service);
            Topics = new TopicsResource(service);
        }

        /// <summary>Gets the Aliases resource.</summary>
        public virtual AliasesResource Aliases { get; }

        /// <summary>The "aliases" collection of methods.</summary>
        public class AliasesResource
        {
            private const string Resource = "aliases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AliasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an alias for a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to create the alias or for access errors. * `NOT_FOUND` if the
            /// course does not exist. * `ALREADY_EXISTS` if the alias already exists. * `FAILED_PRECONDITION` if the
            /// alias requested does not make sense for the requesting user or course (for example, if a user not in a
            /// domain attempts to access a domain-scoped alias).
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course to alias. This identifier can be either the Classroom-assigned identifier or an
            /// alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.CourseAlias body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates an alias for a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to create the alias or for access errors. * `NOT_FOUND` if the
            /// course does not exist. * `ALREADY_EXISTS` if the alias already exists. * `FAILED_PRECONDITION` if the
            /// alias requested does not make sense for the requesting user or course (for example, if a user not in a
            /// domain attempts to access a domain-scoped alias).
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseAlias>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.CourseAlias body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course to alias. This identifier can be either the Classroom-assigned identifier
                /// or an alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.CourseAlias Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/aliases";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes an alias of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to remove the alias or for access errors. * `NOT_FOUND` if the
            /// alias does not exist. * `FAILED_PRECONDITION` if the alias requested does not make sense for the
            /// requesting user or course (for example, if a user not in a domain attempts to delete a domain-scoped
            /// alias).
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course whose alias should be deleted. This identifier can be either the
            /// Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="alias">Alias to delete. This may not be the Classroom-assigned identifier.</param>
            public virtual DeleteRequest Delete(string courseId, string alias)
            {
                return new DeleteRequest(service, courseId, alias);
            }

            /// <summary>
            /// Deletes an alias of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to remove the alias or for access errors. * `NOT_FOUND` if the
            /// alias does not exist. * `FAILED_PRECONDITION` if the alias requested does not make sense for the
            /// requesting user or course (for example, if a user not in a domain attempts to delete a domain-scoped
            /// alias).
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string alias) : base(service)
                {
                    CourseId = courseId;
                    Alias = alias;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course whose alias should be deleted. This identifier can be either the
                /// Classroom-assigned identifier or an alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Alias to delete. This may not be the Classroom-assigned identifier.</summary>
                [Google.Apis.Util.RequestParameterAttribute("alias", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Alias { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/aliases/{alias}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("alias", new Google.Apis.Discovery.Parameter
                    {
                        Name = "alias",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of aliases for a course. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to access the course or for access errors. *
            /// `NOT_FOUND` if the course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// The identifier of the course. This identifier can be either the Classroom-assigned identifier or an
            /// alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of aliases for a course. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to access the course or for access errors. *
            /// `NOT_FOUND` if the course does not exist.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListCourseAliasesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// The identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/aliases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Announcements resource.</summary>
        public virtual AnnouncementsResource Announcements { get; }

        /// <summary>The "announcements" collection of methods.</summary>
        public class AnnouncementsResource
        {
            private const string Resource = "announcements";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AnnouncementsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates an announcement. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course, create announcements in the requested
            /// course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed. * `NOT_FOUND` if the requested course does not exist. * `FAILED_PRECONDITION` for the
            /// following request error: * AttachmentNotVisible
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Announcement body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates an announcement. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course, create announcements in the requested
            /// course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed. * `NOT_FOUND` if the requested course does not exist. * `FAILED_PRECONDITION` for the
            /// following request error: * AttachmentNotVisible
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Announcement>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Announcement body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Announcement Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes an announcement. This request must be made by the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding announcement item.
            /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting developer project
            /// did not create the corresponding announcement, if the requesting user is not permitted to delete the
            /// requested course or for access errors. * `FAILED_PRECONDITION` if the requested announcement has already
            /// been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">
            /// Identifier of the announcement to delete. This identifier is a Classroom-assigned identifier.
            /// </param>
            public virtual DeleteRequest Delete(string courseId, string id)
            {
                return new DeleteRequest(service, courseId, id);
            }

            /// <summary>
            /// Deletes an announcement. This request must be made by the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding announcement item.
            /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting developer project
            /// did not create the corresponding announcement, if the requesting user is not permitted to delete the
            /// requested course or for access errors. * `FAILED_PRECONDITION` if the requested announcement has already
            /// been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the announcement to delete. This identifier is a Classroom-assigned identifier.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns an announcement. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course or announcement, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or announcement
            /// does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the announcement.</param>
            public virtual GetRequest Get(string courseId, string id)
            {
                return new GetRequest(service, courseId, id);
            }

            /// <summary>
            /// Returns an announcement. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course or announcement, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or announcement
            /// does not exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Announcement>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the announcement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of announcements that the requester is permitted to view. Course students may only view
            /// `PUBLISHED` announcements. Course teachers and domain administrators may view all announcements. This
            /// method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted
            /// to access the requested course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. *
            /// `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of announcements that the requester is permitted to view. Course students may only view
            /// `PUBLISHED` announcements. Course teachers and domain administrators may view all announcements. This
            /// method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted
            /// to access the requested course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. *
            /// `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListAnnouncementsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Restriction on the `state` of announcements returned. If this argument is left unspecified, the
                /// default value is `PUBLISHED`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("announcementStates", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AnnouncementStatesEnum> AnnouncementStates { get; set; }

                /// <summary>
                /// Restriction on the `state` of announcements returned. If this argument is left unspecified, the
                /// default value is `PUBLISHED`.
                /// </summary>
                public enum AnnouncementStatesEnum
                {
                    /// <summary>No state specified. This is never returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("ANNOUNCEMENT_STATE_UNSPECIFIED")]
                    ANNOUNCEMENTSTATEUNSPECIFIED,

                    /// <summary>Status for announcement that has been published. This is the default state.</summary>
                    [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                    PUBLISHED,

                    /// <summary>
                    /// Status for an announcement that is not yet published. Announcement in this state is visible only
                    /// to course teachers and domain administrators.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DRAFT")]
                    DRAFT,

                    /// <summary>
                    /// Status for announcement that was published but is now deleted. Announcement in this state is
                    /// visible only to course teachers and domain administrators. Announcement in this state is deleted
                    /// after some time.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DELETED")]
                    DELETED,
                }

                /// <summary>
                /// Optional sort ordering for results. A comma-separated list of fields with an optional sort direction
                /// keyword. Supported field is `updateTime`. Supported direction keywords are `asc` and `desc`. If not
                /// specified, `updateTime desc` is the default behavior. Examples: `updateTime asc`, `updateTime`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("announcementStates", new Google.Apis.Discovery.Parameter
                    {
                        Name = "announcementStates",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Modifies assignee mode and options of an announcement. Only a teacher of the course that contains the
            /// announcement may call this method. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if the requesting user is not permitted to access the requested course or course work or for access
            /// errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or
            /// course work does not exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the announcement.</param>
            public virtual ModifyAssigneesRequest ModifyAssignees(Google.Apis.Classroom.v1.Data.ModifyAnnouncementAssigneesRequest body, string courseId, string id)
            {
                return new ModifyAssigneesRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Modifies assignee mode and options of an announcement. Only a teacher of the course that contains the
            /// announcement may call this method. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if the requesting user is not permitted to access the requested course or course work or for access
            /// errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or
            /// course work does not exist.
            /// </summary>
            public class ModifyAssigneesRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Announcement>
            {
                /// <summary>Constructs a new ModifyAssignees request.</summary>
                public ModifyAssigneesRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.ModifyAnnouncementAssigneesRequest body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the announcement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.ModifyAnnouncementAssigneesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyAssignees";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements/{id}:modifyAssignees";

                /// <summary>Initializes ModifyAssignees parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates one or more fields of an announcement. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding announcement or
            /// for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `FAILED_PRECONDITION` if the
            /// requested announcement has already been deleted. * `NOT_FOUND` if the requested course or announcement
            /// does not exist
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the announcement.</param>
            public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.Announcement body, string courseId, string id)
            {
                return new PatchRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Updates one or more fields of an announcement. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding announcement or
            /// for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `FAILED_PRECONDITION` if the
            /// requested announcement has already been deleted. * `NOT_FOUND` if the requested course or announcement
            /// does not exist
            /// </summary>
            public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Announcement>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Announcement body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the announcement.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>
                /// Mask that identifies which fields on the announcement to update. This field is required to do an
                /// update. The update fails if invalid fields are specified. If a field supports empty values, it can
                /// be cleared by specifying it in the update mask and not in the Announcement object. If a field that
                /// does not support empty values is included in the update mask and not set in the Announcement object,
                /// an `INVALID_ARGUMENT` error is returned. The following fields may be specified by teachers: * `text`
                /// * `state` * `scheduled_time`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Announcement Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/announcements/{id}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
        }

        /// <summary>Gets the CourseWork resource.</summary>
        public virtual CourseWorkResource CourseWork { get; }

        /// <summary>The "courseWork" collection of methods.</summary>
        public class CourseWorkResource
        {
            private const string Resource = "courseWork";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CourseWorkResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                StudentSubmissions = new StudentSubmissionsResource(service);
            }

            /// <summary>Gets the StudentSubmissions resource.</summary>
            public virtual StudentSubmissionsResource StudentSubmissions { get; }

            /// <summary>The "studentSubmissions" collection of methods.</summary>
            public class StudentSubmissionsResource
            {
                private const string Resource = "studentSubmissions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public StudentSubmissionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Returns a student submission. * `PERMISSION_DENIED` if the requesting user is not permitted to
                /// access the requested course, course work, or student submission or for access errors. *
                /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course, course work,
                /// or student submission does not exist.
                /// </summary>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual GetRequest Get(string courseId, string courseWorkId, string id)
                {
                    return new GetRequest(service, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Returns a student submission. * `PERMISSION_DENIED` if the requesting user is not permitted to
                /// access the requested course, course work, or student submission or for access errors. *
                /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course, course work,
                /// or student submission does not exist.
                /// </summary>
                public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.StudentSubmission>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns a list of student submissions that the requester is permitted to view, factoring in the
                /// OAuth scopes of the request. `-` may be specified as the `course_work_id` to include student
                /// submissions for multiple course work items. Course students may only view their own work. Course
                /// teachers and domain administrators may view all student submissions. This method returns the
                /// following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to access the
                /// requested course or course work, or for access errors. * `INVALID_ARGUMENT` if the request is
                /// malformed. * `NOT_FOUND` if the requested course does not exist.
                /// </summary>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">
                /// Identifier of the student work to request. This may be set to the string literal `"-"` to request
                /// student work for all course work in the specified course.
                /// </param>
                public virtual ListRequest List(string courseId, string courseWorkId)
                {
                    return new ListRequest(service, courseId, courseWorkId);
                }

                /// <summary>
                /// Returns a list of student submissions that the requester is permitted to view, factoring in the
                /// OAuth scopes of the request. `-` may be specified as the `course_work_id` to include student
                /// submissions for multiple course work items. Course students may only view their own work. Course
                /// teachers and domain administrators may view all student submissions. This method returns the
                /// following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to access the
                /// requested course or course work, or for access errors. * `INVALID_ARGUMENT` if the request is
                /// malformed. * `NOT_FOUND` if the requested course does not exist.
                /// </summary>
                public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListStudentSubmissionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string courseId, string courseWorkId) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>
                    /// Identifier of the student work to request. This may be set to the string literal `"-"` to
                    /// request student work for all course work in the specified course.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>
                    /// Requested lateness value. If specified, returned student submissions are restricted by the
                    /// requested value. If unspecified, submissions are returned regardless of `late` value.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("late", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<LateEnum> Late { get; set; }

                    /// <summary>
                    /// Requested lateness value. If specified, returned student submissions are restricted by the
                    /// requested value. If unspecified, submissions are returned regardless of `late` value.
                    /// </summary>
                    public enum LateEnum
                    {
                        /// <summary>No restriction on submission late values specified.</summary>
                        [Google.Apis.Util.StringValueAttribute("LATE_VALUES_UNSPECIFIED")]
                        LATEVALUESUNSPECIFIED,

                        /// <summary>Return StudentSubmissions where late is true.</summary>
                        [Google.Apis.Util.StringValueAttribute("LATE_ONLY")]
                        LATEONLY,

                        /// <summary>Return StudentSubmissions where late is false.</summary>
                        [Google.Apis.Util.StringValueAttribute("NOT_LATE_ONLY")]
                        NOTLATEONLY,
                    }

                    /// <summary>
                    /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                    /// maximum. The server may return fewer than the specified number of results.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                    /// results should be returned. The list request must be otherwise identical to the one that
                    /// resulted in this token.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Requested submission states. If specified, returned student submissions match one of the
                    /// specified submission states.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<StatesEnum> States { get; set; }

                    /// <summary>
                    /// Requested submission states. If specified, returned student submissions match one of the
                    /// specified submission states.
                    /// </summary>
                    public enum StatesEnum
                    {
                        /// <summary>No state specified. This should never be returned.</summary>
                        [Google.Apis.Util.StringValueAttribute("SUBMISSION_STATE_UNSPECIFIED")]
                        SUBMISSIONSTATEUNSPECIFIED,

                        /// <summary>
                        /// The student has never accessed this submission. Attachments are not returned and timestamps
                        /// is not set.
                        /// </summary>
                        [Google.Apis.Util.StringValueAttribute("NEW")]
                        NEW__,

                        /// <summary>Has been created.</summary>
                        [Google.Apis.Util.StringValueAttribute("CREATED")]
                        CREATED,

                        /// <summary>Has been turned in to the teacher.</summary>
                        [Google.Apis.Util.StringValueAttribute("TURNED_IN")]
                        TURNEDIN,

                        /// <summary>Has been returned to the student.</summary>
                        [Google.Apis.Util.StringValueAttribute("RETURNED")]
                        RETURNED,

                        /// <summary>Student chose to "unsubmit" the assignment.</summary>
                        [Google.Apis.Util.StringValueAttribute("RECLAIMED_BY_STUDENT")]
                        RECLAIMEDBYSTUDENT,
                    }

                    /// <summary>
                    /// Optional argument to restrict returned student work to those owned by the student with the
                    /// specified identifier. The identifier can be one of the following: * the numeric identifier for
                    /// the user * the email address of the user * the string literal `"me"`, indicating the requesting
                    /// user
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string UserId { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("late", new Google.Apis.Discovery.Parameter
                        {
                            Name = "late",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("states", new Google.Apis.Discovery.Parameter
                        {
                            Name = "states",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Modifies attachments of student submission. Attachments may only be added to student submissions
                /// belonging to course work objects with a `workType` of `ASSIGNMENT`. This request must be made by the
                /// Developer Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849)
                /// used to create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting user is not permitted to access the requested course or course
                /// work, if the user is not permitted to modify attachments on the requested student submission, or for
                /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested
                /// course, course work, or student submission does not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual ModifyAttachmentsRequest ModifyAttachments(Google.Apis.Classroom.v1.Data.ModifyAttachmentsRequest body, string courseId, string courseWorkId, string id)
                {
                    return new ModifyAttachmentsRequest(service, body, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Modifies attachments of student submission. Attachments may only be added to student submissions
                /// belonging to course work objects with a `workType` of `ASSIGNMENT`. This request must be made by the
                /// Developer Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849)
                /// used to create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting user is not permitted to access the requested course or course
                /// work, if the user is not permitted to modify attachments on the requested student submission, or for
                /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested
                /// course, course work, or student submission does not exist.
                /// </summary>
                public class ModifyAttachmentsRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.StudentSubmission>
                {
                    /// <summary>Constructs a new ModifyAttachments request.</summary>
                    public ModifyAttachmentsRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.ModifyAttachmentsRequest body, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Classroom.v1.Data.ModifyAttachmentsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "modifyAttachments";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}:modifyAttachments";

                    /// <summary>Initializes ModifyAttachments parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Updates one or more fields of a student submission. See google.classroom.v1.StudentSubmission for
                /// details of which fields may be updated and who may change them. This request must be made by the
                /// Developer Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849)
                /// used to create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding course
                /// work, if the user is not permitted to make the requested modification to the student submission, or
                /// for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested
                /// course, course work, or student submission does not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.StudentSubmission body, string courseId, string courseWorkId, string id)
                {
                    return new PatchRequest(service, body, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Updates one or more fields of a student submission. See google.classroom.v1.StudentSubmission for
                /// details of which fields may be updated and who may change them. This request must be made by the
                /// Developer Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849)
                /// used to create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding course
                /// work, if the user is not permitted to make the requested modification to the student submission, or
                /// for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested
                /// course, course work, or student submission does not exist.
                /// </summary>
                public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.StudentSubmission>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.StudentSubmission body, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>
                    /// Mask that identifies which fields on the student submission to update. This field is required to
                    /// do an update. The update fails if invalid fields are specified. The following fields may be
                    /// specified by teachers: * `draft_grade` * `assigned_grade`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Classroom.v1.Data.StudentSubmission Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
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
                /// Reclaims a student submission on behalf of the student that owns it. Reclaiming a student submission
                /// transfers ownership of attached Drive files to the student and updates the submission state. Only
                /// the student that owns the requested student submission may call this method, and only for a student
                /// submission that has been turned in. This request must be made by the Developer Console project of
                /// the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to create the
                /// corresponding course work item. This method returns the following error codes: * `PERMISSION_DENIED`
                /// if the requesting user is not permitted to access the requested course or course work, unsubmit the
                /// requested student submission, or for access errors. * `FAILED_PRECONDITION` if the student
                /// submission has not been turned in. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND`
                /// if the requested course, course work, or student submission does not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual ReclaimRequest Reclaim(Google.Apis.Classroom.v1.Data.ReclaimStudentSubmissionRequest body, string courseId, string courseWorkId, string id)
                {
                    return new ReclaimRequest(service, body, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Reclaims a student submission on behalf of the student that owns it. Reclaiming a student submission
                /// transfers ownership of attached Drive files to the student and updates the submission state. Only
                /// the student that owns the requested student submission may call this method, and only for a student
                /// submission that has been turned in. This request must be made by the Developer Console project of
                /// the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to create the
                /// corresponding course work item. This method returns the following error codes: * `PERMISSION_DENIED`
                /// if the requesting user is not permitted to access the requested course or course work, unsubmit the
                /// requested student submission, or for access errors. * `FAILED_PRECONDITION` if the student
                /// submission has not been turned in. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND`
                /// if the requested course, course work, or student submission does not exist.
                /// </summary>
                public class ReclaimRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Reclaim request.</summary>
                    public ReclaimRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.ReclaimStudentSubmissionRequest body, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Classroom.v1.Data.ReclaimStudentSubmissionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "reclaim";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}:reclaim";

                    /// <summary>Initializes Reclaim parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Returns a student submission. Returning a student submission transfers ownership of attached Drive
                /// files to the student and may also update the submission state. Unlike the Classroom application,
                /// returning a student submission does not set assignedGrade to the draftGrade value. Only a teacher of
                /// the course that contains the requested student submission may call this method. This request must be
                /// made by the Developer Console project of the [OAuth client
                /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work
                /// item. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is
                /// not permitted to access the requested course or course work, return the requested student
                /// submission, or for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if
                /// the requested course, course work, or student submission does not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual ClassroomReturnRequest ClassroomReturn(Google.Apis.Classroom.v1.Data.ReturnStudentSubmissionRequest body, string courseId, string courseWorkId, string id)
                {
                    return new ClassroomReturnRequest(service, body, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Returns a student submission. Returning a student submission transfers ownership of attached Drive
                /// files to the student and may also update the submission state. Unlike the Classroom application,
                /// returning a student submission does not set assignedGrade to the draftGrade value. Only a teacher of
                /// the course that contains the requested student submission may call this method. This request must be
                /// made by the Developer Console project of the [OAuth client
                /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work
                /// item. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is
                /// not permitted to access the requested course or course work, return the requested student
                /// submission, or for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if
                /// the requested course, course work, or student submission does not exist.
                /// </summary>
                public class ClassroomReturnRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
                {
                    /// <summary>Constructs a new ClassroomReturn request.</summary>
                    public ClassroomReturnRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.ReturnStudentSubmissionRequest body, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Classroom.v1.Data.ReturnStudentSubmissionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "return";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}:return";

                    /// <summary>Initializes ClassroomReturn parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Turns in a student submission. Turning in a student submission transfers ownership of attached Drive
                /// files to the teacher and may also update the submission state. This may only be called by the
                /// student that owns the specified student submission. This request must be made by the Developer
                /// Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to
                /// create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting user is not permitted to access the requested course or course
                /// work, turn in the requested student submission, or for access errors. * `INVALID_ARGUMENT` if the
                /// request is malformed. * `NOT_FOUND` if the requested course, course work, or student submission does
                /// not exist.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="courseId">
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </param>
                /// <param name="courseWorkId">Identifier of the course work.</param>
                /// <param name="id">Identifier of the student submission.</param>
                public virtual TurnInRequest TurnIn(Google.Apis.Classroom.v1.Data.TurnInStudentSubmissionRequest body, string courseId, string courseWorkId, string id)
                {
                    return new TurnInRequest(service, body, courseId, courseWorkId, id);
                }

                /// <summary>
                /// Turns in a student submission. Turning in a student submission transfers ownership of attached Drive
                /// files to the teacher and may also update the submission state. This may only be called by the
                /// student that owns the specified student submission. This request must be made by the Developer
                /// Console project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to
                /// create the corresponding course work item. This method returns the following error codes: *
                /// `PERMISSION_DENIED` if the requesting user is not permitted to access the requested course or course
                /// work, turn in the requested student submission, or for access errors. * `INVALID_ARGUMENT` if the
                /// request is malformed. * `NOT_FOUND` if the requested course, course work, or student submission does
                /// not exist.
                /// </summary>
                public class TurnInRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
                {
                    /// <summary>Constructs a new TurnIn request.</summary>
                    public TurnInRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.TurnInStudentSubmissionRequest body, string courseId, string courseWorkId, string id) : base(service)
                    {
                        CourseId = courseId;
                        CourseWorkId = courseWorkId;
                        Id = id;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                    /// alias.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseId { get; private set; }

                    /// <summary>Identifier of the course work.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("courseWorkId", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string CourseWorkId { get; private set; }

                    /// <summary>Identifier of the student submission.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Id { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Classroom.v1.Data.TurnInStudentSubmissionRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "turnIn";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/courses/{courseId}/courseWork/{courseWorkId}/studentSubmissions/{id}:turnIn";

                    /// <summary>Initializes TurnIn parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("courseWorkId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "courseWorkId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "id",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }
            }

            /// <summary>
            /// Creates course work. The resulting course work (and corresponding student submissions) are associated
            /// with the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to make the request. Classroom API requests to
            /// modify course work and student submissions must be made with an OAuth client ID from the associated
            /// Developer Console project. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course, create course work in the requested
            /// course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed. * `NOT_FOUND` if the requested course does not exist. * `FAILED_PRECONDITION` for the
            /// following request error: * AttachmentNotVisible
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.CourseWork body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates course work. The resulting course work (and corresponding student submissions) are associated
            /// with the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to make the request. Classroom API requests to
            /// modify course work and student submissions must be made with an OAuth client ID from the associated
            /// Developer Console project. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course, create course work in the requested
            /// course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed. * `NOT_FOUND` if the requested course does not exist. * `FAILED_PRECONDITION` for the
            /// following request error: * AttachmentNotVisible
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWork>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.CourseWork body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.CourseWork Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a course work. This request must be made by the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work item.
            /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting developer project
            /// did not create the corresponding course work, if the requesting user is not permitted to delete the
            /// requested course or for access errors. * `FAILED_PRECONDITION` if the requested course work has already
            /// been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">
            /// Identifier of the course work to delete. This identifier is a Classroom-assigned identifier.
            /// </param>
            public virtual DeleteRequest Delete(string courseId, string id)
            {
                return new DeleteRequest(service, courseId, id);
            }

            /// <summary>
            /// Deletes a course work. This request must be made by the Developer Console project of the [OAuth client
            /// ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work item.
            /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting developer project
            /// did not create the corresponding course work, if the requesting user is not permitted to delete the
            /// requested course or for access errors. * `FAILED_PRECONDITION` if the requested course work has already
            /// been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the course work to delete. This identifier is a Classroom-assigned identifier.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns course work. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course or course work, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or course work
            /// does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the course work.</param>
            public virtual GetRequest Get(string courseId, string id)
            {
                return new GetRequest(service, courseId, id);
            }

            /// <summary>
            /// Returns course work. This method returns the following error codes: * `PERMISSION_DENIED` if the
            /// requesting user is not permitted to access the requested course or course work, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or course work
            /// does not exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWork>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the course work.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of course work that the requester is permitted to view. Course students may only view
            /// `PUBLISHED` course work. Course teachers and domain administrators may view all course work. This method
            /// returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to
            /// access the requested course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. *
            /// `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of course work that the requester is permitted to view. Course students may only view
            /// `PUBLISHED` course work. Course teachers and domain administrators may view all course work. This method
            /// returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to
            /// access the requested course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. *
            /// `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListCourseWorkResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Restriction on the work status to return. Only courseWork that matches is returned. If unspecified,
                /// items with a work status of `PUBLISHED` is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseWorkStates", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CourseWorkStatesEnum> CourseWorkStates { get; set; }

                /// <summary>
                /// Restriction on the work status to return. Only courseWork that matches is returned. If unspecified,
                /// items with a work status of `PUBLISHED` is returned.
                /// </summary>
                public enum CourseWorkStatesEnum
                {
                    /// <summary>No state specified. This is never returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("COURSE_WORK_STATE_UNSPECIFIED")]
                    COURSEWORKSTATEUNSPECIFIED,

                    /// <summary>Status for work that has been published. This is the default state.</summary>
                    [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                    PUBLISHED,

                    /// <summary>
                    /// Status for work that is not yet published. Work in this state is visible only to course teachers
                    /// and domain administrators.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DRAFT")]
                    DRAFT,

                    /// <summary>
                    /// Status for work that was published but is now deleted. Work in this state is visible only to
                    /// course teachers and domain administrators. Work in this state is deleted after some time.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DELETED")]
                    DELETED,
                }

                /// <summary>
                /// Optional sort ordering for results. A comma-separated list of fields with an optional sort direction
                /// keyword. Supported fields are `updateTime` and `dueDate`. Supported direction keywords are `asc` and
                /// `desc`. If not specified, `updateTime desc` is the default behavior. Examples: `dueDate
                /// asc,updateTime desc`, `updateTime,dueDate desc`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("courseWorkStates", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseWorkStates",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Modifies assignee mode and options of a coursework. Only a teacher of the course that contains the
            /// coursework may call this method. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course or course work or for access errors.
            /// * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or course work
            /// does not exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the coursework.</param>
            public virtual ModifyAssigneesRequest ModifyAssignees(Google.Apis.Classroom.v1.Data.ModifyCourseWorkAssigneesRequest body, string courseId, string id)
            {
                return new ModifyAssigneesRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Modifies assignee mode and options of a coursework. Only a teacher of the course that contains the
            /// coursework may call this method. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course or course work or for access errors.
            /// * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or course work
            /// does not exist.
            /// </summary>
            public class ModifyAssigneesRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWork>
            {
                /// <summary>Constructs a new ModifyAssignees request.</summary>
                public ModifyAssigneesRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.ModifyCourseWorkAssigneesRequest body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the coursework.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.ModifyCourseWorkAssigneesRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "modifyAssignees";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork/{id}:modifyAssignees";

                /// <summary>Initializes ModifyAssignees parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates one or more fields of a course work. See google.classroom.v1.CourseWork for details of which
            /// fields may be updated and who may change them. This request must be made by the Developer Console
            /// project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to create the
            /// corresponding course work item. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting developer project did not create the corresponding course work, if the user is not
            /// permitted to make the requested modification to the student submission, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `FAILED_PRECONDITION` if the requested course work has
            /// already been deleted. * `NOT_FOUND` if the requested course, course work, or student submission does not
            /// exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the course work.</param>
            public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.CourseWork body, string courseId, string id)
            {
                return new PatchRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Updates one or more fields of a course work. See google.classroom.v1.CourseWork for details of which
            /// fields may be updated and who may change them. This request must be made by the Developer Console
            /// project of the [OAuth client ID](https://support.google.com/cloud/answer/6158849) used to create the
            /// corresponding course work item. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting developer project did not create the corresponding course work, if the user is not
            /// permitted to make the requested modification to the student submission, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `FAILED_PRECONDITION` if the requested course work has
            /// already been deleted. * `NOT_FOUND` if the requested course, course work, or student submission does not
            /// exist.
            /// </summary>
            public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWork>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.CourseWork body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the course work.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>
                /// Mask that identifies which fields on the course work to update. This field is required to do an
                /// update. The update fails if invalid fields are specified. If a field supports empty values, it can
                /// be cleared by specifying it in the update mask and not in the CourseWork object. If a field that
                /// does not support empty values is included in the update mask and not set in the CourseWork object,
                /// an `INVALID_ARGUMENT` error is returned. The following fields may be specified by teachers: *
                /// `title` * `description` * `state` * `due_date` * `due_time` * `max_points` * `scheduled_time` *
                /// `submission_modification_mode` * `topic_id`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.CourseWork Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWork/{id}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
        }

        /// <summary>Gets the CourseWorkMaterials resource.</summary>
        public virtual CourseWorkMaterialsResource CourseWorkMaterials { get; }

        /// <summary>The "courseWorkMaterials" collection of methods.</summary>
        public class CourseWorkMaterialsResource
        {
            private const string Resource = "courseWorkMaterials";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CourseWorkMaterialsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a course work material. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course, create course work material in the
            /// requested course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed or if more than 20 * materials are provided. * `NOT_FOUND` if the requested course does not
            /// exist. * `FAILED_PRECONDITION` for the following request error: * AttachmentNotVisible
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.CourseWorkMaterial body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates a course work material. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course, create course work material in the
            /// requested course, share a Drive attachment, or for access errors. * `INVALID_ARGUMENT` if the request is
            /// malformed or if more than 20 * materials are provided. * `NOT_FOUND` if the requested course does not
            /// exist. * `FAILED_PRECONDITION` for the following request error: * AttachmentNotVisible
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWorkMaterial>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.CourseWorkMaterial body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.CourseWorkMaterial Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWorkMaterials";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a course work material. This request must be made by the Developer Console project of the [OAuth
            /// client ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work
            /// material item. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// developer project did not create the corresponding course work material, if the requesting user is not
            /// permitted to delete the requested course or for access errors. * `FAILED_PRECONDITION` if the requested
            /// course work material has already been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">
            /// Identifier of the course work material to delete. This identifier is a Classroom-assigned identifier.
            /// </param>
            public virtual DeleteRequest Delete(string courseId, string id)
            {
                return new DeleteRequest(service, courseId, id);
            }

            /// <summary>
            /// Deletes a course work material. This request must be made by the Developer Console project of the [OAuth
            /// client ID](https://support.google.com/cloud/answer/6158849) used to create the corresponding course work
            /// material item. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// developer project did not create the corresponding course work material, if the requesting user is not
            /// permitted to delete the requested course or for access errors. * `FAILED_PRECONDITION` if the requested
            /// course work material has already been deleted. * `NOT_FOUND` if no course exists with the requested ID.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the course work material to delete. This identifier is a Classroom-assigned
                /// identifier.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWorkMaterials/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a course work material. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course or course work material, or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// or course work material does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the course work material.</param>
            public virtual GetRequest Get(string courseId, string id)
            {
                return new GetRequest(service, courseId, id);
            }

            /// <summary>
            /// Returns a course work material. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to access the requested course or course work material, or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// or course work material does not exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWorkMaterial>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the course work material.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWorkMaterials/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of course work material that the requester is permitted to view. Course students may only
            /// view `PUBLISHED` course work material. Course teachers and domain administrators may view all course
            /// work material. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course or for access errors. * `INVALID_ARGUMENT` if the
            /// request is malformed. * `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of course work material that the requester is permitted to view. Course students may only
            /// view `PUBLISHED` course work material. Course teachers and domain administrators may view all course
            /// work material. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course or for access errors. * `INVALID_ARGUMENT` if the
            /// request is malformed. * `NOT_FOUND` if the requested course does not exist.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListCourseWorkMaterialResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Restriction on the work status to return. Only course work material that matches is returned. If
                /// unspecified, items with a work status of `PUBLISHED` is returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseWorkMaterialStates", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CourseWorkMaterialStatesEnum> CourseWorkMaterialStates { get; set; }

                /// <summary>
                /// Restriction on the work status to return. Only course work material that matches is returned. If
                /// unspecified, items with a work status of `PUBLISHED` is returned.
                /// </summary>
                public enum CourseWorkMaterialStatesEnum
                {
                    /// <summary>No state specified. This is never returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("COURSEWORK_MATERIAL_STATE_UNSPECIFIED")]
                    COURSEWORKMATERIALSTATEUNSPECIFIED,

                    /// <summary>
                    /// Status for course work material that has been published. This is the default state.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("PUBLISHED")]
                    PUBLISHED,

                    /// <summary>
                    /// Status for an course work material that is not yet published. Course work material in this state
                    /// is visible only to course teachers and domain administrators.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DRAFT")]
                    DRAFT,

                    /// <summary>
                    /// Status for course work material that was published but is now deleted. Course work material in
                    /// this state is visible only to course teachers and domain administrators. Course work material in
                    /// this state is deleted after some time.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("DELETED")]
                    DELETED,
                }

                /// <summary>
                /// Optional filtering for course work material with at least one Drive material whose ID matches the
                /// provided string. If `material_link` is also specified, course work material must have materials
                /// matching both filters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("materialDriveId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MaterialDriveId { get; set; }

                /// <summary>
                /// Optional filtering for course work material with at least one link material whose URL partially
                /// matches the provided string.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("materialLink", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MaterialLink { get; set; }

                /// <summary>
                /// Optional sort ordering for results. A comma-separated list of fields with an optional sort direction
                /// keyword. Supported field is `updateTime`. Supported direction keywords are `asc` and `desc`. If not
                /// specified, `updateTime desc` is the default behavior. Examples: `updateTime asc`, `updateTime`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWorkMaterials";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("courseWorkMaterialStates", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseWorkMaterialStates",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("materialDriveId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "materialDriveId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("materialLink", new Google.Apis.Discovery.Parameter
                    {
                        Name = "materialLink",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates one or more fields of a course work material. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project for access errors. * `INVALID_ARGUMENT` if the
            /// request is malformed. * `FAILED_PRECONDITION` if the requested course work material has already been
            /// deleted. * `NOT_FOUND` if the requested course or course work material does not exist
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the course work material.</param>
            public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.CourseWorkMaterial body, string courseId, string id)
            {
                return new PatchRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Updates one or more fields of a course work material. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project for access errors. * `INVALID_ARGUMENT` if the
            /// request is malformed. * `FAILED_PRECONDITION` if the requested course work material has already been
            /// deleted. * `NOT_FOUND` if the requested course or course work material does not exist
            /// </summary>
            public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.CourseWorkMaterial>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.CourseWorkMaterial body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the course work material.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>
                /// Mask that identifies which fields on the course work material to update. This field is required to
                /// do an update. The update fails if invalid fields are specified. If a field supports empty values, it
                /// can be cleared by specifying it in the update mask and not in the course work material object. If a
                /// field that does not support empty values is included in the update mask and not set in the course
                /// work material object, an `INVALID_ARGUMENT` error is returned. The following fields may be specified
                /// by teachers: * `title` * `description` * `state` * `scheduled_time` * `topic_id`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.CourseWorkMaterial Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/courseWorkMaterials/{id}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
        }

        /// <summary>Gets the Students resource.</summary>
        public virtual StudentsResource Students { get; }

        /// <summary>The "students" collection of methods.</summary>
        public class StudentsResource
        {
            private const string Resource = "students";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public StudentsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Adds a user as a student of a course. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to create students in this course or for
            /// access errors. * `NOT_FOUND` if the requested course ID does not exist. * `FAILED_PRECONDITION` if the
            /// requested user's account is disabled, for the following request errors: * CourseMemberLimitReached *
            /// CourseNotModifiable * UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if the user is already a
            /// student or teacher in the course.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course to create the student in. This identifier can be either the Classroom-assigned
            /// identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Student body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Adds a user as a student of a course. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to create students in this course or for
            /// access errors. * `NOT_FOUND` if the requested course ID does not exist. * `FAILED_PRECONDITION` if the
            /// requested user's account is disabled, for the following request errors: * CourseMemberLimitReached *
            /// CourseNotModifiable * UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if the user is already a
            /// student or teacher in the course.
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Student>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Student body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course to create the student in. This identifier can be either the
                /// Classroom-assigned identifier or an alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Enrollment code of the course to create the student in. This code is required if userId corresponds
                /// to the requesting user; it may be omitted if the requesting user has administrative permissions to
                /// create students for any user.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("enrollmentCode", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string EnrollmentCode { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Student Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/students";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("enrollmentCode", new Google.Apis.Discovery.Parameter
                    {
                        Name = "enrollmentCode",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a student of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to delete students of this course or for access errors. *
            /// `NOT_FOUND` if no student of this course has the requested ID or if the course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="userId">
            /// Identifier of the student to delete. The identifier can be one of the following: * the numeric
            /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
            /// requesting user
            /// </param>
            public virtual DeleteRequest Delete(string courseId, string userId)
            {
                return new DeleteRequest(service, courseId, userId);
            }

            /// <summary>
            /// Deletes a student of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to delete students of this course or for access errors. *
            /// `NOT_FOUND` if no student of this course has the requested ID or if the course does not exist.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string userId) : base(service)
                {
                    CourseId = courseId;
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the student to delete. The identifier can be one of the following: * the numeric
                /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
                /// requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/students/{userId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a student of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to view students of this course or for access errors. * `NOT_FOUND`
            /// if no student of this course has the requested ID or if the course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="userId">
            /// Identifier of the student to return. The identifier can be one of the following: * the numeric
            /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
            /// requesting user
            /// </param>
            public virtual GetRequest Get(string courseId, string userId)
            {
                return new GetRequest(service, courseId, userId);
            }

            /// <summary>
            /// Returns a student of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to view students of this course or for access errors. * `NOT_FOUND`
            /// if no student of this course has the requested ID or if the course does not exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Student>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string userId) : base(service)
                {
                    CourseId = courseId;
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the student to return. The identifier can be one of the following: * the numeric
                /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
                /// requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/students/{userId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of students of this course that the requester is permitted to view. This method returns
            /// the following error codes: * `NOT_FOUND` if the course does not exist. * `PERMISSION_DENIED` for access
            /// errors.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of students of this course that the requester is permitted to view. This method returns
            /// the following error codes: * `NOT_FOUND` if the course does not exist. * `PERMISSION_DENIED` for access
            /// errors.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListStudentsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Maximum number of items to return. The default is 30 if unspecified or `0`. The server may return
                /// fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/students";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Teachers resource.</summary>
        public virtual TeachersResource Teachers { get; }

        /// <summary>The "teachers" collection of methods.</summary>
        public class TeachersResource
        {
            private const string Resource = "teachers";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TeachersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to create teachers in this course or for access errors. *
            /// `NOT_FOUND` if the requested course ID does not exist. * `FAILED_PRECONDITION` if the requested user's
            /// account is disabled, for the following request errors: * CourseMemberLimitReached * CourseNotModifiable
            /// * CourseTeacherLimitReached * UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if the user is already
            /// a teacher or student in the course.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Teacher body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to create teachers in this course or for access errors. *
            /// `NOT_FOUND` if the requested course ID does not exist. * `FAILED_PRECONDITION` if the requested user's
            /// account is disabled, for the following request errors: * CourseMemberLimitReached * CourseNotModifiable
            /// * CourseTeacherLimitReached * UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if the user is already
            /// a teacher or student in the course.
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Teacher>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Teacher body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Teacher Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/teachers";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to delete teachers of this course or for access errors. *
            /// `NOT_FOUND` if no teacher of this course has the requested ID or if the course does not exist. *
            /// `FAILED_PRECONDITION` if the requested ID belongs to the primary teacher of this course.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="userId">
            /// Identifier of the teacher to delete. The identifier can be one of the following: * the numeric
            /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
            /// requesting user
            /// </param>
            public virtual DeleteRequest Delete(string courseId, string userId)
            {
                return new DeleteRequest(service, courseId, userId);
            }

            /// <summary>
            /// Deletes a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to delete teachers of this course or for access errors. *
            /// `NOT_FOUND` if no teacher of this course has the requested ID or if the course does not exist. *
            /// `FAILED_PRECONDITION` if the requested ID belongs to the primary teacher of this course.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string userId) : base(service)
                {
                    CourseId = courseId;
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the teacher to delete. The identifier can be one of the following: * the numeric
                /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
                /// requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/teachers/{userId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to view teachers of this course or for access errors. * `NOT_FOUND`
            /// if no teacher of this course has the requested ID or if the course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="userId">
            /// Identifier of the teacher to return. The identifier can be one of the following: * the numeric
            /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
            /// requesting user
            /// </param>
            public virtual GetRequest Get(string courseId, string userId)
            {
                return new GetRequest(service, courseId, userId);
            }

            /// <summary>
            /// Returns a teacher of a course. This method returns the following error codes: * `PERMISSION_DENIED` if
            /// the requesting user is not permitted to view teachers of this course or for access errors. * `NOT_FOUND`
            /// if no teacher of this course has the requested ID or if the course does not exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Teacher>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string userId) : base(service)
                {
                    CourseId = courseId;
                    UserId = userId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Identifier of the teacher to return. The identifier can be one of the following: * the numeric
                /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
                /// requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/teachers/{userId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of teachers of this course that the requester is permitted to view. This method returns
            /// the following error codes: * `NOT_FOUND` if the course does not exist. * `PERMISSION_DENIED` for access
            /// errors.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns a list of teachers of this course that the requester is permitted to view. This method returns
            /// the following error codes: * `NOT_FOUND` if the course does not exist. * `PERMISSION_DENIED` for access
            /// errors.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListTeachersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Maximum number of items to return. The default is 30 if unspecified or `0`. The server may return
                /// fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/teachers";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>Gets the Topics resource.</summary>
        public virtual TopicsResource Topics { get; }

        /// <summary>The "topics" collection of methods.</summary>
        public class TopicsResource
        {
            private const string Resource = "topics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TopicsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course, create a topic in the requested course, or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// does not exist.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Topic body, string courseId)
            {
                return new CreateRequest(service, body, courseId);
            }

            /// <summary>
            /// Creates a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course, create a topic in the requested course, or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// does not exist.
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Topic>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Topic body, string courseId) : base(service)
                {
                    CourseId = courseId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Topic Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/topics";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Deletes a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not allowed to delete the requested topic or for access errors. * `FAILED_PRECONDITION` if the
            /// requested topic has already been deleted. * `NOT_FOUND` if no course or topic exists with the requested
            /// ID.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the topic to delete.</param>
            public virtual DeleteRequest Delete(string courseId, string id)
            {
                return new DeleteRequest(service, courseId, id);
            }

            /// <summary>
            /// Deletes a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not allowed to delete the requested topic or for access errors. * `FAILED_PRECONDITION` if the
            /// requested topic has already been deleted. * `NOT_FOUND` if no course or topic exists with the requested
            /// ID.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the topic to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/topics/{id}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course or topic, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or topic does not
            /// exist.
            /// </summary>
            /// <param name="courseId">Identifier of the course.</param>
            /// <param name="id">Identifier of the topic.</param>
            public virtual GetRequest Get(string courseId, string id)
            {
                return new GetRequest(service, courseId, id);
            }

            /// <summary>
            /// Returns a topic. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
            /// user is not permitted to access the requested course or topic, or for access errors. *
            /// `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course or topic does not
            /// exist.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Topic>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    InitParameters();
                }

                /// <summary>Identifier of the course.</summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the topic.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/topics/{id}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns the list of topics that the requester is permitted to view. This method returns the following
            /// error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to access the requested
            /// course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the
            /// requested course does not exist.
            /// </summary>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            public virtual ListRequest List(string courseId)
            {
                return new ListRequest(service, courseId);
            }

            /// <summary>
            /// Returns the list of topics that the requester is permitted to view. This method returns the following
            /// error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to access the requested
            /// course or for access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the
            /// requested course does not exist.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListTopicResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string courseId) : base(service)
                {
                    CourseId = courseId;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/topics";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates one or more fields of a topic. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding topic or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// or topic does not exist
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="courseId">
            /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an alias.
            /// </param>
            /// <param name="id">Identifier of the topic.</param>
            public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.Topic body, string courseId, string id)
            {
                return new PatchRequest(service, body, courseId, id);
            }

            /// <summary>
            /// Updates one or more fields of a topic. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting developer project did not create the corresponding topic or for
            /// access errors. * `INVALID_ARGUMENT` if the request is malformed. * `NOT_FOUND` if the requested course
            /// or topic does not exist
            /// </summary>
            public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Topic>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Topic body, string courseId, string id) : base(service)
                {
                    CourseId = courseId;
                    Id = id;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Identifier of the course. This identifier can be either the Classroom-assigned identifier or an
                /// alias.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CourseId { get; private set; }

                /// <summary>Identifier of the topic.</summary>
                [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Id { get; private set; }

                /// <summary>
                /// Mask that identifies which fields on the topic to update. This field is required to do an update.
                /// The update fails if invalid fields are specified. If a field supports empty values, it can be
                /// cleared by specifying it in the update mask and not in the Topic object. If a field that does not
                /// support empty values is included in the update mask and not set in the Topic object, an
                /// `INVALID_ARGUMENT` error is returned. The following fields may be specified: * `name`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.Topic Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/courses/{courseId}/topics/{id}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "courseId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "id",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
        }

        /// <summary>
        /// Creates a course. The user specified in `ownerId` is the owner of the created course and added as a teacher.
        /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted
        /// to create courses or for access errors. * `NOT_FOUND` if the primary teacher is not a valid user. *
        /// `FAILED_PRECONDITION` if the course owner's account is disabled or for the following request errors: *
        /// UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if an alias was specified in the `id` and already
        /// exists.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Course body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a course. The user specified in `ownerId` is the owner of the created course and added as a teacher.
        /// This method returns the following error codes: * `PERMISSION_DENIED` if the requesting user is not permitted
        /// to create courses or for access errors. * `NOT_FOUND` if the primary teacher is not a valid user. *
        /// `FAILED_PRECONDITION` if the course owner's account is disabled or for the following request errors: *
        /// UserGroupsMembershipLimitReached * `ALREADY_EXISTS` if an alias was specified in the `id` and already
        /// exists.
        /// </summary>
        public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Course>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Course body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Classroom.v1.Data.Course Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to delete the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID.
        /// </summary>
        /// <param name="id">
        /// Identifier of the course to delete. This identifier can be either the Classroom-assigned identifier or an
        /// alias.
        /// </param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>
        /// Deletes a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to delete the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID.
        /// </summary>
        public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>
            /// Identifier of the course to delete. This identifier can be either the Classroom-assigned identifier or
            /// an alias.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses/{id}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to access the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID.
        /// </summary>
        /// <param name="id">
        /// Identifier of the course to return. This identifier can be either the Classroom-assigned identifier or an
        /// alias.
        /// </param>
        public virtual GetRequest Get(string id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>
        /// Returns a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to access the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID.
        /// </summary>
        public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Course>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>
            /// Identifier of the course to return. This identifier can be either the Classroom-assigned identifier or
            /// an alias.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns a list of courses that the requesting user is permitted to view, restricted to those that match the
        /// request. Returned courses are ordered by creation time, with the most recently created coming first. This
        /// method returns the following error codes: * `PERMISSION_DENIED` for access errors. * `INVALID_ARGUMENT` if
        /// the query argument is malformed. * `NOT_FOUND` if any users specified in the query arguments do not exist.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns a list of courses that the requesting user is permitted to view, restricted to those that match the
        /// request. Returned courses are ordered by creation time, with the most recently created coming first. This
        /// method returns the following error codes: * `PERMISSION_DENIED` for access errors. * `INVALID_ARGUMENT` if
        /// the query argument is malformed. * `NOT_FOUND` if any users specified in the query arguments do not exist.
        /// </summary>
        public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListCoursesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>
            /// Restricts returned courses to those in one of the specified states The default value is ACTIVE,
            /// ARCHIVED, PROVISIONED, DECLINED.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("courseStates", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<CourseStatesEnum> CourseStates { get; set; }

            /// <summary>
            /// Restricts returned courses to those in one of the specified states The default value is ACTIVE,
            /// ARCHIVED, PROVISIONED, DECLINED.
            /// </summary>
            public enum CourseStatesEnum
            {
                /// <summary>No course state. No returned Course message will use this value.</summary>
                [Google.Apis.Util.StringValueAttribute("COURSE_STATE_UNSPECIFIED")]
                COURSESTATEUNSPECIFIED,

                /// <summary>The course is active.</summary>
                [Google.Apis.Util.StringValueAttribute("ACTIVE")]
                ACTIVE,

                /// <summary>
                /// The course has been archived. You cannot modify it except to change it to a different state.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("ARCHIVED")]
                ARCHIVED,

                /// <summary>
                /// The course has been created, but not yet activated. It is accessible by the primary teacher and
                /// domain administrators, who may modify it or change it to the `ACTIVE` or `DECLINED` states. A course
                /// may only be changed to `PROVISIONED` if it is in the `DECLINED` state.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("PROVISIONED")]
                PROVISIONED,

                /// <summary>
                /// The course has been created, but declined. It is accessible by the course owner and domain
                /// administrators, though it will not be displayed in the web UI. You cannot modify the course except
                /// to change it to the `PROVISIONED` state. A course may only be changed to `DECLINED` if it is in the
                /// `PROVISIONED` state.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("DECLINED")]
                DECLINED,

                /// <summary>
                /// The course has been suspended. You cannot modify the course, and only the user identified by the
                /// `owner_id` can view the course. A course may be placed in this state if it potentially violates the
                /// Terms of Service.
                /// </summary>
                [Google.Apis.Util.StringValueAttribute("SUSPENDED")]
                SUSPENDED,
            }

            /// <summary>
            /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a maximum.
            /// The server may return fewer than the specified number of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// nextPageToken value returned from a previous list call, indicating that the subsequent page of results
            /// should be returned. The list request must be otherwise identical to the one that resulted in this token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Restricts returned courses to those having a student with the specified identifier. The identifier can
            /// be one of the following: * the numeric identifier for the user * the email address of the user * the
            /// string literal `"me"`, indicating the requesting user
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StudentId { get; set; }

            /// <summary>
            /// Restricts returned courses to those having a teacher with the specified identifier. The identifier can
            /// be one of the following: * the numeric identifier for the user * the email address of the user * the
            /// string literal `"me"`, indicating the requesting user
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("teacherId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string TeacherId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("courseStates", new Google.Apis.Discovery.Parameter
                {
                    Name = "courseStates",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                {
                    Name = "studentId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("teacherId", new Google.Apis.Discovery.Parameter
                {
                    Name = "teacherId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Updates one or more fields in a course. This method returns the following error codes: * `PERMISSION_DENIED`
        /// if the requesting user is not permitted to modify the requested course or for access errors. * `NOT_FOUND`
        /// if no course exists with the requested ID. * `INVALID_ARGUMENT` if invalid fields are specified in the
        /// update mask or if no update mask is supplied. * `FAILED_PRECONDITION` for the following request errors: *
        /// CourseNotModifiable
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">
        /// Identifier of the course to update. This identifier can be either the Classroom-assigned identifier or an
        /// alias.
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.Course body, string id)
        {
            return new PatchRequest(service, body, id);
        }

        /// <summary>
        /// Updates one or more fields in a course. This method returns the following error codes: * `PERMISSION_DENIED`
        /// if the requesting user is not permitted to modify the requested course or for access errors. * `NOT_FOUND`
        /// if no course exists with the requested ID. * `INVALID_ARGUMENT` if invalid fields are specified in the
        /// update mask or if no update mask is supplied. * `FAILED_PRECONDITION` for the following request errors: *
        /// CourseNotModifiable
        /// </summary>
        public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Course>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Course body, string id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier of the course to update. This identifier can be either the Classroom-assigned identifier or
            /// an alias.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>
            /// Mask that identifies which fields on the course to update. This field is required to do an update. The
            /// update will fail if invalid fields are specified. The following fields are valid: * `name` * `section` *
            /// `descriptionHeading` * `description` * `room` * `courseState` * `ownerId` Note: patches to ownerId are
            /// treated as being effective immediately, but in practice it may take some time for the ownership transfer
            /// of all affected resources to complete. When set in a query parameter, this field should be specified as
            /// `updateMask=,,...`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Classroom.v1.Data.Course Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses/{id}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
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
        /// Updates a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to modify the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID. * `FAILED_PRECONDITION` for the following request errors: * CourseNotModifiable
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">
        /// Identifier of the course to update. This identifier can be either the Classroom-assigned identifier or an
        /// alias.
        /// </param>
        public virtual UpdateRequest Update(Google.Apis.Classroom.v1.Data.Course body, string id)
        {
            return new UpdateRequest(service, body, id);
        }

        /// <summary>
        /// Updates a course. This method returns the following error codes: * `PERMISSION_DENIED` if the requesting
        /// user is not permitted to modify the requested course or for access errors. * `NOT_FOUND` if no course exists
        /// with the requested ID. * `FAILED_PRECONDITION` for the following request errors: * CourseNotModifiable
        /// </summary>
        public class UpdateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Course>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Course body, string id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Identifier of the course to update. This identifier can be either the Classroom-assigned identifier or
            /// an alias.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Classroom.v1.Data.Course Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/courses/{id}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "invitations" collection of methods.</summary>
    public class InvitationsResource
    {
        private const string Resource = "invitations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public InvitationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Accepts an invitation, removing it and adding the invited user to the teachers or students (as appropriate)
        /// of the specified course. Only the invited user may accept an invitation. This method returns the following
        /// error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to accept the requested
        /// invitation or for access errors. * `FAILED_PRECONDITION` for the following request errors: *
        /// CourseMemberLimitReached * CourseNotModifiable * CourseTeacherLimitReached *
        /// UserGroupsMembershipLimitReached * `NOT_FOUND` if no invitation exists with the requested ID.
        /// </summary>
        /// <param name="id">Identifier of the invitation to accept.</param>
        public virtual AcceptRequest Accept(string id)
        {
            return new AcceptRequest(service, id);
        }

        /// <summary>
        /// Accepts an invitation, removing it and adding the invited user to the teachers or students (as appropriate)
        /// of the specified course. Only the invited user may accept an invitation. This method returns the following
        /// error codes: * `PERMISSION_DENIED` if the requesting user is not permitted to accept the requested
        /// invitation or for access errors. * `FAILED_PRECONDITION` for the following request errors: *
        /// CourseMemberLimitReached * CourseNotModifiable * CourseTeacherLimitReached *
        /// UserGroupsMembershipLimitReached * `NOT_FOUND` if no invitation exists with the requested ID.
        /// </summary>
        public class AcceptRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
        {
            /// <summary>Constructs a new Accept request.</summary>
            public AcceptRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>Identifier of the invitation to accept.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "accept";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/invitations/{id}:accept";

            /// <summary>Initializes Accept parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Creates an invitation. Only one invitation for a user and course may exist at a time. Delete and re-create
        /// an invitation to make changes. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to create invitations for this course or for access errors. * `NOT_FOUND`
        /// if the course or the user does not exist. * `FAILED_PRECONDITION` if the requested user's account is
        /// disabled or if the user already has this role or a role with greater permissions. * `ALREADY_EXISTS` if an
        /// invitation for the specified user and course already exists.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Invitation body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates an invitation. Only one invitation for a user and course may exist at a time. Delete and re-create
        /// an invitation to make changes. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to create invitations for this course or for access errors. * `NOT_FOUND`
        /// if the course or the user does not exist. * `FAILED_PRECONDITION` if the requested user's account is
        /// disabled or if the user already has this role or a role with greater permissions. * `ALREADY_EXISTS` if an
        /// invitation for the specified user and course already exists.
        /// </summary>
        public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Invitation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Invitation body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Classroom.v1.Data.Invitation Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/invitations";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to delete the requested invitation or for access errors. * `NOT_FOUND` if
        /// no invitation exists with the requested ID.
        /// </summary>
        /// <param name="id">Identifier of the invitation to delete.</param>
        public virtual DeleteRequest Delete(string id)
        {
            return new DeleteRequest(service, id);
        }

        /// <summary>
        /// Deletes an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to delete the requested invitation or for access errors. * `NOT_FOUND` if
        /// no invitation exists with the requested ID.
        /// </summary>
        public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>Identifier of the invitation to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/invitations/{id}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to view the requested invitation or for access errors. * `NOT_FOUND` if no
        /// invitation exists with the requested ID.
        /// </summary>
        /// <param name="id">Identifier of the invitation to return.</param>
        public virtual GetRequest Get(string id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>
        /// Returns an invitation. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to view the requested invitation or for access errors. * `NOT_FOUND` if no
        /// invitation exists with the requested ID.
        /// </summary>
        public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Invitation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string id) : base(service)
            {
                Id = id;
                InitParameters();
            }

            /// <summary>Identifier of the invitation to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Id { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/invitations/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Returns a list of invitations that the requesting user is permitted to view, restricted to those that match
        /// the list request. *Note:* At least one of `user_id` or `course_id` must be supplied. Both fields can be
        /// supplied. This method returns the following error codes: * `PERMISSION_DENIED` for access errors.
        /// </summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>
        /// Returns a list of invitations that the requesting user is permitted to view, restricted to those that match
        /// the list request. *Note:* At least one of `user_id` or `course_id` must be supplied. Both fields can be
        /// supplied. This method returns the following error codes: * `PERMISSION_DENIED` for access errors.
        /// </summary>
        public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListInvitationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Restricts returned invitations to those for a course with the specified identifier.</summary>
            [Google.Apis.Util.RequestParameterAttribute("courseId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CourseId { get; set; }

            /// <summary>
            /// Maximum number of items to return. The default is 500 if unspecified or `0`. The server may return fewer
            /// than the specified number of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// nextPageToken value returned from a previous list call, indicating that the subsequent page of results
            /// should be returned. The list request must be otherwise identical to the one that resulted in this token.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Restricts returned invitations to those for a specific user. The identifier can be one of the following:
            /// * the numeric identifier for the user * the email address of the user * the string literal `"me"`,
            /// indicating the requesting user
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserId { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/invitations";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("courseId", new Google.Apis.Discovery.Parameter
                {
                    Name = "courseId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "registrations" collection of methods.</summary>
    public class RegistrationsResource
    {
        private const string Resource = "registrations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RegistrationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Creates a `Registration`, causing Classroom to start sending notifications from the provided `feed` to the
        /// destination provided in `cloudPubSubTopic`. Returns the created `Registration`. Currently, this will be the
        /// same as the argument, but with server-assigned fields such as `expiry_time` and `id` filled in. Note that
        /// any value specified for the `expiry_time` or `id` fields will be ignored. While Classroom may validate the
        /// `cloudPubSubTopic` and return errors on a best effort basis, it is the caller's responsibility to ensure
        /// that it exists and that Classroom has permission to publish to it. This method may return the following
        /// error codes: * `PERMISSION_DENIED` if: * the authenticated user does not have permission to receive
        /// notifications from the requested field; or * the current user has not granted access to the current Cloud
        /// project with the appropriate scope for the requested feed. Note that domain-wide delegation of authority is
        /// not currently supported for this purpose. If the request has the appropriate scope, but no grant exists, a
        /// Request Errors is returned. * another access error is encountered. * `INVALID_ARGUMENT` if: * no
        /// `cloudPubsubTopic` is specified, or the specified `cloudPubsubTopic` is not valid; or * no `feed` is
        /// specified, or the specified `feed` is not valid. * `NOT_FOUND` if: * the specified `feed` cannot be located,
        /// or the requesting user does not have permission to determine whether or not it exists; or * the specified
        /// `cloudPubsubTopic` cannot be located, or Classroom has not been granted permission to publish to it.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.Registration body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Creates a `Registration`, causing Classroom to start sending notifications from the provided `feed` to the
        /// destination provided in `cloudPubSubTopic`. Returns the created `Registration`. Currently, this will be the
        /// same as the argument, but with server-assigned fields such as `expiry_time` and `id` filled in. Note that
        /// any value specified for the `expiry_time` or `id` fields will be ignored. While Classroom may validate the
        /// `cloudPubSubTopic` and return errors on a best effort basis, it is the caller's responsibility to ensure
        /// that it exists and that Classroom has permission to publish to it. This method may return the following
        /// error codes: * `PERMISSION_DENIED` if: * the authenticated user does not have permission to receive
        /// notifications from the requested field; or * the current user has not granted access to the current Cloud
        /// project with the appropriate scope for the requested feed. Note that domain-wide delegation of authority is
        /// not currently supported for this purpose. If the request has the appropriate scope, but no grant exists, a
        /// Request Errors is returned. * another access error is encountered. * `INVALID_ARGUMENT` if: * no
        /// `cloudPubsubTopic` is specified, or the specified `cloudPubsubTopic` is not valid; or * no `feed` is
        /// specified, or the specified `feed` is not valid. * `NOT_FOUND` if: * the specified `feed` cannot be located,
        /// or the requesting user does not have permission to determine whether or not it exists; or * the specified
        /// `cloudPubsubTopic` cannot be located, or Classroom has not been granted permission to publish to it.
        /// </summary>
        public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Registration>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.Registration body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Classroom.v1.Data.Registration Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/registrations";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Deletes a `Registration`, causing Classroom to stop sending notifications for that `Registration`.
        /// </summary>
        /// <param name="registrationId">The `registration_id` of the `Registration` to be deleted.</param>
        public virtual DeleteRequest Delete(string registrationId)
        {
            return new DeleteRequest(service, registrationId);
        }

        /// <summary>
        /// Deletes a `Registration`, causing Classroom to stop sending notifications for that `Registration`.
        /// </summary>
        public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string registrationId) : base(service)
            {
                RegistrationId = registrationId;
                InitParameters();
            }

            /// <summary>The `registration_id` of the `Registration` to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("registrationId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RegistrationId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/registrations/{registrationId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("registrationId", new Google.Apis.Discovery.Parameter
                {
                    Name = "registrationId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "userProfiles" collection of methods.</summary>
    public class UserProfilesResource
    {
        private const string Resource = "userProfiles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UserProfilesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            GuardianInvitations = new GuardianInvitationsResource(service);
            Guardians = new GuardiansResource(service);
        }

        /// <summary>Gets the GuardianInvitations resource.</summary>
        public virtual GuardianInvitationsResource GuardianInvitations { get; }

        /// <summary>The "guardianInvitations" collection of methods.</summary>
        public class GuardianInvitationsResource
        {
            private const string Resource = "guardianInvitations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GuardianInvitationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a guardian invitation, and sends an email to the guardian asking them to confirm that they are
            /// the student's guardian. Once the guardian accepts the invitation, their `state` will change to
            /// `COMPLETED` and they will start receiving guardian notifications. A `Guardian` resource will also be
            /// created to represent the active guardian. The request object must have the `student_id` and
            /// `invited_email_address` fields set. Failing to set these fields, or setting any other fields in the
            /// request, will result in an error. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if the current user does not have permission to manage guardians, if the guardian in question has
            /// already rejected too many requests for that student, if guardians are not enabled for the domain in
            /// question, or for other access errors. * `RESOURCE_EXHAUSTED` if the student or guardian has exceeded the
            /// guardian link limit. * `INVALID_ARGUMENT` if the guardian email address is not valid (for example, if it
            /// is too long), or if the format of the student ID provided cannot be recognized (it is not an email
            /// address, nor a `user_id` from this API). This error will also be returned if read-only fields are set,
            /// or if the `state` field is set to to a value other than `PENDING`. * `NOT_FOUND` if the student ID
            /// provided is a valid student ID, but Classroom has no record of that student. * `ALREADY_EXISTS` if there
            /// is already a pending guardian invitation for the student and `invited_email_address` provided, or if the
            /// provided `invited_email_address` matches the Google account of an existing `Guardian` for this user.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="studentId">ID of the student (in standard format)</param>
            public virtual CreateRequest Create(Google.Apis.Classroom.v1.Data.GuardianInvitation body, string studentId)
            {
                return new CreateRequest(service, body, studentId);
            }

            /// <summary>
            /// Creates a guardian invitation, and sends an email to the guardian asking them to confirm that they are
            /// the student's guardian. Once the guardian accepts the invitation, their `state` will change to
            /// `COMPLETED` and they will start receiving guardian notifications. A `Guardian` resource will also be
            /// created to represent the active guardian. The request object must have the `student_id` and
            /// `invited_email_address` fields set. Failing to set these fields, or setting any other fields in the
            /// request, will result in an error. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if the current user does not have permission to manage guardians, if the guardian in question has
            /// already rejected too many requests for that student, if guardians are not enabled for the domain in
            /// question, or for other access errors. * `RESOURCE_EXHAUSTED` if the student or guardian has exceeded the
            /// guardian link limit. * `INVALID_ARGUMENT` if the guardian email address is not valid (for example, if it
            /// is too long), or if the format of the student ID provided cannot be recognized (it is not an email
            /// address, nor a `user_id` from this API). This error will also be returned if read-only fields are set,
            /// or if the `state` field is set to to a value other than `PENDING`. * `NOT_FOUND` if the student ID
            /// provided is a valid student ID, but Classroom has no record of that student. * `ALREADY_EXISTS` if there
            /// is already a pending guardian invitation for the student and `invited_email_address` provided, or if the
            /// provided `invited_email_address` matches the Google account of an existing `Guardian` for this user.
            /// </summary>
            public class CreateRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.GuardianInvitation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.GuardianInvitation body, string studentId) : base(service)
                {
                    StudentId = studentId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>ID of the student (in standard format)</summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.GuardianInvitation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardianInvitations";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a specific guardian invitation. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to view guardian invitations for the student
            /// identified by the `student_id`, if guardians are not enabled for the domain in question, or for other
            /// access errors. * `INVALID_ARGUMENT` if a `student_id` is specified, but its format cannot be recognized
            /// (it is not an email address, nor a `student_id` from the API, nor the literal string `me`). *
            /// `NOT_FOUND` if Classroom cannot find any record of the given student or `invitation_id`. May also be
            /// returned if the student exists, but the requesting user does not have access to see that student.
            /// </summary>
            /// <param name="studentId">The ID of the student whose guardian invitation is being requested.</param>
            /// <param name="invitationId">The `id` field of the `GuardianInvitation` being requested.</param>
            public virtual GetRequest Get(string studentId, string invitationId)
            {
                return new GetRequest(service, studentId, invitationId);
            }

            /// <summary>
            /// Returns a specific guardian invitation. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if the requesting user is not permitted to view guardian invitations for the student
            /// identified by the `student_id`, if guardians are not enabled for the domain in question, or for other
            /// access errors. * `INVALID_ARGUMENT` if a `student_id` is specified, but its format cannot be recognized
            /// (it is not an email address, nor a `student_id` from the API, nor the literal string `me`). *
            /// `NOT_FOUND` if Classroom cannot find any record of the given student or `invitation_id`. May also be
            /// returned if the student exists, but the requesting user does not have access to see that student.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.GuardianInvitation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string studentId, string invitationId) : base(service)
                {
                    StudentId = studentId;
                    InvitationId = invitationId;
                    InitParameters();
                }

                /// <summary>The ID of the student whose guardian invitation is being requested.</summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>The `id` field of the `GuardianInvitation` being requested.</summary>
                [Google.Apis.Util.RequestParameterAttribute("invitationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string InvitationId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardianInvitations/{invitationId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("invitationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "invitationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of guardian invitations that the requesting user is permitted to view, filtered by the
            /// parameters provided. This method returns the following error codes: * `PERMISSION_DENIED` if a
            /// `student_id` is specified, and the requesting user is not permitted to view guardian invitations for
            /// that student, if `"-"` is specified as the `student_id` and the user is not a domain administrator, if
            /// guardians are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT`
            /// if a `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API, nor the literal string `me`). May also be returned if an invalid `page_token`
            /// or `state` is provided. * `NOT_FOUND` if a `student_id` is specified, and its format can be recognized,
            /// but Classroom has no record of that student.
            /// </summary>
            /// <param name="studentId">
            /// The ID of the student whose guardian invitations are to be returned. The identifier can be one of the
            /// following: * the numeric identifier for the user * the email address of the user * the string literal
            /// `"me"`, indicating the requesting user * the string literal `"-"`, indicating that results should be
            /// returned for all students that the requesting user is permitted to view guardian invitations.
            /// </param>
            public virtual ListRequest List(string studentId)
            {
                return new ListRequest(service, studentId);
            }

            /// <summary>
            /// Returns a list of guardian invitations that the requesting user is permitted to view, filtered by the
            /// parameters provided. This method returns the following error codes: * `PERMISSION_DENIED` if a
            /// `student_id` is specified, and the requesting user is not permitted to view guardian invitations for
            /// that student, if `"-"` is specified as the `student_id` and the user is not a domain administrator, if
            /// guardians are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT`
            /// if a `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API, nor the literal string `me`). May also be returned if an invalid `page_token`
            /// or `state` is provided. * `NOT_FOUND` if a `student_id` is specified, and its format can be recognized,
            /// but Classroom has no record of that student.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListGuardianInvitationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string studentId) : base(service)
                {
                    StudentId = studentId;
                    InitParameters();
                }

                /// <summary>
                /// The ID of the student whose guardian invitations are to be returned. The identifier can be one of
                /// the following: * the numeric identifier for the user * the email address of the user * the string
                /// literal `"me"`, indicating the requesting user * the string literal `"-"`, indicating that results
                /// should be returned for all students that the requesting user is permitted to view guardian
                /// invitations.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>
                /// If specified, only results with the specified `invited_email_address` are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("invitedEmailAddress", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string InvitedEmailAddress { get; set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// If specified, only results with the specified `state` values are returned. Otherwise, results with a
                /// `state` of `PENDING` are returned.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("states", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<StatesEnum> States { get; set; }

                /// <summary>
                /// If specified, only results with the specified `state` values are returned. Otherwise, results with a
                /// `state` of `PENDING` are returned.
                /// </summary>
                public enum StatesEnum
                {
                    /// <summary>Should never be returned.</summary>
                    [Google.Apis.Util.StringValueAttribute("GUARDIAN_INVITATION_STATE_UNSPECIFIED")]
                    GUARDIANINVITATIONSTATEUNSPECIFIED,

                    /// <summary>The invitation is active and awaiting a response.</summary>
                    [Google.Apis.Util.StringValueAttribute("PENDING")]
                    PENDING,

                    /// <summary>
                    /// The invitation is no longer active. It may have been accepted, declined, withdrawn or it may
                    /// have expired.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("COMPLETE")]
                    COMPLETE,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardianInvitations";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("invitedEmailAddress", new Google.Apis.Discovery.Parameter
                    {
                        Name = "invitedEmailAddress",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("states", new Google.Apis.Discovery.Parameter
                    {
                        Name = "states",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Modifies a guardian invitation. Currently, the only valid modification is to change the `state` from
            /// `PENDING` to `COMPLETE`. This has the effect of withdrawing the invitation. This method returns the
            /// following error codes: * `PERMISSION_DENIED` if the current user does not have permission to manage
            /// guardians, if guardians are not enabled for the domain in question or for other access errors. *
            /// `FAILED_PRECONDITION` if the guardian link is not in the `PENDING` state. * `INVALID_ARGUMENT` if the
            /// format of the student ID provided cannot be recognized (it is not an email address, nor a `user_id` from
            /// this API), or if the passed `GuardianInvitation` has a `state` other than `COMPLETE`, or if it modifies
            /// fields other than `state`. * `NOT_FOUND` if the student ID provided is a valid student ID, but Classroom
            /// has no record of that student, or if the `id` field does not refer to a guardian invitation known to
            /// Classroom.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="studentId">The ID of the student whose guardian invitation is to be modified.</param>
            /// <param name="invitationId">The `id` field of the `GuardianInvitation` to be modified.</param>
            public virtual PatchRequest Patch(Google.Apis.Classroom.v1.Data.GuardianInvitation body, string studentId, string invitationId)
            {
                return new PatchRequest(service, body, studentId, invitationId);
            }

            /// <summary>
            /// Modifies a guardian invitation. Currently, the only valid modification is to change the `state` from
            /// `PENDING` to `COMPLETE`. This has the effect of withdrawing the invitation. This method returns the
            /// following error codes: * `PERMISSION_DENIED` if the current user does not have permission to manage
            /// guardians, if guardians are not enabled for the domain in question or for other access errors. *
            /// `FAILED_PRECONDITION` if the guardian link is not in the `PENDING` state. * `INVALID_ARGUMENT` if the
            /// format of the student ID provided cannot be recognized (it is not an email address, nor a `user_id` from
            /// this API), or if the passed `GuardianInvitation` has a `state` other than `COMPLETE`, or if it modifies
            /// fields other than `state`. * `NOT_FOUND` if the student ID provided is a valid student ID, but Classroom
            /// has no record of that student, or if the `id` field does not refer to a guardian invitation known to
            /// Classroom.
            /// </summary>
            public class PatchRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.GuardianInvitation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Classroom.v1.Data.GuardianInvitation body, string studentId, string invitationId) : base(service)
                {
                    StudentId = studentId;
                    InvitationId = invitationId;
                    Body = body;
                    InitParameters();
                }

                /// <summary>The ID of the student whose guardian invitation is to be modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>The `id` field of the `GuardianInvitation` to be modified.</summary>
                [Google.Apis.Util.RequestParameterAttribute("invitationId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string InvitationId { get; private set; }

                /// <summary>
                /// Mask that identifies which fields on the course to update. This field is required to do an update.
                /// The update fails if invalid fields are specified. The following fields are valid: * `state` When set
                /// in a query parameter, this field should be specified as `updateMask=,,...`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Classroom.v1.Data.GuardianInvitation Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardianInvitations/{invitationId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("invitationId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "invitationId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
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
        }

        /// <summary>Gets the Guardians resource.</summary>
        public virtual GuardiansResource Guardians { get; }

        /// <summary>The "guardians" collection of methods.</summary>
        public class GuardiansResource
        {
            private const string Resource = "guardians";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GuardiansResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Deletes a guardian. The guardian will no longer receive guardian notifications and the guardian will no
            /// longer be accessible via the API. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if no user that matches the provided `student_id` is visible to the requesting user, if the requesting
            /// user is not permitted to manage guardians for the student identified by the `student_id`, if guardians
            /// are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT` if a
            /// `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API). * `NOT_FOUND` if the requesting user is permitted to modify guardians for
            /// the requested `student_id`, but no `Guardian` record exists for that student with the provided
            /// `guardian_id`.
            /// </summary>
            /// <param name="studentId">
            /// The student whose guardian is to be deleted. One of the following: * the numeric identifier for the user
            /// * the email address of the user * the string literal `"me"`, indicating the requesting user
            /// </param>
            /// <param name="guardianId">The `id` field from a `Guardian`.</param>
            public virtual DeleteRequest Delete(string studentId, string guardianId)
            {
                return new DeleteRequest(service, studentId, guardianId);
            }

            /// <summary>
            /// Deletes a guardian. The guardian will no longer receive guardian notifications and the guardian will no
            /// longer be accessible via the API. This method returns the following error codes: * `PERMISSION_DENIED`
            /// if no user that matches the provided `student_id` is visible to the requesting user, if the requesting
            /// user is not permitted to manage guardians for the student identified by the `student_id`, if guardians
            /// are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT` if a
            /// `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API). * `NOT_FOUND` if the requesting user is permitted to modify guardians for
            /// the requested `student_id`, but no `Guardian` record exists for that student with the provided
            /// `guardian_id`.
            /// </summary>
            public class DeleteRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string studentId, string guardianId) : base(service)
                {
                    StudentId = studentId;
                    GuardianId = guardianId;
                    InitParameters();
                }

                /// <summary>
                /// The student whose guardian is to be deleted. One of the following: * the numeric identifier for the
                /// user * the email address of the user * the string literal `"me"`, indicating the requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>The `id` field from a `Guardian`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("guardianId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GuardianId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardians/{guardianId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("guardianId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "guardianId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a specific guardian. This method returns the following error codes: * `PERMISSION_DENIED` if no
            /// user that matches the provided `student_id` is visible to the requesting user, if the requesting user is
            /// not permitted to view guardian information for the student identified by the `student_id`, if guardians
            /// are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT` if a
            /// `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API, nor the literal string `me`). * `NOT_FOUND` if the requesting user is
            /// permitted to view guardians for the requested `student_id`, but no `Guardian` record exists for that
            /// student that matches the provided `guardian_id`.
            /// </summary>
            /// <param name="studentId">
            /// The student whose guardian is being requested. One of the following: * the numeric identifier for the
            /// user * the email address of the user * the string literal `"me"`, indicating the requesting user
            /// </param>
            /// <param name="guardianId">The `id` field from a `Guardian`.</param>
            public virtual GetRequest Get(string studentId, string guardianId)
            {
                return new GetRequest(service, studentId, guardianId);
            }

            /// <summary>
            /// Returns a specific guardian. This method returns the following error codes: * `PERMISSION_DENIED` if no
            /// user that matches the provided `student_id` is visible to the requesting user, if the requesting user is
            /// not permitted to view guardian information for the student identified by the `student_id`, if guardians
            /// are not enabled for the domain in question, or for other access errors. * `INVALID_ARGUMENT` if a
            /// `student_id` is specified, but its format cannot be recognized (it is not an email address, nor a
            /// `student_id` from the API, nor the literal string `me`). * `NOT_FOUND` if the requesting user is
            /// permitted to view guardians for the requested `student_id`, but no `Guardian` record exists for that
            /// student that matches the provided `guardian_id`.
            /// </summary>
            public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.Guardian>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string studentId, string guardianId) : base(service)
                {
                    StudentId = studentId;
                    GuardianId = guardianId;
                    InitParameters();
                }

                /// <summary>
                /// The student whose guardian is being requested. One of the following: * the numeric identifier for
                /// the user * the email address of the user * the string literal `"me"`, indicating the requesting user
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>The `id` field from a `Guardian`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("guardianId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GuardianId { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardians/{guardianId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("guardianId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "guardianId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Returns a list of guardians that the requesting user is permitted to view, restricted to those that
            /// match the request. To list guardians for any student that the requesting user may view guardians for,
            /// use the literal character `-` for the student ID. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if a `student_id` is specified, and the requesting user is not permitted to view
            /// guardian information for that student, if `"-"` is specified as the `student_id` and the user is not a
            /// domain administrator, if guardians are not enabled for the domain in question, if the
            /// `invited_email_address` filter is set by a user who is not a domain administrator, or for other access
            /// errors. * `INVALID_ARGUMENT` if a `student_id` is specified, but its format cannot be recognized (it is
            /// not an email address, nor a `student_id` from the API, nor the literal string `me`). May also be
            /// returned if an invalid `page_token` is provided. * `NOT_FOUND` if a `student_id` is specified, and its
            /// format can be recognized, but Classroom has no record of that student.
            /// </summary>
            /// <param name="studentId">
            /// Filter results by the student who the guardian is linked to. The identifier can be one of the following:
            /// * the numeric identifier for the user * the email address of the user * the string literal `"me"`,
            /// indicating the requesting user * the string literal `"-"`, indicating that results should be returned
            /// for all students that the requesting user has access to view.
            /// </param>
            public virtual ListRequest List(string studentId)
            {
                return new ListRequest(service, studentId);
            }

            /// <summary>
            /// Returns a list of guardians that the requesting user is permitted to view, restricted to those that
            /// match the request. To list guardians for any student that the requesting user may view guardians for,
            /// use the literal character `-` for the student ID. This method returns the following error codes: *
            /// `PERMISSION_DENIED` if a `student_id` is specified, and the requesting user is not permitted to view
            /// guardian information for that student, if `"-"` is specified as the `student_id` and the user is not a
            /// domain administrator, if guardians are not enabled for the domain in question, if the
            /// `invited_email_address` filter is set by a user who is not a domain administrator, or for other access
            /// errors. * `INVALID_ARGUMENT` if a `student_id` is specified, but its format cannot be recognized (it is
            /// not an email address, nor a `student_id` from the API, nor the literal string `me`). May also be
            /// returned if an invalid `page_token` is provided. * `NOT_FOUND` if a `student_id` is specified, and its
            /// format can be recognized, but Classroom has no record of that student.
            /// </summary>
            public class ListRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.ListGuardiansResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string studentId) : base(service)
                {
                    StudentId = studentId;
                    InitParameters();
                }

                /// <summary>
                /// Filter results by the student who the guardian is linked to. The identifier can be one of the
                /// following: * the numeric identifier for the user * the email address of the user * the string
                /// literal `"me"`, indicating the requesting user * the string literal `"-"`, indicating that results
                /// should be returned for all students that the requesting user has access to view.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("studentId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string StudentId { get; private set; }

                /// <summary>
                /// Filter results by the email address that the original invitation was sent to, resulting in this
                /// guardian link. This filter can only be used by domain administrators.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("invitedEmailAddress", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string InvitedEmailAddress { get; set; }

                /// <summary>
                /// Maximum number of items to return. Zero or unspecified indicates that the server may assign a
                /// maximum. The server may return fewer than the specified number of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// nextPageToken value returned from a previous list call, indicating that the subsequent page of
                /// results should be returned. The list request must be otherwise identical to the one that resulted in
                /// this token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/userProfiles/{studentId}/guardians";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("studentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "studentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("invitedEmailAddress", new Google.Apis.Discovery.Parameter
                    {
                        Name = "invitedEmailAddress",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }

        /// <summary>
        /// Returns a user profile. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to access this user profile, if no profile exists with the requested ID, or
        /// for access errors.
        /// </summary>
        /// <param name="userId">
        /// Identifier of the profile to return. The identifier can be one of the following: * the numeric identifier
        /// for the user * the email address of the user * the string literal `"me"`, indicating the requesting user
        /// </param>
        public virtual GetRequest Get(string userId)
        {
            return new GetRequest(service, userId);
        }

        /// <summary>
        /// Returns a user profile. This method returns the following error codes: * `PERMISSION_DENIED` if the
        /// requesting user is not permitted to access this user profile, if no profile exists with the requested ID, or
        /// for access errors.
        /// </summary>
        public class GetRequest : ClassroomBaseServiceRequest<Google.Apis.Classroom.v1.Data.UserProfile>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userId) : base(service)
            {
                UserId = userId;
                InitParameters();
            }

            /// <summary>
            /// Identifier of the profile to return. The identifier can be one of the following: * the numeric
            /// identifier for the user * the email address of the user * the string literal `"me"`, indicating the
            /// requesting user
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("userId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserId { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/userProfiles/{userId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("userId", new Google.Apis.Discovery.Parameter
                {
                    Name = "userId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Classroom.v1.Data
{
    /// <summary>Announcement created by a teacher for students of the course</summary>
    public class Announcement : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Absolute link to this announcement in the Classroom web UI. This is only populated if `state` is
        /// `PUBLISHED`. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>Assignee mode of the announcement. If unspecified, the default value is `ALL_STUDENTS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeMode")]
        public virtual string AssigneeMode { get; set; }

        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Timestamp when this announcement was created. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>Identifier for the user that created the announcement. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual string CreatorUserId { get; set; }

        /// <summary>Classroom-assigned identifier of this announcement, unique per course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifiers of students with access to the announcement. This field is set only if `assigneeMode` is
        /// `INDIVIDUAL_STUDENTS`. If the `assigneeMode` is `INDIVIDUAL_STUDENTS`, then only students specified in this
        /// field can see the announcement.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualStudentsOptions")]
        public virtual IndividualStudentsOptions IndividualStudentsOptions { get; set; }

        /// <summary>Additional materials. Announcements must have no more than 20 material items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<Material> Materials { get; set; }

        /// <summary>Optional timestamp when this announcement is scheduled to be published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledTime")]
        public virtual object ScheduledTime { get; set; }

        /// <summary>Status of this announcement. If unspecified, the default state is `DRAFT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Description of this announcement. The text must be a valid UTF-8 string containing no more than 30,000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; }

        /// <summary>Timestamp of the most recent change to this announcement. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional details for assignments.</summary>
    public class Assignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Drive folder where attachments from student submissions are placed. This is only populated for course
        /// teachers and administrators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentWorkFolder")]
        public virtual DriveFolder StudentWorkFolder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Student work for an assignment.</summary>
    public class AssignmentSubmission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Attachments added by the student. Drive files that correspond to materials with a share mode of STUDENT_COPY
        /// may not exist yet if the student has not accessed the assignment in Classroom. Some attachment metadata is
        /// only populated if the requesting user has permission to access it. Identifier and alternate_link fields are
        /// always available, but others (for example, title) may not be.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachments")]
        public virtual System.Collections.Generic.IList<Attachment> Attachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Attachment added to student assignment work. When creating attachments, setting the `form` field is not
    /// supported.
    /// </summary>
    public class Attachment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Drive file attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual DriveFile DriveFile { get; set; }

        /// <summary>Google Forms attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual Form Form { get; set; }

        /// <summary>Link attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>Youtube video attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youTubeVideo")]
        public virtual YouTubeVideo YouTubeVideo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A reference to a Cloud Pub/Sub topic. To register for notifications, the owner of the topic must grant
    /// `classroom-notifications@system.gserviceaccount.com` the `projects.topics.publish` permission.
    /// </summary>
    public class CloudPubsubTopic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The `name` field of a Cloud Pub/Sub
        /// [Topic](https://cloud.google.com/pubsub/docs/reference/rest/v1/projects.topics#Topic).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicName")]
        public virtual string TopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Course in Classroom.</summary>
    public class Course : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Absolute link to this course in the Classroom web UI. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>
        /// The Calendar ID for a calendar that all course members can see, to which Classroom adds events for course
        /// work and announcements in the course. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calendarId")]
        public virtual string CalendarId { get; set; }

        /// <summary>
        /// The email address of a Google group containing all members of the course. This group does not accept email
        /// and can only be used for permissions. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseGroupEmail")]
        public virtual string CourseGroupEmail { get; set; }

        /// <summary>Sets of materials that appear on the "about" page of this course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseMaterialSets")]
        public virtual System.Collections.Generic.IList<CourseMaterialSet> CourseMaterialSets { get; set; }

        /// <summary>State of the course. If unspecified, the default state is `PROVISIONED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseState")]
        public virtual string CourseState { get; set; }

        /// <summary>
        /// Creation time of the course. Specifying this field in a course update mask results in an error. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>
        /// Optional description. For example, "We'll be learning about the structure of living creatures from a
        /// combination of textbooks, guest lectures, and lab work. Expect to be excited!" If set, this field must be a
        /// valid UTF-8 string and no longer than 30,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional heading for the description. For example, "Welcome to 10th Grade Biology." If set, this field must
        /// be a valid UTF-8 string and no longer than 3600 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("descriptionHeading")]
        public virtual string DescriptionHeading { get; set; }

        /// <summary>
        /// Enrollment code to use when joining this course. Specifying this field in a course update mask results in an
        /// error. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enrollmentCode")]
        public virtual string EnrollmentCode { get; set; }

        /// <summary>Whether or not guardian notifications are enabled for this course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardiansEnabled")]
        public virtual System.Nullable<bool> GuardiansEnabled { get; set; }

        /// <summary>
        /// Identifier for this course assigned by Classroom. When creating a course, you may optionally set this
        /// identifier to an alias string in the request to create a corresponding alias. The `id` is still assigned by
        /// Classroom and cannot be updated after the course is created. Specifying this field in a course update mask
        /// results in an error.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Name of the course. For example, "10th Grade Biology". The name is required. It must be between 1 and 750
        /// characters and a valid UTF-8 string.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The identifier of the owner of a course. When specified as a parameter of a create course request, this
        /// field is required. The identifier can be one of the following: * the numeric identifier for the user * the
        /// email address of the user * the string literal `"me"`, indicating the requesting user This must be set in a
        /// create request. Admins can also specify this field in a patch course request to transfer ownership. In other
        /// contexts, it is read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerId")]
        public virtual string OwnerId { get; set; }

        /// <summary>
        /// Optional room location. For example, "301". If set, this field must be a valid UTF-8 string and no longer
        /// than 650 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("room")]
        public virtual string Room { get; set; }

        /// <summary>
        /// Section of the course. For example, "Period 2". If set, this field must be a valid UTF-8 string and no
        /// longer than 2800 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("section")]
        public virtual string Section { get; set; }

        /// <summary>
        /// Information about a Drive Folder that is shared with all teachers of the course. This field will only be set
        /// for teachers of the course and domain administrators. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teacherFolder")]
        public virtual DriveFolder TeacherFolder { get; set; }

        /// <summary>
        /// The email address of a Google group containing all teachers of the course. This group does not accept email
        /// and can only be used for permissions. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teacherGroupEmail")]
        public virtual string TeacherGroupEmail { get; set; }

        /// <summary>
        /// Time of the most recent update to this course. Specifying this field in a course update mask results in an
        /// error. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Alternative identifier for a course. An alias uniquely identifies a course. It must be unique within one of the
    /// following scopes: * domain: A domain-scoped alias is visible to all users within the alias creator's domain and
    /// can be created only by a domain admin. A domain-scoped alias is often used when a course has an identifier
    /// external to Classroom. * project: A project-scoped alias is visible to any request from an application using the
    /// Developer Console project ID that created the alias and can be created by any project. A project-scoped alias is
    /// often used when an application has alternative identifiers. A random value can also be used to avoid duplicate
    /// courses in the event of transmission failures, as retrying a request will return `ALREADY_EXISTS` if a previous
    /// one has succeeded.
    /// </summary>
    public class CourseAlias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Alias string. The format of the string indicates the desired alias scoping. * `d:` indicates a domain-scoped
        /// alias. Example: `d:math_101` * `p:` indicates a project-scoped alias. Example: `p:abc123` This field has a
        /// maximum length of 256 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A material attached to a course as part of a material set.</summary>
    public class CourseMaterial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Drive file attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual DriveFile DriveFile { get; set; }

        /// <summary>Google Forms attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual Form Form { get; set; }

        /// <summary>Link atatchment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>Youtube video attachment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youTubeVideo")]
        public virtual YouTubeVideo YouTubeVideo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of materials that appears on the "About" page of the course. These materials might include a syllabus,
    /// schedule, or other background information relating to the course as a whole.
    /// </summary>
    public class CourseMaterialSet : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Materials attached to this set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<CourseMaterial> Materials { get; set; }

        /// <summary>Title for this set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a `Feed` with a `feed_type` of `COURSE_ROSTER_CHANGES`.</summary>
    public class CourseRosterChangesInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `course_id` of the course to subscribe to roster changes for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Course work created by a teacher for students of the course.</summary>
    public class CourseWork : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Absolute link to this course work in the Classroom web UI. This is only populated if `state` is `PUBLISHED`.
        /// Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>Assignee mode of the coursework. If unspecified, the default value is `ALL_STUDENTS`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeMode")]
        public virtual string AssigneeMode { get; set; }

        /// <summary>Assignment details. This is populated only when `work_type` is `ASSIGNMENT`. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignment")]
        public virtual Assignment Assignment { get; set; }

        /// <summary>
        /// Whether this course work item is associated with the Developer Console project making the request. See
        /// CreateCourseWork for more details. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedWithDeveloper")]
        public virtual System.Nullable<bool> AssociatedWithDeveloper { get; set; }

        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Timestamp when this course work was created. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>Identifier for the user that created the coursework. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual string CreatorUserId { get; set; }

        /// <summary>
        /// Optional description of this course work. If set, the description must be a valid UTF-8 string containing no
        /// more than 30,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional date, in UTC, that submissions for this course work are due. This must be specified if `due_time`
        /// is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dueDate")]
        public virtual Date DueDate { get; set; }

        /// <summary>
        /// Optional time of day, in UTC, that submissions for this course work are due. This must be specified if
        /// `due_date` is specified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dueTime")]
        public virtual TimeOfDay DueTime { get; set; }

        /// <summary>Classroom-assigned identifier of this course work, unique per course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifiers of students with access to the coursework. This field is set only if `assigneeMode` is
        /// `INDIVIDUAL_STUDENTS`. If the `assigneeMode` is `INDIVIDUAL_STUDENTS`, then only students specified in this
        /// field are assigned the coursework.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualStudentsOptions")]
        public virtual IndividualStudentsOptions IndividualStudentsOptions { get; set; }

        /// <summary>Additional materials. CourseWork must have no more than 20 material items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<Material> Materials { get; set; }

        /// <summary>
        /// Maximum grade for this course work. If zero or unspecified, this assignment is considered ungraded. This
        /// must be a non-negative integer value.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPoints")]
        public virtual System.Nullable<double> MaxPoints { get; set; }

        /// <summary>
        /// Multiple choice question details. For read operations, this field is populated only when `work_type` is
        /// `MULTIPLE_CHOICE_QUESTION`. For write operations, this field must be specified when creating course work
        /// with a `work_type` of `MULTIPLE_CHOICE_QUESTION`, and it must not be set otherwise.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleChoiceQuestion")]
        public virtual MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }

        /// <summary>Optional timestamp when this course work is scheduled to be published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledTime")]
        public virtual object ScheduledTime { get; set; }

        /// <summary>Status of this course work. If unspecified, the default state is `DRAFT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Setting to determine when students are allowed to modify submissions. If unspecified, the default value is
        /// `MODIFIABLE_UNTIL_TURNED_IN`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submissionModificationMode")]
        public virtual string SubmissionModificationMode { get; set; }

        /// <summary>
        /// Title of this course work. The title must be a valid UTF-8 string containing between 1 and 3000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Identifier for the topic that this coursework is associated with. Must match an existing topic in the
        /// course.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicId { get; set; }

        /// <summary>Timestamp of the most recent change to this course work. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>
        /// Type of this course work. The type is set when the course work is created and cannot be changed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("workType")]
        public virtual string WorkType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about a `Feed` with a `feed_type` of `COURSE_WORK_CHANGES`.</summary>
    public class CourseWorkChangesInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The `course_id` of the course to subscribe to work changes for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Course work material created by a teacher for students of the course</summary>
    public class CourseWorkMaterial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Absolute link to this course work material in the Classroom web UI. This is only populated if `state` is
        /// `PUBLISHED`. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>
        /// Assignee mode of the course work material. If unspecified, the default value is `ALL_STUDENTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeMode")]
        public virtual string AssigneeMode { get; set; }

        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Timestamp when this course work material was created. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>Identifier for the user that created the course work material. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creatorUserId")]
        public virtual string CreatorUserId { get; set; }

        /// <summary>
        /// Optional description of this course work material. The text must be a valid UTF-8 string containing no more
        /// than 30,000 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Classroom-assigned identifier of this course work material, unique per course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Identifiers of students with access to the course work material. This field is set only if `assigneeMode` is
        /// `INDIVIDUAL_STUDENTS`. If the `assigneeMode` is `INDIVIDUAL_STUDENTS`, then only students specified in this
        /// field can see the course work material.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("individualStudentsOptions")]
        public virtual IndividualStudentsOptions IndividualStudentsOptions { get; set; }

        /// <summary>Additional materials. A course work material must have no more than 20 material items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("materials")]
        public virtual System.Collections.Generic.IList<Material> Materials { get; set; }

        /// <summary>Optional timestamp when this course work material is scheduled to be published.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scheduledTime")]
        public virtual object ScheduledTime { get; set; }

        /// <summary>Status of this course work material. If unspecified, the default state is `DRAFT`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Title of this course work material. The title must be a valid UTF-8 string containing between 1 and 3000
        /// characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Identifier for the topic that this course work material is associated with. Must match an existing topic in
        /// the course.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicId { get; set; }

        /// <summary>Timestamp of the most recent change to this course work material. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values * A month and day value, with a zero
    /// year, such as an anniversary * A year on its own, with zero month and day values * A year and month value, with
    /// a zero day, such as a credit card expiration date Related types are google.type.TimeOfDay and
    /// `google.protobuf.Timestamp`.
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Google Drive file.</summary>
    public class DriveFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL that can be used to access the Drive item. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>Drive API resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URL of a thumbnail image of the Drive item. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Title of the Drive item. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of a Google Drive folder.</summary>
    public class DriveFolder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL that can be used to access the Drive folder. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>Drive API resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Title of the Drive folder. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

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
    /// A class of notifications that an application can register to receive. For example: "all roster changes for a
    /// domain".
    /// </summary>
    public class Feed : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Information about a `Feed` with a `feed_type` of `COURSE_ROSTER_CHANGES`. This field must be specified if
        /// `feed_type` is `COURSE_ROSTER_CHANGES`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseRosterChangesInfo")]
        public virtual CourseRosterChangesInfo CourseRosterChangesInfo { get; set; }

        /// <summary>
        /// Information about a `Feed` with a `feed_type` of `COURSE_WORK_CHANGES`. This field must be specified if
        /// `feed_type` is `COURSE_WORK_CHANGES`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseWorkChangesInfo")]
        public virtual CourseWorkChangesInfo CourseWorkChangesInfo { get; set; }

        /// <summary>The type of feed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feedType")]
        public virtual string FeedType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Google Forms item.</summary>
    public class Form : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of the form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formUrl")]
        public virtual string FormUrl { get; set; }

        /// <summary>
        /// URL of the form responses document. Only set if respsonses have been recorded and only when the requesting
        /// user is an editor of the form. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseUrl")]
        public virtual string ResponseUrl { get; set; }

        /// <summary>URL of a thumbnail image of the Form. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Title of the Form. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Global user permission description.</summary>
    public class GlobalPermission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Permission value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The history of each grade on this submission.</summary>
    public class GradeHistory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The teacher who made the grade change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorUserId")]
        public virtual string ActorUserId { get; set; }

        /// <summary>The type of grade change at this time in the submission grade history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gradeChangeType")]
        public virtual string GradeChangeType { get; set; }

        /// <summary>When the grade of the submission was changed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gradeTimestamp")]
        public virtual object GradeTimestamp { get; set; }

        /// <summary>The denominator of the grade at this time in the submission grade history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxPoints")]
        public virtual System.Nullable<double> MaxPoints { get; set; }

        /// <summary>The numerator of the grade at this time in the submission grade history.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pointsEarned")]
        public virtual System.Nullable<double> PointsEarned { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Association between a student and a guardian of that student. The guardian may receive information about the
    /// student's course work.
    /// </summary>
    public class Guardian : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier for the guardian.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardianId")]
        public virtual string GuardianId { get; set; }

        /// <summary>User profile for the guardian.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardianProfile")]
        public virtual UserProfile GuardianProfile { get; set; }

        /// <summary>
        /// The email address to which the initial guardian invitation was sent. This field is only visible to domain
        /// administrators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitedEmailAddress")]
        public virtual string InvitedEmailAddress { get; set; }

        /// <summary>Identifier for the student to whom the guardian relationship applies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentId")]
        public virtual string StudentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An invitation to become the guardian of a specified user, sent to a specified email address.</summary>
    public class GuardianInvitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time that this invitation was created. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>Unique identifier for this invitation. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitationId")]
        public virtual string InvitationId { get; set; }

        /// <summary>
        /// Email address that the invitation was sent to. This field is only visible to domain administrators.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitedEmailAddress")]
        public virtual string InvitedEmailAddress { get; set; }

        /// <summary>The state that this invitation is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>ID of the student (in standard format)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentId")]
        public virtual string StudentId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Assignee details about a coursework/announcement. This field is set if and only if `assigneeMode` is
    /// `INDIVIDUAL_STUDENTS`.
    /// </summary>
    public class IndividualStudentsOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifiers for the students that have access to the coursework/announcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentIds")]
        public virtual System.Collections.Generic.IList<string> StudentIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An invitation to join a course.</summary>
    public class Invitation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the course to invite the user to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Identifier assigned by Classroom. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Role to invite the user to have. Must not be `COURSE_ROLE_UNSPECIFIED`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>
        /// Identifier of the invited user. When specified as a parameter of a request, this identifier can be set to
        /// one of the following: * the numeric identifier for the user * the email address of the user * the string
        /// literal `"me"`, indicating the requesting user
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>URL item.</summary>
    public class Link : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL of a thumbnail image of the target URL. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Title of the target of the URL. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// URL to link to. This must be a valid UTF-8 string containing between 1 and 2024 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing course work.</summary>
    public class ListAnnouncementsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Announcement items that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("announcements")]
        public virtual System.Collections.Generic.IList<Announcement> Announcements { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing course aliases.</summary>
    public class ListCourseAliasesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The course aliases.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<CourseAlias> Aliases { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing course work material.</summary>
    public class ListCourseWorkMaterialResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Course work material items that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseWorkMaterial")]
        public virtual System.Collections.Generic.IList<CourseWorkMaterial> CourseWorkMaterial { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing course work.</summary>
    public class ListCourseWorkResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Course work items that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseWork")]
        public virtual System.Collections.Generic.IList<CourseWork> CourseWork { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing courses.</summary>
    public class ListCoursesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Courses that match the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courses")]
        public virtual System.Collections.Generic.IList<Course> Courses { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing guardian invitations.</summary>
    public class ListGuardianInvitationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Guardian invitations that matched the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardianInvitations")]
        public virtual System.Collections.Generic.IList<GuardianInvitation> GuardianInvitations { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing guardians.</summary>
    public class ListGuardiansResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Guardians on this page of results that met the criteria specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("guardians")]
        public virtual System.Collections.Generic.IList<Guardian> Guardians { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing invitations.</summary>
    public class ListInvitationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Invitations that match the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invitations")]
        public virtual System.Collections.Generic.IList<Invitation> Invitations { get; set; }

        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing student submissions.</summary>
    public class ListStudentSubmissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Student work that matches the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentSubmissions")]
        public virtual System.Collections.Generic.IList<StudentSubmission> StudentSubmissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing students.</summary>
    public class ListStudentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Students who match the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("students")]
        public virtual System.Collections.Generic.IList<Student> Students { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing teachers.</summary>
    public class ListTeachersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Teachers who match the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("teachers")]
        public virtual System.Collections.Generic.IList<Teacher> Teachers { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response when listing topics.</summary>
    public class ListTopicResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Token identifying the next page of results to return. If empty, no further results are available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Topic items that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual System.Collections.Generic.IList<Topic> Topic { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Material attached to course work. When creating attachments, setting the `form` field is not supported.
    /// </summary>
    public class Material : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Drive file material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual SharedDriveFile DriveFile { get; set; }

        /// <summary>Google Forms material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual Form Form { get; set; }

        /// <summary>
        /// Link material. On creation, this is upgraded to a more appropriate type if possible, and this is reflected
        /// in the response.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual Link Link { get; set; }

        /// <summary>YouTube video material.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("youtubeVideo")]
        public virtual YouTubeVideo YoutubeVideo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to modify assignee mode and options of an announcement.</summary>
    public class ModifyAnnouncementAssigneesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mode of the announcement describing whether it is accessible by all students or specified individual
        /// students.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeMode")]
        public virtual string AssigneeMode { get; set; }

        /// <summary>
        /// Set which students can view or cannot view the announcement. Must be specified only when `assigneeMode` is
        /// `INDIVIDUAL_STUDENTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifyIndividualStudentsOptions")]
        public virtual ModifyIndividualStudentsOptions ModifyIndividualStudentsOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to modify the attachments of a student submission.</summary>
    public class ModifyAttachmentsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Attachments to add. A student submission may not have more than 20 attachments. Form attachments are not
        /// supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addAttachments")]
        public virtual System.Collections.Generic.IList<Attachment> AddAttachments { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to modify assignee mode and options of a coursework.</summary>
    public class ModifyCourseWorkAssigneesRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Mode of the coursework describing whether it will be assigned to all students or specified individual
        /// students.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assigneeMode")]
        public virtual string AssigneeMode { get; set; }

        /// <summary>
        /// Set which students are assigned or not assigned to the coursework. Must be specified only when
        /// `assigneeMode` is `INDIVIDUAL_STUDENTS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modifyIndividualStudentsOptions")]
        public virtual ModifyIndividualStudentsOptions ModifyIndividualStudentsOptions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Contains fields to add or remove students from a course work or announcement where the `assigneeMode` is set to
    /// `INDIVIDUAL_STUDENTS`.
    /// </summary>
    public class ModifyIndividualStudentsOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>IDs of students to be added as having access to this coursework/announcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addStudentIds")]
        public virtual System.Collections.Generic.IList<string> AddStudentIds { get; set; }

        /// <summary>IDs of students to be removed from having access to this coursework/announcement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("removeStudentIds")]
        public virtual System.Collections.Generic.IList<string> RemoveStudentIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional details for multiple-choice questions.</summary>
    public class MultipleChoiceQuestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Possible choices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("choices")]
        public virtual System.Collections.Generic.IList<string> Choices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Student work for a multiple-choice question.</summary>
    public class MultipleChoiceSubmission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Student's select choice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of the user's name.</summary>
    public class Name : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's last name. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; }

        /// <summary>The user's full name formed by concatenating the first and last name values. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; }

        /// <summary>The user's first name. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to reclaim a student submission.</summary>
    public class ReclaimStudentSubmissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An instruction to Classroom to send notifications from the `feed` to the provided destination.
    /// </summary>
    public class Registration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Cloud Pub/Sub topic that notifications are to be sent to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudPubsubTopic")]
        public virtual CloudPubsubTopic CloudPubsubTopic { get; set; }

        /// <summary>
        /// The time until which the `Registration` is effective. This is a read-only field assigned by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual object ExpiryTime { get; set; }

        /// <summary>
        /// Specification for the class of notifications that Classroom should deliver to the destination.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feed")]
        public virtual Feed Feed { get; set; }

        /// <summary>A server-generated unique identifier for this `Registration`. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("registrationId")]
        public virtual string RegistrationId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to return a student submission.</summary>
    public class ReturnStudentSubmissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Drive file that is used as material for course work.</summary>
    public class SharedDriveFile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Drive file details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("driveFile")]
        public virtual DriveFile DriveFile { get; set; }

        /// <summary>Mechanism by which students access the Drive item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareMode")]
        public virtual string ShareMode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Student work for a short answer question.</summary>
    public class ShortAnswerSubmission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Student response to a short-answer question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The history of each state this submission has been in.</summary>
    public class StateHistory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The teacher or student who made the change.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actorUserId")]
        public virtual string ActorUserId { get; set; }

        /// <summary>The workflow pipeline stage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>When the submission entered this state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateTimestamp")]
        public virtual object StateTimestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Student in a course.</summary>
    public class Student : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Global user information for the student. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual UserProfile Profile { get; set; }

        /// <summary>
        /// Information about a Drive Folder for this student's work in this course. Only visible to the student and
        /// domain administrators. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("studentWorkFolder")]
        public virtual DriveFolder StudentWorkFolder { get; set; }

        /// <summary>
        /// Identifier of the user. When specified as a parameter of a request, this identifier can be one of the
        /// following: * the numeric identifier for the user * the email address of the user * the string literal
        /// `"me"`, indicating the requesting user
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Student submission for course work. StudentSubmission items are generated when a CourseWork item is created.
    /// StudentSubmissions that have never been accessed (i.e. with `state` = NEW) may not have a creation time or
    /// update time.
    /// </summary>
    public class StudentSubmission : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Absolute link to the submission in the Classroom web UI. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>
        /// Optional grade. If unset, no grade was set. This value must be non-negative. Decimal (that is, non-integer)
        /// values are allowed, but are rounded to two decimal places. This may be modified only by course teachers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedGrade")]
        public virtual System.Nullable<double> AssignedGrade { get; set; }

        /// <summary>
        /// Submission content when course_work_type is ASSIGNMENT. Students can modify this content using
        /// ModifyAttachments.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignmentSubmission")]
        public virtual AssignmentSubmission AssignmentSubmission { get; set; }

        /// <summary>
        /// Whether this student submission is associated with the Developer Console project making the request. See
        /// CreateCourseWork for more details. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedWithDeveloper")]
        public virtual System.Nullable<bool> AssociatedWithDeveloper { get; set; }

        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Identifier for the course work this corresponds to. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseWorkId")]
        public virtual string CourseWorkId { get; set; }

        /// <summary>Type of course work this submission is for. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseWorkType")]
        public virtual string CourseWorkType { get; set; }

        /// <summary>
        /// Creation time of this submission. This may be unset if the student has not accessed this item. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual object CreationTime { get; set; }

        /// <summary>
        /// Optional pending grade. If unset, no grade was set. This value must be non-negative. Decimal (that is,
        /// non-integer) values are allowed, but are rounded to two decimal places. This is only visible to and
        /// modifiable by course teachers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("draftGrade")]
        public virtual System.Nullable<double> DraftGrade { get; set; }

        /// <summary>
        /// Classroom-assigned Identifier for the student submission. This is unique among submissions for the relevant
        /// course work. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Whether this submission is late. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("late")]
        public virtual System.Nullable<bool> Late { get; set; }

        /// <summary>Submission content when course_work_type is MULTIPLE_CHOICE_QUESTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multipleChoiceSubmission")]
        public virtual MultipleChoiceSubmission MultipleChoiceSubmission { get; set; }

        /// <summary>Submission content when course_work_type is SHORT_ANSWER_QUESTION.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shortAnswerSubmission")]
        public virtual ShortAnswerSubmission ShortAnswerSubmission { get; set; }

        /// <summary>State of this submission. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The history of the submission (includes state and grade histories). Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submissionHistory")]
        public virtual System.Collections.Generic.IList<SubmissionHistory> SubmissionHistory { get; set; }

        /// <summary>
        /// Last update time of this submission. This may be unset if the student has not accessed this item. Read-only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>Identifier for the student that owns this submission. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The history of the submission. This currently includes state and grade histories.</summary>
    public class SubmissionHistory : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The grade history information of the submission, if present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gradeHistory")]
        public virtual GradeHistory GradeHistory { get; set; }

        /// <summary>The state history information of the submission, if present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateHistory")]
        public virtual StateHistory StateHistory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Teacher of a course.</summary>
    public class Teacher : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>Global user information for the teacher. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profile")]
        public virtual UserProfile Profile { get; set; }

        /// <summary>
        /// Identifier of the user. When specified as a parameter of a request, this identifier can be one of the
        /// following: * the numeric identifier for the user * the email address of the user * the string literal
        /// `"me"`, indicating the requesting user
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a time of day. The date and time zone are either not significant or are specified elsewhere. An API
    /// may choose to allow leap seconds. Related types are google.type.Date and `google.protobuf.Timestamp`.
    /// </summary>
    public class TimeOfDay : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Hours of day in 24 hour format. Should be from 0 to 23. An API may choose to allow the value "24:00:00" for
        /// scenarios like business closing time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hours")]
        public virtual System.Nullable<int> Hours { get; set; }

        /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minutes")]
        public virtual System.Nullable<int> Minutes { get; set; }

        /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nanos")]
        public virtual System.Nullable<int> Nanos { get; set; }

        /// <summary>
        /// Seconds of minutes of the time. Must normally be from 0 to 59. An API may allow the value 60 if it allows
        /// leap-seconds.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("seconds")]
        public virtual System.Nullable<int> Seconds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Topic created by a teacher for the course</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Identifier of the course. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("courseId")]
        public virtual string CourseId { get; set; }

        /// <summary>
        /// The name of the topic, generated by the user. Leading and trailing whitespaces, if any, are trimmed. Also,
        /// multiple consecutive whitespaces are collapsed into one inside the name. The result must be a non-empty
        /// string. Topic names are case sensitive, and must be no longer than 100 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Unique identifier for the topic. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topicId")]
        public virtual string TopicId { get; set; }

        /// <summary>The time the topic was last updated by the system. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request to turn in a student submission.</summary>
    public class TurnInStudentSubmissionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Global information for a user.</summary>
    public class UserProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email address of the user. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emailAddress")]
        public virtual string EmailAddress { get; set; }

        /// <summary>Identifier of the user. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>Name of the user. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual Name Name { get; set; }

        /// <summary>Global permissions of the user. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<GlobalPermission> Permissions { get; set; }

        /// <summary>URL of user's profile photo. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoUrl")]
        public virtual string PhotoUrl { get; set; }

        /// <summary>
        /// Represents whether a G Suite for Education user's domain administrator has explicitly verified them as being
        /// a teacher. If the user is not a member of a G Suite for Education domain, than this field is always false.
        /// Read-only
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verifiedTeacher")]
        public virtual System.Nullable<bool> VerifiedTeacher { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>YouTube video item.</summary>
    public class YouTubeVideo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>URL that can be used to view the YouTube video. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateLink")]
        public virtual string AlternateLink { get; set; }

        /// <summary>YouTube API resource ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>URL of a thumbnail image of the YouTube video. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUrl")]
        public virtual string ThumbnailUrl { get; set; }

        /// <summary>Title of the YouTube video. Read-only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
