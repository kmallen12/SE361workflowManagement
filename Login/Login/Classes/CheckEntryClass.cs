using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowManagement
{
    class CheckEntry
    {
        public string text { get; set; }
        public string label { get; set; }

        public CheckEntry()
        {
            text = "";
            label = "";
        }

        public CheckEntry(string txt, string lbl)
        {
            text = txt;
            label = lbl;
        }

        // Checks to see if a string can be converted to a double & returns an error if it can't
        public Boolean isValidNumber()
        {
            try
            {
                double txt = double.Parse(text);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(label + " must be a numeric value.");
                return false;
            }
        }

        public Boolean isValidNumber(string t, string l)
        {
            try
            {
                double testNo = double.Parse(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean isValidInt(string t, string lbl)
        {
            try
            {
                int txt = Int32.Parse(t);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(lbl + " must be a Integer value.");
                return false;
            }
        }

        //returns true if string variable is null
        public Boolean isNull()
        {
            if (text == "")
            {
                System.Windows.Forms.MessageBox.Show(label + " must not be null.");
                return true;
            }
            return false;
        }

        //returns true if string variable is null
        public Boolean isNull(string t, string lbl)
        {
            if (t == "")
            {
                return true;
            }
            return false;
        }

        public Boolean isnotNull(string t, string lbl)
        {
            if (t != "")
                return true;
            else
            {
                System.Windows.Forms.MessageBox.Show(lbl + " must not be null.");
                return false;
            }
        }

        //checks to see if a string is a valid email address
        public Boolean isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please Use a Valid Email!");
                return false;
            }
        }

        public Boolean isValidDate(string dateEntered)
        {
            try
            {
                DateTime date = DateTime.Parse(dateEntered);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean checkValidStockEntry(string materialText, string materialLabel, string quantityText, string quantityLabel, string uCostText, string uCostLabel,
            string tCostText, string tCostLabel, string defectsText, string defectsLabel, string dateAcqText, string dateAcqLabel, string dateUsedText, string dateUsedLabel, Stock objStock)
        {
            bool validStock = true;
            string warningNull = "";
            string warningNumberFormat = "";
            string warningDateFormat = "";

            //Check to see if material is null. If null, prompt user to enter a value.
            //Else add text input to material variable.
            if (isNull(materialText, materialLabel))
            {
                warningNull += "\n" + materialLabel;
                validStock = false;
            }
            else
            {
                objStock.materialType = materialText;
            }

            //Check to see if quantity is null. If null, prompt user to enter a value.
            //Else add text input to quantity variable.
            if (isNull(quantityText, quantityLabel))
            {
                warningNull += "\n" + quantityLabel;
                validStock = false;
            }
            else if (!isValidNumber(quantityText, quantityLabel))
            {
                warningNumberFormat += "\n" + quantityLabel;
                validStock = false;
            }
            else
            {
                objStock.quantity = double.Parse(quantityText);
            }

            //If unit cost contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to unit cost variable.
            if (!isNull(uCostText, uCostLabel) && !isValidNumber(uCostText, uCostLabel))
            {
                warningNumberFormat += "\n" + uCostLabel;
                validStock = false;
            }
            else if (!isNull(uCostText, uCostLabel))
            {
                objStock.unitCost = double.Parse(uCostText);
            }

            //If defects contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to defects variable.
            if (!isNull(defectsText, defectsLabel) && !isValidNumber(defectsText, defectsLabel))
            {
                warningNumberFormat += "\n" + defectsLabel;
                validStock = false;
            }
            else if (!isNull(defectsText, defectsLabel))
            {
                objStock.defects = double.Parse(defectsText);
            }

            //If total cost contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to total cost variable.
            if (!isNull(tCostText, tCostLabel) && !isValidNumber(tCostText, tCostLabel))
            {
                warningNumberFormat += "\n" + tCostLabel;
                validStock = false;
            }
            //else if (!isNull(tCostText, tCostLabel))
            //{
            //    totalCost = double.Parse(tCostText);
            //}

            //If date acquired contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to dateAcq variable.
            //If no date is entered, set dateAcq to MinValue
            if (!isNull(dateAcqText, dateAcqLabel))
            {
                if (!isValidDate(dateAcqText))
                {
                    warningDateFormat += "\n" + dateAcqLabel;
                    validStock = false;
                }
                else
                {
                    objStock.dateAcquired = DateTime.Parse(dateAcqText);
                }
            }
            else
            {
                objStock.dateAcquired = DateTime.MinValue;
            }

            //If date acquired contains a value that is not formatted correctly, prompt user to enter a different value.
            //Else add text input to dateAcq variable.
            //If no date is entered, set dateAcq to MinValue
            if (!isNull(dateUsedText, dateUsedLabel))
            {
                if (!isValidDate(dateUsedText))
                {
                    warningDateFormat += "\n" + dateUsedLabel;
                    validStock = false;
                }
                else
                {
                    objStock.dateUsed = DateTime.Parse(dateUsedText);
                }
            }
            else
            {
                objStock.dateUsed = DateTime.MinValue;
            }


            //Give feedback to user
            if (warningNull != "")
            {
                if (warningNumberFormat != "" && warningDateFormat != "")
                {
                    System.Windows.Forms.MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter an integer value in: " + warningNumberFormat
                        + "\n \nEnter a valid date in: " + warningDateFormat);
                }
                else if (warningNumberFormat != "" && warningDateFormat == "")
                {
                    System.Windows.Forms.MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter an integer value in: " + warningNumberFormat);
                }
                else if (warningNumberFormat == "" && warningDateFormat != "")
                {
                    System.Windows.Forms.MessageBox.Show("Add a value for: " + warningNull + "\n \nEnter a valid date in: " + warningDateFormat);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Add a value for: " + warningNull);
                }
            }
            else if (warningNumberFormat != "")
            {
                if (warningDateFormat == "")
                {
                    System.Windows.Forms.MessageBox.Show("Enter an integer value in: " + warningNumberFormat);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Enter an integer value in: " + warningNumberFormat + "\n \nEnter a valid date in: " + warningDateFormat);
                }
            }
            else if (warningDateFormat != "")
            {
                System.Windows.Forms.MessageBox.Show("Enter a valid date in: " + warningDateFormat);
            }

            warningNull = "";
            warningNumberFormat = "";
            warningDateFormat = "";

            return validStock;
        }
    }
}
