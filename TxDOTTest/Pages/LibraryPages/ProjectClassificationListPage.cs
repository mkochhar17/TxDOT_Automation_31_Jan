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
    public class ProjectClassificationListPage : BasePage
    {
        public ProjectClassification ClickProjectClassificationNew()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickNew();
            return GetInstance<ProjectClassification>();
            //return new DistrictNew();
        }

        public void ClickFirstCheckBox()
        {
            GetInstance<SelectRecord>().As<SelectRecord>().ClickCheckFirst();

        }

        public ProjectClassification ClickProjectClassificationEdit()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickEdit();
            return GetInstance<ProjectClassification>();
        }

        public void ClickProjectClassificationDelete()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickDelete();
            return;

        }

        public void ClickExcelImportExportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImportExport();
            //return GetInstance<DistrictListPage>();
            //return new DistrictNew();
        }

        public void ClickExcelExport(ExportType exportType)
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelExportButtons(exportType);
            //return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }

        public ExcelImportDetails ClickExcelImportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImport();
            return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }

        public ProjectClassificationListPage ClickExcelImportBack()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickBack();
            return GetInstance<ProjectClassificationListPage>();
            //return new DistrictNew();
        }
    }
}
