using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace TxDOTAutomation.Helpers
{
    public class ExcelHelpers
    {
        //private static IExcelDataReader excelReader;
        private static List<DataCollection> dataCol = new List<DataCollection>();

        /// <summary>
        /// read all the data from ExcelToDataTable Method
        /// </summary>
        /// <param name="fileName"></param>
        public static void PopulateInCollection(string fileName, string sheet)
        {
            DataTable table = ExcelToDataTable(fileName, sheet);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for(int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        /// <summary>
        /// Reading all the datas from excel sheet
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static DataTable ExcelToDataTable(string fileName, string sheet)
        {
            using(var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        //setting the first row as column name
                        ConfigureDataTable = (data) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //Get all the tables
                    DataTableCollection table = result.Tables;
                    //Store it in DataTable
                    DataTable resultTable = table[sheet];
                    return resultTable;
                }
            }
        }

        /// <summary>
        /// Method to read data from collections. 
        /// </summary>
        /// <param name="rowNumber"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of Iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var data = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }

            catch (Exception e)
            {
                return null;
            }
        }
   }

    /// <summary>
    /// Custom class to store all the values like rowNumber, colName, colValue
    /// </summary>
    public class DataCollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }
}

