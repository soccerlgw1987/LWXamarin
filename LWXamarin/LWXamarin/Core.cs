using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace LWXamarin
{
    class Core
    {
        public static async Task<List<Household>> GetHouseholds()
        {
            string queryString = "http://lwapi.azurewebsites.net:80/Api/GetHouseholds";

            try
            {
                dynamic results = await DataService.getHouseholdsFromService(queryString).ConfigureAwait(false);

                if(results != null)
                {
                    return JsonConvert.DeserializeObject<List<Household>>(results.ToString());
                }
            }
            catch(Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }

            return null;
        }

        public static async Task<List<Account>> GetAccounts()
        {
            string queryString = "http://lwapi.azurewebsites.net:80/Api/GetAccounts";

            try
            {
                dynamic results = await DataService.getAccountsFromService(queryString).ConfigureAwait(false);

                if (results != null)
                {
                    var data = JsonConvert.DeserializeObject<List<Account>>(results.ToString());
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }

            return null;
        }

        public static async Task<Account> GetAccountDetails(string accountIdEntry)
        {
            string queryString = "http://lwapi.azurewebsites.net:80/Api/GetAccountDetails?id=" + accountIdEntry;

            try
            {
                dynamic results = await DataService.getAccountDetailsFromService(queryString).ConfigureAwait(false);

                if (results != null)
                {
                    var data = JsonConvert.DeserializeObject<Account>(results.ToString());
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }

            return null;
        }

        public static async Task<List<Transaction>> GetTransactions()
        {
            string queryString = "http://lwapi.azurewebsites.net:80/Api/GetTransactions";

            try
            {
                dynamic results = await DataService.getTransactionsFromService(queryString).ConfigureAwait(false);

                if (results != null)
                {
                    var data = JsonConvert.DeserializeObject<List<Transaction>>(results.ToString());
                    return data;
                }
            }
            catch (Exception ex)
            {
                Log.Warning("Exception", ex.Message);
            }

            return null;
        }
    }
}
