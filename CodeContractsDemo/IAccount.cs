// -----------------------------------------------------------------------
// <copyright file="IAccount.cs" company="">
//
// </copyright>
// -----------------------------------------------------------------------
namespace CodeContractsDemo
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;

    public interface IAccount
    {
        decimal Balance { get; set; }
        string Name { get; set; }

        void Transfer(Account transferFromAccount, Account transferToAccount);
    }
}