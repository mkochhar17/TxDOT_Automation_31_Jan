using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;

namespace TxDOTTest.Pages.LibraryPages
{
    public class DepartmentInitiativeListPage : BasePage
    {
        public DepartmentInitiative ClickDepartmentInitiativeNew()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickNew();
            return GetInstance<DepartmentInitiative>();
            //return new DistrictNew();
        }

        public void ClickFirstCheckBox()
        {
            GetInstance<SelectRecord>().As<SelectRecord>().ClickCheckFirst();


        }

        public DepartmentInitiative ClickDepartmentInitiativeEdit()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickEdit();
            return GetInstance<DepartmentInitiative>();

        }

        public void ClickExcelImportExportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImportExport();
            //return GetInstance<DistrictListPage>();
            //return new DistrictNew();
        }

        public ExcelImportDetails ClickExcelImportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImport();
            return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }

        public void ClickDepartmentInitiativeDelete()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickDelete();
            return;

        }

        public void ClickExcelExport(ExportType exportType)
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelExportButtons(exportType);
            //return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }

        public DepartmentInitiativeListPage ClickExcelImportBack()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickBack();
            return GetInstance<DepartmentInitiativeListPage>();
            //return new DistrictNew();
        }
    }
}
