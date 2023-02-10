using FormApp1.Common;
using FormApp1.Exceptions;
using FormApp1.Model;
using System;

namespace FormApp1.Controller
{
    internal class ValidationController
    {
        public ValidationController() { }

        // Validates the dividend object
        public void ValidateDividend(Dividend dividend,
            Constants.ValidationType validationType = Constants.ValidationType.CREATE)
        {
            if (string.IsNullOrWhiteSpace(dividend.symbolCode))
            {
                throw new ValidationFailedException("Security is required");
            }
            else if (string.IsNullOrEmpty(dividend.paymentDate))
            {
                throw new ValidationFailedException("Dividend Payment Date is required");
            }

            if (validationType.Equals(Constants.ValidationType.UPDATE))
            {
                if (string.IsNullOrWhiteSpace(dividend.symbolCode))
                {
                    throw new ValidationFailedException("Dividend Id is required");
                }
            }
        }

        public void ValidateSearch(string from, string to)
        {
            DateTime fromDate;
            DateTime toDate;

            DateTime.TryParse(from, out fromDate);
            DateTime.TryParse(to, out toDate);

            int result = DateTime.Compare(fromDate, toDate);

            if (result > 0) // start date is greater than end date
            {
                throw new ValidationFailedException("Start Date must be less than or equal to the End Date");
            }
        }
    }
}
