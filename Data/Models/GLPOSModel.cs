namespace POS.APIs.Data.Models
{

    public partial class GLPOSModel 
    {
 
        //public virtual DbSet<Batch> Batches { get; set; }
        //public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<Category1> Category1 { get; set; }
        //public virtual DbSet<Category2> Category2 { get; set; }
        //public virtual DbSet<CC_Types> CC_Types { get; set; }
        //public virtual DbSet<Client> Clients { get; set; }
        //public virtual DbSet<Clients_Other> Clients_Other { get; set; }
        //public virtual DbSet<Clients_Phones> Clients_Phones { get; set; }
        //public virtual DbSet<Clients_Types> Clients_Types { get; set; }
        //public virtual DbSet<Company> Companies { get; set; }
        //public virtual DbSet<DeliveryOption> DeliveryOptions { get; set; }
        //public virtual DbSet<Discount> Discounts { get; set; }
        //public virtual DbSet<Discounts_Products> Discounts_Products { get; set; }
        //public virtual DbSet<Event> Events { get; set; }
        //public virtual DbSet<Events_Detail> Events_Detail { get; set; }
        //public virtual DbSet<GroupPermission> GroupPermissions { get; set; }
        //public virtual DbSet<Group> Groups { get; set; }
        //public virtual DbSet<InvAdjStatu> InvAdjStatus { get; set; }
        //public virtual DbSet<InvAdjType> InvAdjTypes { get; set; }
        //public virtual DbSet<Inventory> Inventories { get; set; }
        //public virtual DbSet<InventoryAdjustmentDetail> InventoryAdjustmentDetails { get; set; }
        //public virtual DbSet<InventoryAdjustment> InventoryAdjustments { get; set; }
        //public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }
        //public virtual DbSet<Invoice> Invoices { get; set; }
        //public virtual DbSet<InvoicesDetail> InvoicesDetails { get; set; }
        //public virtual DbSet<InvoicesDiscount> InvoicesDiscounts { get; set; }
        //public virtual DbSet<InvoiceStatu> InvoiceStatus { get; set; }
        //public virtual DbSet<InvoiceTerm> InvoiceTerms { get; set; }
        //public virtual DbSet<MemberQtlySel> MemberQtlySels { get; set; }
        //public virtual DbSet<MemberQtlySel_detail> MemberQtlySel_detail { get; set; }
        //public virtual DbSet<Payment_Types> Payment_Types { get; set; }
        //public virtual DbSet<PaymentRegister> PaymentRegisters { get; set; }
        //public virtual DbSet<Phone_Types> Phone_Types { get; set; }
        //public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        //public virtual DbSet<PRBatch> PRBatches { get; set; }
        //public virtual DbSet<PRBatchesDetail> PRBatchesDetails { get; set; }
        //public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        //public virtual DbSet<StateTax> StateTaxes { get; set; }
        //public virtual DbSet<Stock> Stocks { get; set; }
        //public virtual DbSet<SystemObject> SystemObjects { get; set; }
        //public virtual DbSet<Unit> Units { get; set; }
        //public virtual DbSet<UserMemberOf> UserMemberOfs { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<Widget> Widgets { get; set; }
        //public virtual DbSet<WidgetsPermission> WidgetsPermissions { get; set; }
        //public virtual DbSet<Client_Credits> Client_Credits { get; set; }
        //public virtual DbSet<UserPermission> UserPermissions { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Batch>()
        //        .Property(e => e.usr_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Batch>()
        //        .Property(e => e.batch_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Batch>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Batch>()
        //        .Property(e => e.cancelledby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Category>()
        //        .Property(e => e.cat_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Category>()
        //        .HasMany(e => e.Category1)
        //        .WithRequired(e => e.Category)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Category1>()
        //        .Property(e => e.cat1_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Category1>()
        //        .HasMany(e => e.Products)
        //        .WithRequired(e => e.Category1)
        //        .HasForeignKey(e => e.prod_category1)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Category2>()
        //        .Property(e => e.cat2_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Category2>()
        //        .HasMany(e => e.Products)
        //        .WithRequired(e => e.Category2)
        //        .HasForeignKey(e => e.prod_category2)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<CC_Types>()
        //        .Property(e => e.cct_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_lastname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_address)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_city)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_state)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_zip)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_website)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client>()
        //        .Property(e => e.cli_discount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Client>()
        //        .HasMany(e => e.Clients_Other)
        //        .WithRequired(e => e.Client)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Client>()
        //        .HasMany(e => e.Clients_Phones)
        //        .WithRequired(e => e.Client)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Client>()
        //        .HasMany(e => e.Invoices)
        //        .WithRequired(e => e.Client)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Client>()
        //        .HasMany(e => e.PaymentRegisters)
        //        .WithRequired(e => e.Client)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Client>()
        //        .HasMany(e => e.PRBatchesDetails)
        //        .WithRequired(e => e.Client)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_ccsec)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_firstname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_lastname)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_address)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_address2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_city)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_st)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Other>()
        //        .Property(e => e.cli_zipcode)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Phones>()
        //        .Property(e => e.ph_number)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Types>()
        //        .Property(e => e.clit_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Clients_Types>()
        //        .HasMany(e => e.Clients)
        //        .WithRequired(e => e.Clients_Types)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Company>()
        //        .Property(e => e.company_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Company>()
        //        .Property(e => e.sales_tax)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<DeliveryOption>()
        //        .Property(e => e.del_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Discount>()
        //        .Property(e => e.disc_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Discount>()
        //        .Property(e => e.disc_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Discount>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Discount>()
        //        .HasMany(e => e.Discounts_Products)
        //        .WithRequired(e => e.Discount)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Event>()
        //        .Property(e => e.evt_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Event>()
        //        .Property(e => e.evt_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Event>()
        //        .Property(e => e.evt_cost)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Event>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Event>()
        //        .Property(e => e.updatedby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Events_Detail>()
        //        .Property(e => e.evtd_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<GroupPermission>()
        //        .Property(e => e.grp_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Group>()
        //        .Property(e => e.grp_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Group>()
        //        .HasMany(e => e.GroupPermissions)
        //        .WithRequired(e => e.Group)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Group>()
        //        .HasMany(e => e.UserMemberOfs)
        //        .WithRequired(e => e.Group)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Group>()
        //        .HasMany(e => e.WidgetsPermissions)
        //        .WithRequired(e => e.Group)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<InvAdjStatu>()
        //        .Property(e => e.invadjstat_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvAdjStatu>()
        //        .HasMany(e => e.InventoryAdjustments)
        //        .WithRequired(e => e.InvAdjStatu)
        //        .HasForeignKey(e => e.invadj_status)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<InvAdjType>()
        //        .Property(e => e.invadjtyp_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvAdjType>()
        //        .HasMany(e => e.InventoryAdjustments)
        //        .WithRequired(e => e.InvAdjType)
        //        .HasForeignKey(e => e.invadj_type)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Inventory>()
        //        .Property(e => e.inv_quantity)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<InventoryAdjustmentDetail>()
        //        .Property(e => e.inv_quantity)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<InventoryAdjustmentDetail>()
        //        .Property(e => e.invadj_quantity)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<InventoryAdjustment>()
        //        .Property(e => e.invadj_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InventoryAdjustment>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InventoryAdjustment>()
        //        .HasMany(e => e.InventoryAdjustmentDetails)
        //        .WithRequired(e => e.InventoryAdjustment)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<InvoicePayment>()
        //        .Property(e => e.pay_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoicePayment>()
        //        .Property(e => e.pay_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvoicePayment>()
        //        .Property(e => e.pay_balance)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoicePayment>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_tax)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_discount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_taxpercent)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_total)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_subtotal)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_closedby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_cancelledby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_reopenedby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_shipping)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Invoice>()
        //        .Property(e => e.inv_deliveredby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvoicesDetail>()
        //        .Property(e => e.invd_quantity)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<InvoicesDetail>()
        //        .Property(e => e.invd_price)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoicesDetail>()
        //        .Property(e => e.invd_total)
        //        .HasPrecision(31, 6);

        //    modelBuilder.Entity<InvoicesDetail>()
        //        .Property(e => e.prod_discamt)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoicesDetail>()
        //        .Property(e => e.invd_tax)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoicesDiscount>()
        //        .Property(e => e.disc_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<InvoiceStatu>()
        //        .Property(e => e.invstat_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvoiceStatu>()
        //        .HasMany(e => e.Invoices)
        //        .WithRequired(e => e.InvoiceStatu)
        //        .HasForeignKey(e => e.inv_status)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<InvoiceTerm>()
        //        .Property(e => e.term_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<InvoiceTerm>()
        //        .HasMany(e => e.Invoices)
        //        .WithRequired(e => e.InvoiceTerm)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<MemberQtlySel>()
        //        .Property(e => e.mqs_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MemberQtlySel>()
        //        .Property(e => e.mqs_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<MemberQtlySel>()
        //        .HasMany(e => e.MemberQtlySel_detail)
        //        .WithRequired(e => e.MemberQtlySel)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<MemberQtlySel_detail>()
        //        .Property(e => e.mqs_quantity)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Payment_Types>()
        //        .Property(e => e.pay_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Payment_Types>()
        //        .HasMany(e => e.InvoicePayments)
        //        .WithRequired(e => e.Payment_Types)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Payment_Types>()
        //        .HasMany(e => e.PaymentRegisters)
        //        .WithRequired(e => e.Payment_Types)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Payment_Types>()
        //        .HasMany(e => e.PRBatches)
        //        .WithRequired(e => e.Payment_Types)
        //        .HasForeignKey(e => e.prbch_paymenttype)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.pr_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.pr_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.pr_balance)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.pay_otherinfo)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.updatedby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PaymentRegister>()
        //        .Property(e => e.echarge_confno)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Phone_Types>()
        //        .Property(e => e.pht_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Phone_Types>()
        //        .HasMany(e => e.Clients_Phones)
        //        .WithRequired(e => e.Phone_Types)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PhoneType>()
        //        .Property(e => e.pho_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRBatch>()
        //        .Property(e => e.prbch_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRBatch>()
        //        .Property(e => e.prbch_createdby)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRBatch>()
        //        .Property(e => e.prbch_otherinfo)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRBatch>()
        //        .Property(e => e.prbch_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<PRBatch>()
        //        .HasMany(e => e.PRBatchesDetails)
        //        .WithRequired(e => e.PRBatch)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PRBatchesDetail>()
        //        .Property(e => e.cc_charge_msg)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<PRBatchesDetail>()
        //        .Property(e => e.cc_charge_refid)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_barcode)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_price)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_cost)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_reorder)
        //        .HasPrecision(10, 2);

        //    modelBuilder.Entity<Product>()
        //        .Property(e => e.prod_price_ws)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Product>()
        //        .HasMany(e => e.Discounts_Products)
        //        .WithRequired(e => e.Product)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Product>()
        //        .HasMany(e => e.Inventories)
        //        .WithRequired(e => e.Product)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Product>()
        //        .HasMany(e => e.InvoicesDetails)
        //        .WithRequired(e => e.Product)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Product>()
        //        .HasMany(e => e.MemberQtlySel_detail)
        //        .WithRequired(e => e.Product)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<PurchaseOrder>()
        //        .Property(e => e.po_discount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<StateTax>()
        //        .Property(e => e.st_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<StateTax>()
        //        .Property(e => e.st_tax)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Stock>()
        //        .Property(e => e.stk_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Stock>()
        //        .Property(e => e.stk_notes)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Stock>()
        //        .HasMany(e => e.Inventories)
        //        .WithRequired(e => e.Stock)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Stock>()
        //        .HasMany(e => e.InventoryAdjustments)
        //        .WithRequired(e => e.Stock)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<SystemObject>()
        //        .Property(e => e.obj_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SystemObject>()
        //        .Property(e => e.obj_url)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SystemObject>()
        //        .Property(e => e.obj_image)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SystemObject>()
        //        .HasMany(e => e.GroupPermissions)
        //        .WithRequired(e => e.SystemObject)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Unit>()
        //        .Property(e => e.unit_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Unit>()
        //        .Property(e => e.unit_volume)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UserMemberOf>()
        //        .Property(e => e.grp_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UserMemberOf>()
        //        .Property(e => e.usr_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.usr_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.usr_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .Property(e => e.usr_password)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<User>()
        //        .HasMany(e => e.UserMemberOfs)
        //        .WithRequired(e => e.User)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<User>()
        //        .HasMany(e => e.UserPermissions)
        //        .WithRequired(e => e.User)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Widget>()
        //        .Property(e => e.wid_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Widget>()
        //        .HasMany(e => e.WidgetsPermissions)
        //        .WithRequired(e => e.Widget)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<WidgetsPermission>()
        //        .Property(e => e.grp_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Client_Credits>()
        //        .Property(e => e.cr_amount)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<Client_Credits>()
        //        .Property(e => e.cr_balance)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<UserPermission>()
        //        .Property(e => e.obj_id)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<UserPermission>()
        //        .Property(e => e.usr_id)
        //        .IsUnicode(false);
        //}
    }
}
