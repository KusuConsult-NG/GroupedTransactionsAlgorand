using Algorand.Algod.Api;
using Algorand.Algod.Model;
using Algorand.Client;
using Algorand;
using Account = Algorand.Account;
using System;
using System.Collections.Generic;

namespace GroupedTxAlgorandConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgodApi algodApiInstance = new AlgodApi("https://testnet-algorand.api.purestake.io/ps1", "B3SU4KcVKi94Jap2VXkK83xx38bsv95K5UZm2lab");
            TransactionParams transparams = null;
            try
            {
                transparams = algodApiInstance.TransactionParams();
            }
            catch(ApiException err)
            {
                throw new Exception("Could not get params", err);
            }
            //4CLRLFJQK3WKEIHKOYTFJ5TT7W2KKQJQUXVJM4GZYLOHG5FC3C3PNF5XMQ
            var acc1 = "4CLRLFJQK3WKEIHKOYTFJ5TT7W2KKQJQUXVJM4GZYLOHG5FC3C3PNF5XMQ";
            var acc2 = "AE47UNNWHF2XCVFF4DAB7WPHKKNL5MFEW2YQ6DTK3HYNGO4GCG32WQAA5I";
            //AE47UNNWHF2XCVFF4DAB7WPHKKNL5MFEW2YQ6DTK3HYNGO4GCG32WQAA5I
            var Key = "brain under subject brown letter select auto artwork inject display reflect clerk index prosper trick host true stable fork tone drum please loud abstract reject";
            Account account = new Account();
            Console.WriteLine(account.Address.ToString());
            //Console.WriteLine($"{account.Address.ToString()} and {account.ToMnemonic()}");
            //brain under subject brown letter select auto artwork inject display reflect clerk index prosper trick host true stable fork tone drum please loud abstract reject
            //LLMTMNBRXUF5ARJZLYYJEJPVOGDJ2SBYOHQDWXHOPIODS6ANXBL4S6BECE
            //var accountAddress = "LLMTMNBRXUF5ARJZLYYJEJPVOGDJ2SBYOHQDWXHOPIODS6ANXBL4S6BECE";
       
            //var accountInfo = algodApiInstance.AccountInformation("LLMTMNBRXUF5ARJZLYYJEJPVOGDJ2SBYOHQDWXHOPIODS6ANXBL4S6BECE");
      
            //Console.WriteLine($"The address {accountAddress} has a Balance of: {accountInfo.Amount} microAlgos");
            ////Let's create a grouped transaction
            //var amount = Utils.AlgosToMicroalgos(1);
     
            //var tx1 = Utils.GetPaymentTransaction(new Address(accountAddress), new Address(acc1), amount, "Perfoming First Grouped Transactions", transparams);
      
            //var tx2 = Utils.GetPaymentTransaction(new Address(accountAddress), new Address(acc2), amount, "Perfoming Second Grouped Transactions", transparams);
      
            //Digest gid = TxGroup.ComputeGroupID(new Algorand.Transaction[] { tx1, tx2 });
      
            //tx1.AssignGroupID(gid);
            //tx2.AssignGroupID(gid);
            //var signedTx1 = account.SignTransaction(tx1);
      
            //var signedTx2 = account.SignTransaction(tx2);
            //try
            //{
            //    List<byte> byteList = new List<byte>(Algorand.Encoder.EncodeToMsgPack(signedTx1));
     
            //    byteList.AddRange(Algorand.Encoder.EncodeToMsgPack(signedTx2));
            //    var acc = algodApiInstance.AccountInformation(accountAddress);
        
            //    var before = $"Account 1 Balance before: {acc.Amount.ToString()}";
       
            //    var id = algodApiInstance.RawTransaction(byteList.ToArray());
        
            //    var wait = Utils.WaitTransactionToComplete(algodApiInstance, id.TxId);
     
            //    Console.WriteLine(wait);
            //    Console.WriteLine($"Transfer sent to Tx group with id: {id}");
            //    acc = algodApiInstance.AccountInformation(accountAddress.ToString());
            //}
            //catch(ApiException err)
            //{
            //    Console.WriteLine($"Exception when calling algodrawtransactions: {err.Message}");
            //}
        }
    }
}
