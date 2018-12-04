# atrium.Api.MembersApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregateMember**](MembersApi.md#aggregatemember) | **POST** /users/{user_guid}/members/{member_guid}/aggregate | Aggregate member
[**CreateMember**](MembersApi.md#createmember) | **POST** /users/{user_guid}/members | Create member
[**DeleteMember**](MembersApi.md#deletemember) | **DELETE** /users/{user_guid}/members/{member_guid} | Delete member
[**ListMemberAccounts**](MembersApi.md#listmemberaccounts) | **GET** /users/{user_guid}/members/{member_guid}/accounts | List member accounts
[**ListMemberCredentials**](MembersApi.md#listmembercredentials) | **GET** /users/{user_guid}/members/{member_guid}/credentials | List member credentials
[**ListMemberMFAChallenges**](MembersApi.md#listmembermfachallenges) | **GET** /users/{user_guid}/members/{member_guid}/challenges | List member MFA challenges
[**ListMemberTransactions**](MembersApi.md#listmembertransactions) | **GET** /users/{user_guid}/members/{member_guid}/transactions | List member transactions
[**ListMembers**](MembersApi.md#listmembers) | **GET** /users/{user_guid}/members | List members
[**ReadMember**](MembersApi.md#readmember) | **GET** /users/{user_guid}/members/{member_guid} | Read member
[**ReadMemberStatus**](MembersApi.md#readmemberstatus) | **GET** /users/{user_guid}/members/{member_guid}/status | Read member connection status
[**ResumeMember**](MembersApi.md#resumemember) | **PUT** /users/{user_guid}/members/{member_guid}/resume | Resume aggregation from MFA
[**UpdateMember**](MembersApi.md#updatemember) | **PUT** /users/{user_guid}/members/{member_guid} | Update member


<a name="aggregatemember"></a>
# **AggregateMember**
> Member AggregateMember (string memberGuid, string userGuid)

Aggregate member

Calling this endpoint initiates an aggregation event for the member. This brings in the latest account and transaction data from the connected institution. If this data has recently been updated, MX may not initiate an aggregation event. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class AggregateMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Aggregate member
                Member result = apiInstance.AggregateMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.AggregateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmember"></a>
# **CreateMember**
> Member CreateMember (string userGuid, MemberCreateRequestBody body)

Create member

This endpoint allows you to create a new member. Members are created with the required parameters credentials and institution_code, and the optional parameters identifier and metadata.<br> When creating a member, you'll need to include the correct type of credential required by the financial institution and provided by the user. You can find out which credential type is required with the /institutions/{institution_code}/credentials endpoint.<br> If successful, Atrium will respond with the newly-created member object.<br> Once you successfully create a member, MX will immediately validate the provided credentials and attempt to aggregate data for accounts and transactions. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class CreateMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var body = new MemberCreateRequestBody(); // MemberCreateRequestBody | Member object to be created with optional parameters (identifier and metadata) and required parameters (credentials and institution_code)

            try
            {
                // Create member
                Member result = apiInstance.CreateMember(userGuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.CreateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **body** | [**MemberCreateRequestBody**](MemberCreateRequestBody.md)| Member object to be created with optional parameters (identifier and metadata) and required parameters (credentials and institution_code) | 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemember"></a>
# **DeleteMember**
> void DeleteMember (string memberGuid, string userGuid)

Delete member

Accessing this endpoint will permanently delete a member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class DeleteMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Delete member
                apiInstance.DeleteMember(memberGuid, userGuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.DeleteMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmemberaccounts"></a>
# **ListMemberAccounts**
> Accounts ListMemberAccounts (string memberGuid, string userGuid, int? page = null, int? recordsPerPage = null)

List member accounts

This endpoint returns an array with information about every account associated with a particular member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListMemberAccountsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List member accounts
                Accounts result = apiInstance.ListMemberAccounts(memberGuid, userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ListMemberAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**Accounts**](Accounts.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembercredentials"></a>
# **ListMemberCredentials**
> Credentials ListMemberCredentials (string memberGuid, string userGuid)

List member credentials

This endpoint returns an array which contains information on every non-MFA credential associated with a specific member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListMemberCredentialsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // List member credentials
                Credentials result = apiInstance.ListMemberCredentials(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ListMemberCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**Credentials**](Credentials.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembermfachallenges"></a>
# **ListMemberMFAChallenges**
> Challenges ListMemberMFAChallenges (string memberGuid, string userGuid)

List member MFA challenges

Use this endpoint for information on what multi-factor authentication challenges need to be answered in order to aggregate a member.<br> If the aggregation is not challenged, i.e., the member does not have a connection status of CHALLENGED, then code 204 No Content will be returned.<br> If the aggregation has been challenged, i.e., the member does have a connection status of CHALLENGED, then code 200 OK will be returned — along with the corresponding credentials. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListMemberMFAChallengesExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // List member MFA challenges
                Challenges result = apiInstance.ListMemberMFAChallenges(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ListMemberMFAChallenges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**Challenges**](Challenges.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembertransactions"></a>
# **ListMemberTransactions**
> Transactions ListMemberTransactions (string memberGuid, string userGuid, string fromDate = null, string toDate = null, int? page = null, int? recordsPerPage = null)

List member transactions

Use this endpoint to get all transactions from all accounts associated with a specific member.<br> This endpoint accepts optional URL query parameters — from_date and to_date — which are used to filter transactions according to the date they were posted. If no values are given for the query parameters, from_date will default to 90 days prior to the request and to_date will default to 5 days from the time of the request. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListMemberTransactionsExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var fromDate = fromDate_example;  // string | Filter transactions from this date. (optional) 
            var toDate = toDate_example;  // string | Filter transactions to this date. (optional) 
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List member transactions
                Transactions result = apiInstance.ListMemberTransactions(memberGuid, userGuid, fromDate, toDate, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ListMemberTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **fromDate** | **string**| Filter transactions from this date. | [optional] 
 **toDate** | **string**| Filter transactions to this date. | [optional] 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**Transactions**](Transactions.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembers"></a>
# **ListMembers**
> Members ListMembers (string userGuid, int? page = null, int? recordsPerPage = null)

List members

This endpoint returns an array which contains information on every member associated with a specific user.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ListMembersExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var page = 12;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List members
                Members result = apiInstance.ListMembers(userGuid, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ListMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **page** | **int?**| Specify current page. | [optional] 
 **recordsPerPage** | **int?**| Specify records per page. | [optional] 

### Return type

[**Members**](Members.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmember"></a>
# **ReadMember**
> Member ReadMember (string memberGuid, string userGuid)

Read member

Use this endpoint to read the attributes of a specific member.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ReadMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read member
                Member result = apiInstance.ReadMember(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ReadMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmemberstatus"></a>
# **ReadMemberStatus**
> MemberConnectionStatus ReadMemberStatus (string memberGuid, string userGuid)

Read member connection status

This endpoint provides the status of the member's most recent aggregation event. This is an important step in the aggregation process, and the results returned by this endpoint should determine what you do next in order to successfully aggregate a member.<br> MX has introduced new, more detailed information on the current status of a member's connection to a financial institution and the state of its aggregation: the connection_status field. These are intended to replace and expand upon the information provided in the status field, which will soon be deprecated; support for the status field remains for the time being. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ReadMemberStatusExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.

            try
            {
                // Read member connection status
                MemberConnectionStatus result = apiInstance.ReadMemberStatus(memberGuid, userGuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ReadMemberStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 

### Return type

[**MemberConnectionStatus**](MemberConnectionStatus.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resumemember"></a>
# **ResumeMember**
> Member ResumeMember (string memberGuid, string userGuid, MemberResumeRequestBody body)

Resume aggregation from MFA

This endpoint answers the challenges needed when a member has been challenged by multi-factor authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class ResumeMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var body = new MemberResumeRequestBody(); // MemberResumeRequestBody | Member object with MFA challenge answers

            try
            {
                // Resume aggregation from MFA
                Member result = apiInstance.ResumeMember(memberGuid, userGuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.ResumeMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **body** | [**MemberResumeRequestBody**](MemberResumeRequestBody.md)| Member object with MFA challenge answers | 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemember"></a>
# **UpdateMember**
> Member UpdateMember (string memberGuid, string userGuid, MemberUpdateRequestBody body = null)

Update member

Use this endpoint to update a member's attributes. Only the credentials, identifier, and metadata parameters can be updated. To get a list of the required credentials for the member, use the list member credentials endpoint. 

### Example
```csharp
using System;
using System.Diagnostics;
using atrium.Api;
using atrium.Client;
using atrium.Model;

namespace Example
{
    public class UpdateMemberExample
    {
        public void main()
        {
            // Configure API Key authorization
            Configuration.Default.AddApiKey("MX-API-Key", "YOUR_API_KEY");

            // Configure Client ID authorization
            Configuration.Default.AddApiKey("MX-Client-ID", "YOUR_CLIENT_ID");

            var apiInstance = new MembersApi();
            var memberGuid = memberGuid_example;  // string | The unique identifier for a `member`.
            var userGuid = userGuid_example;  // string | The unique identifier for a `user`.
            var body = new MemberUpdateRequestBody(); // MemberUpdateRequestBody | Member object to be updated with optional parameters (credentials, identifier, metadata) (optional) 

            try
            {
                // Update member
                Member result = apiInstance.UpdateMember(memberGuid, userGuid, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MembersApi.UpdateMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **memberGuid** | **string**| The unique identifier for a &#x60;member&#x60;. | 
 **userGuid** | **string**| The unique identifier for a &#x60;user&#x60;. | 
 **body** | [**MemberUpdateRequestBody**](MemberUpdateRequestBody.md)| Member object to be updated with optional parameters (credentials, identifier, metadata) | [optional] 

### Return type

[**Member**](Member.md)

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

