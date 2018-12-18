# Atrium - the C# library for the MX API

The MX Atrium API supports over 48,000 data connections to thousands of financial institutions. It provides secure access to your users' accounts and transactions with industry-leading cleansing, categorization, and classification.  Atrium is designed according to resource-oriented REST architecture and responds with JSON bodies and HTTP response codes.  Use Atrium's development environment, vestibule.mx.com, to quickly get up and running. The development environment limits are 100 users, 25 members per user, and access to the top 15 institutions. Contact MX to purchase production access. 

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```


<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;
```
<a name="getting-started"></a>
## Example Usage

Please see `docs` directory for additional endpoint examples

```csharp
using System;
using Atrium.Api;
using Atrium.Model;

namespace Example
{
    public class Example
    {
        public void main()
        { 
            var client = new AtriumClient("YOUR_API_KEY", "YOUR_CLIENT_ID");

            var accountGuid = "ACT-123";  // string | The unique identifier for an `account`.
            var userGuid = "USR-123";  // string | The unique identifier for a `user`.
            var fromDate = "2016-09-20";  // string | Filter transactions from this date. (optional) 
            var toDate = "2016-10-20";  // string | Filter transactions to this date. (optional) 
            var page = 1;  // int? | Specify current page. (optional) 
            var recordsPerPage = 12;  // int? | Specify records per page. (optional) 

            try
            {
                // List account transactions
                TransactionsResponseBody response = client.accounts.ListAccountTransactions(accountGuid, userGuid, fromDate, toDate, page, recordsPerPage);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling AccountsApi.ListAccountTransactions: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://vestibule.mx.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**ListAccountTransactions**](docs/AccountsApi.md#listaccounttransactions) | **GET** /users/{user_guid}/accounts/{account_guid}/transactions | List account transactions
*AccountsApi* | [**ListUserAccounts**](docs/AccountsApi.md#listuseraccounts) | **GET** /users/{user_guid}/accounts | List accounts for a user
*AccountsApi* | [**ReadAccount**](docs/AccountsApi.md#readaccount) | **GET** /users/{user_guid}/accounts/{account_guid} | Read an account
*AccountsApi* | [**ReadAccountByMemberGUID**](docs/AccountsApi.md#readaccountbymemberguid) | **GET** /users/{user_guid}/members/{member_guid}/accounts/{account_guid} | Read an account
*ConnectWidgetApi* | [**GetConnectWidget**](docs/ConnectWidgetApi.md#getconnectwidget) | **POST** /users/{user_guid}/connect_widget_url | Embedding in a website
*HoldingsApi* | [**ListHoldings**](docs/HoldingsApi.md#listholdings) | **GET** /users/{user_guid}/holdings | List holdings
*HoldingsApi* | [**ListHoldingsByAccount**](docs/HoldingsApi.md#listholdingsbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/holdings | List holdings by account
*HoldingsApi* | [**ListHoldingsByMember**](docs/HoldingsApi.md#listholdingsbymember) | **GET** /users/{user_guid}/members/{member_guid}/holdings | List holdings by member
*HoldingsApi* | [**ReadHolding**](docs/HoldingsApi.md#readholding) | **GET** /users/{user_guid}/holdings/{holding_guid} | Read holding
*IdentityApi* | [**IdentifyMember**](docs/IdentityApi.md#identifymember) | **POST** /users/{user_guid}/members/{member_guid}/identify | Identify
*IdentityApi* | [**ListAccountOwners**](docs/IdentityApi.md#listaccountowners) | **GET** /users/{user_guid}/members/{member_guid}/account_owners | List member account owners
*InstitutionsApi* | [**ListInstitutions**](docs/InstitutionsApi.md#listinstitutions) | **GET** /institutions | List institutions
*InstitutionsApi* | [**ReadInstitution**](docs/InstitutionsApi.md#readinstitution) | **GET** /institutions/{institution_code} | Read institution
*InstitutionsApi* | [**ReadInstitutionCredentials**](docs/InstitutionsApi.md#readinstitutioncredentials) | **GET** /institutions/{institution_code}/credentials | Read institution credentials
*MembersApi* | [**AggregateMember**](docs/MembersApi.md#aggregatemember) | **POST** /users/{user_guid}/members/{member_guid}/aggregate | Aggregate member
*MembersApi* | [**CreateMember**](docs/MembersApi.md#createmember) | **POST** /users/{user_guid}/members | Create member
*MembersApi* | [**DeleteMember**](docs/MembersApi.md#deletemember) | **DELETE** /users/{user_guid}/members/{member_guid} | Delete member
*MembersApi* | [**ListMemberAccounts**](docs/MembersApi.md#listmemberaccounts) | **GET** /users/{user_guid}/members/{member_guid}/accounts | List member accounts
*MembersApi* | [**ListMemberCredentials**](docs/MembersApi.md#listmembercredentials) | **GET** /users/{user_guid}/members/{member_guid}/credentials | List member credentials
*MembersApi* | [**ListMemberMFAChallenges**](docs/MembersApi.md#listmembermfachallenges) | **GET** /users/{user_guid}/members/{member_guid}/challenges | List member MFA challenges
*MembersApi* | [**ListMemberTransactions**](docs/MembersApi.md#listmembertransactions) | **GET** /users/{user_guid}/members/{member_guid}/transactions | List member transactions
*MembersApi* | [**ListMembers**](docs/MembersApi.md#listmembers) | **GET** /users/{user_guid}/members | List members
*MembersApi* | [**ReadMember**](docs/MembersApi.md#readmember) | **GET** /users/{user_guid}/members/{member_guid} | Read member
*MembersApi* | [**ReadMemberStatus**](docs/MembersApi.md#readmemberstatus) | **GET** /users/{user_guid}/members/{member_guid}/status | Read member connection status
*MembersApi* | [**ResumeMember**](docs/MembersApi.md#resumemember) | **PUT** /users/{user_guid}/members/{member_guid}/resume | Resume aggregation from MFA
*MembersApi* | [**UpdateMember**](docs/MembersApi.md#updatemember) | **PUT** /users/{user_guid}/members/{member_guid} | Update member
*MerchantsApi* | [**ReadMerchant**](docs/MerchantsApi.md#readmerchant) | **GET** /merchants/{merchant_guid} | Read merchant
*TransactionsApi* | [**CleanseAndCategorizeTransactions**](docs/TransactionsApi.md#cleanseandcategorizetransactions) | **POST** /cleanse_and_categorize | Categorize transactions
*TransactionsApi* | [**ListUserTransactions**](docs/TransactionsApi.md#listusertransactions) | **GET** /users/{user_guid}/transactions | List transactions for a user
*TransactionsApi* | [**ReadTransaction**](docs/TransactionsApi.md#readtransaction) | **GET** /users/{user_guid}/transactions/{transaction_guid} | Read a transaction
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /users | Create user
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{user_guid} | Delete user
*UsersApi* | [**ListUsers**](docs/UsersApi.md#listusers) | **GET** /users | List users
*UsersApi* | [**ReadUser**](docs/UsersApi.md#readuser) | **GET** /users/{user_guid} | Read user
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /users/{user_guid} | Update user
*VerificationApi* | [**ListAccountNumbers**](docs/VerificationApi.md#listaccountnumbers) | **GET** /users/{user_guid}/members/{member_guid}/account_numbers | Read account numbers
*VerificationApi* | [**ListAccountNumbersByAccount**](docs/VerificationApi.md#listaccountnumbersbyaccount) | **GET** /users/{user_guid}/accounts/{account_guid}/account_numbers | Read account numbers by account GUID
*VerificationApi* | [**VerifyMember**](docs/VerificationApi.md#verifymember) | **POST** /users/{user_guid}/members/{member_guid}/verify | Verify


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AccountNumber](docs/AccountNumber.md)
 - [Model.AccountNumbersResponseBody](docs/AccountNumbersResponseBody.md)
 - [Model.AccountOwner](docs/AccountOwner.md)
 - [Model.AccountOwnersResponseBody](docs/AccountOwnersResponseBody.md)
 - [Model.AccountResponseBody](docs/AccountResponseBody.md)
 - [Model.AccountsResponseBody](docs/AccountsResponseBody.md)
 - [Model.Challenge](docs/Challenge.md)
 - [Model.ChallengeOption](docs/ChallengeOption.md)
 - [Model.ChallengesResponseBody](docs/ChallengesResponseBody.md)
 - [Model.ConnectWidget](docs/ConnectWidget.md)
 - [Model.ConnectWidgetRequestBody](docs/ConnectWidgetRequestBody.md)
 - [Model.ConnectWidgetResponseBody](docs/ConnectWidgetResponseBody.md)
 - [Model.CredentialOption](docs/CredentialOption.md)
 - [Model.CredentialRequest](docs/CredentialRequest.md)
 - [Model.CredentialResponse](docs/CredentialResponse.md)
 - [Model.CredentialsResponseBody](docs/CredentialsResponseBody.md)
 - [Model.Holding](docs/Holding.md)
 - [Model.HoldingResponseBody](docs/HoldingResponseBody.md)
 - [Model.HoldingsResponseBody](docs/HoldingsResponseBody.md)
 - [Model.Institution](docs/Institution.md)
 - [Model.InstitutionResponseBody](docs/InstitutionResponseBody.md)
 - [Model.InstitutionsResponseBody](docs/InstitutionsResponseBody.md)
 - [Model.Member](docs/Member.md)
 - [Model.MemberConnectionStatus](docs/MemberConnectionStatus.md)
 - [Model.MemberConnectionStatusResponseBody](docs/MemberConnectionStatusResponseBody.md)
 - [Model.MemberCreateRequest](docs/MemberCreateRequest.md)
 - [Model.MemberCreateRequestBody](docs/MemberCreateRequestBody.md)
 - [Model.MemberResponseBody](docs/MemberResponseBody.md)
 - [Model.MemberResumeRequest](docs/MemberResumeRequest.md)
 - [Model.MemberResumeRequestBody](docs/MemberResumeRequestBody.md)
 - [Model.MemberUpdateRequest](docs/MemberUpdateRequest.md)
 - [Model.MemberUpdateRequestBody](docs/MemberUpdateRequestBody.md)
 - [Model.MembersResponseBody](docs/MembersResponseBody.md)
 - [Model.Merchant](docs/Merchant.md)
 - [Model.MerchantResponseBody](docs/MerchantResponseBody.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionCleanseAndCategorizeRequest](docs/TransactionCleanseAndCategorizeRequest.md)
 - [Model.TransactionCleanseAndCategorizeResponse](docs/TransactionCleanseAndCategorizeResponse.md)
 - [Model.TransactionResponseBody](docs/TransactionResponseBody.md)
 - [Model.TransactionsCleanseAndCategorizeRequestBody](docs/TransactionsCleanseAndCategorizeRequestBody.md)
 - [Model.TransactionsCleanseAndCategorizeResponseBody](docs/TransactionsCleanseAndCategorizeResponseBody.md)
 - [Model.TransactionsResponseBody](docs/TransactionsResponseBody.md)
 - [Model.User](docs/User.md)
 - [Model.UserCreateRequestBody](docs/UserCreateRequestBody.md)
 - [Model.UserResponseBody](docs/UserResponseBody.md)
 - [Model.UserUpdateRequestBody](docs/UserUpdateRequestBody.md)
 - [Model.UsersResponseBody](docs/UsersResponseBody.md)

