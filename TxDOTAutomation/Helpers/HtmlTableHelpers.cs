using OpenQA.Selenium;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TxDOTAutomation.Helpers
{
    public class HtmlTableHelpers
    {
        private static List<TableDatacollection> _tableDatacollections;


        /// <summary>
        /// Custom class to read the HTML Table 
        /// </summary>
        /// <param name="table"></param>
        public static void ReadTable(IWebElement table)
        {
            //Initialize the table
            _tableDatacollections = new List<TableDatacollection>();

            //Get all the columns from the table
            var columns = table.FindElements(By.TagName("th"));

            //Get all the rows
            var rows = table.FindElements(By.TagName("tr"));

            //Create row index
            int rowIndex = 0;
            foreach (var row in rows)
            {
                int colIndex = 0;

                var colDatas = row.FindElements(By.TagName("td"));
                //Store data only if it has value in row
                if (colDatas.Count != 0)
                    foreach (var colValue in colDatas)
                    {
                        _tableDatacollections.Add(new TableDatacollection
                        {
                            RowNumber = rowIndex,
                            ColumnName = columns[colIndex].Text != "" ?
                                         columns[colIndex].Text : colIndex.ToString(),
                            ColumnValue = colValue.Text,
                            ColumnSpecialValues = GetControl(colValue)
                        });

                        //Move to next column
                        colIndex++;
                    }
                rowIndex++;
            }
        }

        /// <summary>
        /// Custom class to indentify if the table as special values like Hyperlink and  input
        /// </summary>
        /// <param name="columnValue"></param>
        /// <returns></returns>
        private static ColumnSpecialValue GetControl(IWebElement columnValue)
        {
            ColumnSpecialValue columnSpecialValue = null;
            //Check if the control has specfic tags like input/hyperlink etc
            if (columnValue.FindElements(By.TagName("a")).Count > 0)
            {
                columnSpecialValue = new ColumnSpecialValue
                {
                    ElementCollection = columnValue.FindElements(By.TagName("a")),
                    ControlType = "hyperLink"
                };
            }
            if (columnValue.FindElements(By.TagName("input")).Count > 0)
            {
                columnSpecialValue = new ColumnSpecialValue
                {
                    ElementCollection = columnValue.FindElements(By.TagName("input")),
                    ControlType = "input"
                };
            }

            return columnSpecialValue;
        }


        /// <summary>
        /// Custom class to perform actions on the choosen cell.
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <param name="refColumnName"></param>
        /// <param name="refColumnValue"></param>
        /// <param name="controlToOperate"></param>
        public static void PerformActionOnCell(string columnIndex, string refColumnName, string refColumnValue, string controlToOperate = null)
        {
            foreach (int rowNumber in GetDynamicRowNumber(refColumnName, refColumnValue))
            {
                var cell = (from e in _tableDatacollections
                            where e.ColumnName == columnIndex && e.RowNumber == rowNumber
                            select e.ColumnSpecialValues).SingleOrDefault();

                //Need to operate on those controls
                if (controlToOperate != null && cell != null)
                {
                    //Since based on the control type, the retriving of text changes
                    //created this kind of control
                    if (cell.ControlType == "hyperLink")
                    {
                        var returnedControl = (from c in cell.ElementCollection
                                               where c.Text == controlToOperate
                                               select c).SingleOrDefault();

                        //ToDo: Currenly only click is supported, future is not taken care here
                        returnedControl?.Click();
                    }
                    if (cell.ControlType == "input")
                    {
                        var returnedControl = (from c in cell.ElementCollection
                                               where c.GetAttribute("value") == controlToOperate
                                               select c).SingleOrDefault();

                        //ToDo: Currenly only click is supported, future is not taken care here
                        returnedControl?.Click();
                    }

                }
                else
                {
                    cell.ElementCollection?.First().Click();
                }
            }
        }

        /// <summary>
        /// Custome class to store al the columnName and the columnvalue 
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="columnValue"></param>
        /// <returns></returns>
        private static IEnumerable GetDynamicRowNumber(string columnName, string columnValue)
        {
            //dynamic row
            foreach (var table in _tableDatacollections)
            {
                if (table.ColumnName == columnName && table.ColumnValue == columnValue)
                    yield return table.RowNumber;
            }
        }


    }

    /// <summary>
    /// Custom class to store all the values like rowNumber, columnName, columnValue and ColumnSpecialValue
    /// </summary>
    public class TableDatacollection
    {
        public int RowNumber { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }
        public ColumnSpecialValue ColumnSpecialValues { get; set; }
    }


    /// <summary>
    /// Custom class to store enum constants of type WebElement and ControlType
    /// </summary>
    public class ColumnSpecialValue
    {
        public IEnumerable<IWebElement> ElementCollection { get; set; }
        public string ControlType { get; set; }
    }

}
