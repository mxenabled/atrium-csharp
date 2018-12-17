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
    public IdentityApi identity;
    public InstitutionsApi institutions;
    public MembersApi members;
    public TransactionsApi transactions;
    public UsersApi users;
    public VerificationApi verification;

    public AtriumClient(string apiKey, string clientID) {
      Configuration.Default.AddApiKey("MX-API-Key", apiKey);
      Configuration.Default.AddApiKey("MX-Client-ID", clientID);
      
      this.accounts = new AccountsApi();
      this.connectWidget = new ConnectWidgetApi();
      this.identity = new IdentityApi();
      this.institutions = new InstitutionsApi();
      this.members = new MembersApi();
      this.transactions = new TransactionsApi();
      this.users = new UsersApi();
      this.verification = new VerificationApi();
    }
  }
}
