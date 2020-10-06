﻿namespace MortgageCalculator
{
    public class BusinessLoan: Loan
    {
        private const double _yearlyInterestRate = 0.05;

        public BusinessLoan(double principal, int years)
            : base(principal, _yearlyInterestRate, years)
        {
        }

        public BusinessLoan()
            : base(_yearlyInterestRate)
        {
        }
    }
}