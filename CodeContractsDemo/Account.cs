// -----------------------------------------------------------------------
// <copyright file="Account.cs" company="">
//
// </copyright>
// -----------------------------------------------------------------------
namespace CodeContractsDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Account implementation
    /// </summary>
    public class Account : IAccount
    {
        public decimal Balance { get; set; }
        public string Name { get; set; }

        public void Transfer(Account transferFromAccount, Account transferToAccount)
        {
            Contract.Assume(transferFromAccount != null, "transferFromAccount != null");
            Contract.Assume(transferToAccount != null, "transferToAccount != null");


        }
    }
}