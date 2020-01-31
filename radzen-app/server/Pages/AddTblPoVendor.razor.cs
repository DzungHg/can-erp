using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;

namespace ErpCan.Pages
{
    public partial class AddTblPoVendorComponent
    {
        public void FillData(int? addressBookFK)
        {
            int currentAddFK = (int)addressBookFK;

            tblpovendor.Vendor_ID = getVwVendorsResult.Where(x => x.AddressBook_SEQ == addressBookFK).FirstOrDefault().AddressBook_ID;
            //SelectedVendorID = 
            tblpovendor.FirstName = getVwVendorsResult.Where(x => x.AddressBook_SEQ == addressBookFK).FirstOrDefault().FirstName;
            tblpovendor.LastName = getVwVendorsResult.Where(x => x.AddressBook_SEQ == addressBookFK).FirstOrDefault().LastName;
            tblpovendor.Inactive = false;
        }
    }
}
