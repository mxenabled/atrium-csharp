using System;
using System.Diagnostics;
using Atrium.Api;
using Atrium.Client;
using Atrium.Model;

namespace Atrium.Api
{
  public class AtriumClient{
    
    public AccountsApi accounts;
    public ConnectWidgetApi connectWidget;
    public HoldingsApi holdings;
    public IdentityApi identity;
    public InstitutionsApi institutions;
    public MembersApi members;
    public MerchantsApi merchants;
    public StatementsApi statements;
    public TransactionsApi transactions;
    public UsersApi users;
    public VerificationApi verification;

    public AtriumClient(string apiKey, string clientID, string basePath = "https://vestibule.mx.com") {
      
      this.accounts = new AccountsApi(apiKey, clientID, basePath);
      this.connectWidget = new ConnectWidgetApi(apiKey, clientID, basePath);
      this.holdings = new HoldingsApi(apiKey, clientID, basePath);
      this.identity = new IdentityApi(apiKey, clientID, basePath);
      this.institutions = new InstitutionsApi(apiKey, clientID, basePath);
      this.members = new MembersApi(apiKey, clientID, basePath);
      this.merchants = new MerchantsApi(apiKey, clientID, basePath);
      this.statements = new StatementsApi(apiKey, clientID, basePath);
      this.transactions = new TransactionsApi(apiKey, clientID, basePath);
      this.users = new UsersApi(apiKey, clientID, basePath);
      this.verification = new VerificationApi(apiKey, clientID, basePath);
    }
  }
}
