namespace ColinasFoods.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ColinasProductsModel : DbContext
    {
        public ColinasProductsModel()
            : base("name=ColinasProductsModelConnection")
        {
        }

        public virtual DbSet<Tbl_Ac_Accounts> Tbl_Ac_Accounts { get; set; }
        public virtual DbSet<Tbl_Ac_Accounts_Balance> Tbl_Ac_Accounts_Balance { get; set; }
        public virtual DbSet<Tbl_Ac_Accounts_Groups> Tbl_Ac_Accounts_Groups { get; set; }
        public virtual DbSet<Tbl_Ac_AP> Tbl_Ac_AP { get; set; }
        public virtual DbSet<Tbl_Ac_AP_Doc> Tbl_Ac_AP_Doc { get; set; }
        public virtual DbSet<Tbl_Ac_AP_Doc_Movs> Tbl_Ac_AP_Doc_Movs { get; set; }
        public virtual DbSet<Tbl_Ac_Banks> Tbl_Ac_Banks { get; set; }
        public virtual DbSet<Tbl_Ac_Invoice> Tbl_Ac_Invoice { get; set; }
        public virtual DbSet<Tbl_Ac_Invoice_Details> Tbl_Ac_Invoice_Details { get; set; }
        public virtual DbSet<Tbl_Ac_Journal> Tbl_Ac_Journal { get; set; }
        public virtual DbSet<Tbl_Ac_Journal_AP> Tbl_Ac_Journal_AP { get; set; }
        public virtual DbSet<Tbl_Ac_Journal_AR> Tbl_Ac_Journal_AR { get; set; }
        public virtual DbSet<Tbl_Ac_Journal_Details> Tbl_Ac_Journal_Details { get; set; }
        public virtual DbSet<Tbl_Ac_PaymentMethods> Tbl_Ac_PaymentMethods { get; set; }
        public virtual DbSet<Tbl_Ac_PaymentsApplications> Tbl_Ac_PaymentsApplications { get; set; }
        public virtual DbSet<Tbl_Ac_PaymentsApplications_Details> Tbl_Ac_PaymentsApplications_Details { get; set; }
        public virtual DbSet<Tbl_HR_Departaments> Tbl_HR_Departaments { get; set; }
        public virtual DbSet<Tbl_HR_Personnel> Tbl_HR_Personnel { get; set; }
        public virtual DbSet<Tbl_HR_Titles> Tbl_HR_Titles { get; set; }
        public virtual DbSet<Tbl_Mgmt_CustomerAnalysis> Tbl_Mgmt_CustomerAnalysis { get; set; }
        public virtual DbSet<Tbl_PR_Labels> Tbl_PR_Labels { get; set; }
        public virtual DbSet<Tbl_PR_WorkOrders> Tbl_PR_WorkOrders { get; set; }
        public virtual DbSet<Tbl_PR_WorkOrders_Inputs> Tbl_PR_WorkOrders_Inputs { get; set; }
        public virtual DbSet<Tbl_PR_WorkOrders_Outputs> Tbl_PR_WorkOrders_Outputs { get; set; }
        public virtual DbSet<Tbl_PR_WorkOrders_Workers> Tbl_PR_WorkOrders_Workers { get; set; }
        public virtual DbSet<Tbl_Proc_PO> Tbl_Proc_PO { get; set; }
        public virtual DbSet<Tbl_Proc_PO_Materials> Tbl_Proc_PO_Materials { get; set; }
        public virtual DbSet<Tbl_Proc_Vendors> Tbl_Proc_Vendors { get; set; }
        public virtual DbSet<Tbl_Proc_Vendors_Contacts> Tbl_Proc_Vendors_Contacts { get; set; }
        public virtual DbSet<Tbl_Sales_CRM> Tbl_Sales_CRM { get; set; }
        public virtual DbSet<Tbl_Sales_Customers> Tbl_Sales_Customers { get; set; }
        public virtual DbSet<Tbl_Sales_Customers_Contacts> Tbl_Sales_Customers_Contacts { get; set; }
        public virtual DbSet<Tbl_Sales_Customers_MaterialsNF> Tbl_Sales_Customers_MaterialsNF { get; set; }
        public virtual DbSet<Tbl_Sales_Customers_Notes> Tbl_Sales_Customers_Notes { get; set; }
        public virtual DbSet<Tbl_Sales_Customers_ShipTo> Tbl_Sales_Customers_ShipTo { get; set; }
        public virtual DbSet<Tbl_Sales_CustomerTypes> Tbl_Sales_CustomerTypes { get; set; }
        public virtual DbSet<Tbl_Sales_DeliveryTerms> Tbl_Sales_DeliveryTerms { get; set; }
        public virtual DbSet<Tbl_Sales_PaymentTerms> Tbl_Sales_PaymentTerms { get; set; }
        public virtual DbSet<Tbl_Sales_PriceLists> Tbl_Sales_PriceLists { get; set; }
        public virtual DbSet<Tbl_Sales_PriceLists_Materials> Tbl_Sales_PriceLists_Materials { get; set; }
        public virtual DbSet<Tbl_Sales_Salesman> Tbl_Sales_Salesman { get; set; }
        public virtual DbSet<Tbl_Sales_SalesOrder> Tbl_Sales_SalesOrder { get; set; }
        public virtual DbSet<Tbl_Sales_SalesOrder_Details> Tbl_Sales_SalesOrder_Details { get; set; }
        public virtual DbSet<Tbl_Sales_TaxOptions> Tbl_Sales_TaxOptions { get; set; }
        public virtual DbSet<Tbl_SH_Packing> Tbl_SH_Packing { get; set; }
        public virtual DbSet<Tbl_SH_Packing_Details> Tbl_SH_Packing_Details { get; set; }
        public virtual DbSet<Tbl_SH_Trucks> Tbl_SH_Trucks { get; set; }
        public virtual DbSet<Tbl_SIK_Branches> Tbl_SIK_Branches { get; set; }
        public virtual DbSet<Tbl_SIK_Company> Tbl_SIK_Company { get; set; }
        public virtual DbSet<Tbl_SIK_File> Tbl_SIK_File { get; set; }
        public virtual DbSet<Tbl_SIK_Menu> Tbl_SIK_Menu { get; set; }
        public virtual DbSet<Tbl_SIK_Profiles> Tbl_SIK_Profiles { get; set; }
        public virtual DbSet<Tbl_SIK_Profiles_Production> Tbl_SIK_Profiles_Production { get; set; }
        public virtual DbSet<Tbl_SIK_Profiles_Rights> Tbl_SIK_Profiles_Rights { get; set; }
        public virtual DbSet<Tbl_SIK_Users> Tbl_SIK_Users { get; set; }
        public virtual DbSet<Tbl_SIK_Users_SC> Tbl_SIK_Users_SC { get; set; }
        public virtual DbSet<Tbl_WH_Adjustemens> Tbl_WH_Adjustemens { get; set; }
        public virtual DbSet<Tbl_WH_Adjustemens_Details> Tbl_WH_Adjustemens_Details { get; set; }
        public virtual DbSet<Tbl_WH_Conversions> Tbl_WH_Conversions { get; set; }
        public virtual DbSet<Tbl_WH_Conversions_Materials> Tbl_WH_Conversions_Materials { get; set; }
        public virtual DbSet<Tbl_WH_Materials> Tbl_WH_Materials { get; set; }
        public virtual DbSet<Tbl_WH_Materials_BOM> Tbl_WH_Materials_BOM { get; set; }
        public virtual DbSet<Tbl_WH_Materials_Convertions> Tbl_WH_Materials_Convertions { get; set; }
        public virtual DbSet<Tbl_WH_Materials_Families> Tbl_WH_Materials_Families { get; set; }
        public virtual DbSet<Tbl_WH_Materials_Subs> Tbl_WH_Materials_Subs { get; set; }
        public virtual DbSet<Tbl_WH_Materials_UM> Tbl_WH_Materials_UM { get; set; }
        public virtual DbSet<Tbl_WH_Materials_Vendors> Tbl_WH_Materials_Vendors { get; set; }
        public virtual DbSet<Tbl_WH_Materials_WH> Tbl_WH_Materials_WH { get; set; }
        public virtual DbSet<Tbl_WH_Receptions> Tbl_WH_Receptions { get; set; }
        public virtual DbSet<Tbl_WH_Receptions_Barcodes> Tbl_WH_Receptions_Barcodes { get; set; }
        public virtual DbSet<Tbl_WH_Receptions_Materials> Tbl_WH_Receptions_Materials { get; set; }
        public virtual DbSet<Tbl_WH_Returns> Tbl_WH_Returns { get; set; }
        public virtual DbSet<Tbl_WH_Returns_Materials> Tbl_WH_Returns_Materials { get; set; }
        public virtual DbSet<Tbl_WH_Warehouses> Tbl_WH_Warehouses { get; set; }
        public virtual DbSet<Tbl_WH_Warehouses_Sections> Tbl_WH_Warehouses_Sections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_Ac_Accounts>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts>()
                .Property(e => e.AccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts>()
                .Property(e => e.DoA)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts_Balance>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts_Balance>()
                .Property(e => e.SaldoInicial)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Accounts_Balance>()
                .Property(e => e.TotalCargos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Accounts_Balance>()
                .Property(e => e.TotalAbonos)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Accounts_Balance>()
                .Property(e => e.SaldoFinal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Accounts_Groups>()
                .Property(e => e.DescGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts_Groups>()
                .Property(e => e.CuentaInicial)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts_Groups>()
                .Property(e => e.CuentaFinal)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Accounts_Groups>()
                .Property(e => e.TituloResumen)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_AP>()
                .Property(e => e.APNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_AP>()
                .Property(e => e.APTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APInvoice)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APCredits)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APMatch)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc>()
                .Property(e => e.APComments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_AP_Doc_Movs>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc_Movs>()
                .Property(e => e.TotalAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_AP_Doc_Movs>()
                .Property(e => e.APMComments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Banks>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Banks>()
                .Property(e => e.BankAcctNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerPO)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CustomerZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipTo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipToZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Taxes)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ChargeCC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Paid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Credits)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Charges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Balance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CancelledComments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.CCCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.ShipViaNote)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.TotalCC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .Property(e => e.DocumentType)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice>()
                .HasMany(e => e.Tbl_Ac_Invoice_Details)
                .WithRequired(e => e.Tbl_Ac_Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.RealCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Invoice_Details>()
                .Property(e => e.RealMargin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalType)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalConcept)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalTotalCharges)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalTotalCredits)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalDifference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalBeneficiary)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalCheckAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalCheckTotalWord)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalBanckAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalVendorAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalYearCloseAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal>()
                .Property(e => e.JournalYearCloseAccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal_AP>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal_AR>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal_Details>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal_Details>()
                .Property(e => e.AccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal_Details>()
                .Property(e => e.Concept)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_Journal_Details>()
                .Property(e => e.Charge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_Journal_Details>()
                .Property(e => e.Credit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_PaymentMethods>()
                .Property(e => e.PaymentMethodCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_PaymentMethods>()
                .Property(e => e.PaymentMethodDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_PaymentsApplications>()
                .Property(e => e.PaymentMethodDetails)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_PaymentsApplications>()
                .Property(e => e.PaymentNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Ac_PaymentsApplications>()
                .Property(e => e.PaymentTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Ac_PaymentsApplications_Details>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_HR_Departaments>()
                .Property(e => e.DepartmentDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.SSN)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.EmployeeZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Personnel>()
                .Property(e => e.DL)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_HR_Titles>()
                .Property(e => e.TitleDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Mgmt_CustomerAnalysis>()
                .Property(e => e.Bill)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Mgmt_CustomerAnalysis>()
                .Property(e => e.BillLY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Mgmt_CustomerAnalysis>()
                .Property(e => e.BillLM)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Mgmt_CustomerAnalysis>()
                .Property(e => e.BillToDate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Mgmt_CustomerAnalysis>()
                .Property(e => e.BillToDateLY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_PR_Labels>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_Labels>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_Labels>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_Labels>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders>()
                .Property(e => e.WODescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders>()
                .Property(e => e.WOLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Inputs>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Inputs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Inputs>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Inputs>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Outputs>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Outputs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Outputs>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_PR_WorkOrders_Outputs>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.VendorRef)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.AtnSalesman)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.Taxes)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO>()
                .Property(e => e.TotalAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.ExtendedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.CanceledComments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_PO_Materials>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.VendorZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors>()
                .Property(e => e.AccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Proc_Vendors_Contacts>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.TotalFacturado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.TotalCobrado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios3)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios4)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios5)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CRM>()
                .Property(e => e.Comentarios6)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.SalesRep)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.AccountNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.AccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.TaxItem)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.ResaleNum)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.Website)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.SalesTaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CreditAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CreditBO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.CreditStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.HomePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.WorkPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Contacts>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_MaterialsNF>()
                .Property(e => e.FlagNote)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_Notes>()
                .Property(e => e.NoteDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipTo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Customers_ShipTo>()
                .Property(e => e.ShipToZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_CustomerTypes>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_DeliveryTerms>()
                .Property(e => e.DeliveryTermsDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PaymentTerms>()
                .Property(e => e.PTDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PriceLists>()
                .Property(e => e.PriceListDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PriceLists_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PriceLists_Materials>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PriceLists_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_PriceLists_Materials>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_Salesman>()
                .Property(e => e.SalesmanInitials)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Salesman>()
                .Property(e => e.SalesmanName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_Salesman>()
                .Property(e => e.SalesmanOther)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerPO)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerContactName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerTaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CustomerZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipTo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToCounty)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToCountry)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipToZipcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ClosedNotes)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.CancelReason)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.ShipViaNote)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.TotalCC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.StatusSh)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.StatusBi)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder>()
                .Property(e => e.TotalBill)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.UnitPriceList)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.UnitDiscount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.RealCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_SalesOrder_Details>()
                .Property(e => e.RealMargin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_Sales_TaxOptions>()
                .Property(e => e.TaxDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing>()
                .Property(e => e.Truck)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing>()
                .Property(e => e.TruckPlates)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing_Details>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing_Details>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing_Details>()
                .Property(e => e.UofM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Packing_Details>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Trucks>()
                .Property(e => e.TruckPlates)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Trucks>()
                .Property(e => e.TruckDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SH_Trucks>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Branches>()
                .Property(e => e.BranchZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.TaxID)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyAddress1)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyAddress2)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyCity)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyState)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.CompanyZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Company>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_File>()
                .Property(e => e.ActualFile)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_File>()
                .Property(e => e.ProductionFile)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Menu>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Menu>()
                .Property(e => e.MenuScreenName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Menu>()
                .Property(e => e.SCName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Profiles>()
                .Property(e => e.ProfileDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Users>()
                .Property(e => e.BackgroundColor)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Users>()
                .HasOptional(e => e.Tbl_SIK_Users1)
                .WithRequired(e => e.Tbl_SIK_Users2);

            modelBuilder.Entity<Tbl_SIK_Users>()
                .HasOptional(e => e.Tbl_SIK_Users11)
                .WithRequired(e => e.Tbl_SIK_Users3);

            modelBuilder.Entity<Tbl_SIK_Users_SC>()
                .Property(e => e.MenuDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SIK_Users_SC>()
                .Property(e => e.MenuIcon)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens>()
                .Property(e => e.AdjDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.RealCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Adjustemens_Details>()
                .Property(e => e.TotalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Conversions>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Conversions_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Conversions_Materials>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Conversions_Materials>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Conversions_Materials>()
                .Property(e => e.ExtendedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Conversions_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.MaterialShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.SalesTaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.SalesAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.SalesAccountDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.COGSAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.COGSAccountDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.AssetAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.AssetAccountDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.PurchaseDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.UMVendor)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.LastCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.TotalCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.TaxAgency)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.MPN)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.EANBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.RealLastCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.ActualAvgCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.LabelDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials>()
                .Property(e => e.LabelContent)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_BOM>()
                .Property(e => e.ItemNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_BOM>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Families>()
                .Property(e => e.FamilyCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Families>()
                .Property(e => e.FamilyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Families>()
                .Property(e => e.FamilyGroup)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Subs>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Subs>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_UM>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_UM>()
                .Property(e => e.UMDescrption)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Materials_Vendors>()
                .Property(e => e.UPCCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.VendorDocument)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.OtherCostsDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.OtherCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.Truck)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.TruckPlates)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions>()
                .Property(e => e.TotalAP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Receptions_Barcodes>()
                .Property(e => e.Barcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions_Materials>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Receptions_Materials>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Receptions_Materials>()
                .Property(e => e.ExtendedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Receptions_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Returns>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns>()
                .Property(e => e.DriverName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns>()
                .Property(e => e.Truck)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns>()
                .Property(e => e.TruckPlates)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.PartNo)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.MaterialDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.ExtendedPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.UM)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Returns_Materials>()
                .Property(e => e.ERBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Warehouses>()
                .Property(e => e.WarehouseDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Warehouses_Sections>()
                .Property(e => e.SectionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_WH_Warehouses_Sections>()
                .Property(e => e.SectionDescription)
                .IsUnicode(false);
        }
    }
}
