﻿string txtMonthlyInvestment = "500.00";
string txtInterestRate = "4.75";
string txtYears = "20.0"; // This will triger the FormatException


try
{
    decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment); 
    decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate); 
{
{