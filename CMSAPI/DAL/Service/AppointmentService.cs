using EndocPM.WebAPI;
using HMS.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Xml;

namespace HMS
{
    public class AppointmentService : IAppointmentService
    {
        public readonly IUnitOfWork _uow;

        public readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IConfiguration _configuration;


        public AppointmentService(IUnitOfWork uow, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {

            _uow = uow;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;


        }

        //public MedicationMasterList addupdateMedicationMaster(MedicationMasterList model)
        //{

        //    var master = this._uow.GenericRepository<MedicationMaster>().Table().Where(x => x.MedicationCode == model.MedicationCode && x.MedicationName == model.MedicationName).FirstOrDefault();

        //    if(master == null)
        //    {
        //        master = new MedicationMaster();

        //        master.MedicationCode = model.MedicationCode;
        //        master.MedicationName = model.MedicationName;
        //        master.Stock = model.Stock;
        //        master.GST = model.GST;
        //        master.CostPrice = model.CostPrice;
        //        master.ExpiryDate = model.ExpiryDate;
        //        master.SellingPrice = model.SellingPrice;
        //        master.MedicationType = model.MedicationType;
        //        master.Strength = model.Strength;
        //        master.Category = model.Category;
        //        master.Composition = model.Composition;
        //        master.ShelfLocation = model.ShelfLocation;
        //        master.Barcode = model.Barcode;
        //        master.BatchNumber = model.BatchNumber;
        //        master.Supplier = model.Supplier;
        //        master.Status = model.Status;
        //        master.GenericName = model.GenericName;


        //        this._uow.GenericRepository<MedicationMaster>().Insert(master);
        //        this._uow.Save();
        //    }
        //    else
        //    {
                
        //        master.MedicationCode = model.MedicationCode;
        //        master.MedicationName = model.MedicationName;
        //        master.Stock = model.Stock;
        //        master.GST = model.GST;
        //        master.CostPrice = model.CostPrice;
        //        master.ExpiryDate = model.ExpiryDate;
        //        master.SellingPrice = model.SellingPrice;
        //        master.MedicationType = model.MedicationType;
        //        master.Strength = model.Strength;
        //        master.Category = model.Category;
        //        master.Composition = model.Composition;
        //        master.ShelfLocation = model.ShelfLocation;
        //        master.Barcode = model.Barcode;
        //        master.BatchNumber = model.BatchNumber;
        //        master.Supplier = model.Supplier;
        //        master.Status = model.Status;
        //        master.GenericName = model.GenericName;

        //        this._uow.GenericRepository<MedicationMaster>().Update(master);
        //        this._uow.Save();
        //    }
        //    return model;

        //}


        //public List<MedicationMaster> GetMedicationMastersearchkey(string Searchkey)
        //{
        //    List<MedicationMaster> codes = (from c in this._uow.GenericRepository<MedicationMaster>().Table()
        //                               where (Searchkey == null || (c.MedicationCode.ToLower().Trim().Contains(Searchkey.ToLower().Trim()) || c.MedicationName.ToLower().Trim().Contains(Searchkey.ToLower().Trim())))
        //                               select c).Take(50).ToList();
        //    return codes;
        //}


        //public MedicationMasterModel calculateMedicationMaster(MedicationMasterModel model)
        //{
        //    var customername = _uow.GenericRepository<Customer>().Table().Where(x => x.FullName == model.customername && x.Phone == model.phonenumber).FirstOrDefault();

        //    if (customername == null)
        //    {
        //        customername = new Customer();

        //        customername.FullName = model.customername;
        //        customername.Phone = model.phonenumber;

        //        this._uow.GenericRepository<Customer>().Insert(customername);
        //        this._uow.Save();


        //    }
        //    else
        //    {
        //        customername.FullName = model.customername;
        //        customername.Phone = model.phonenumber;

        //        this._uow.GenericRepository<Customer>().Update(customername);
        //        this._uow.Save();

        //    }

        //    var CartCustomers = this._uow.GenericRepository<Customer>().Table().Where(x=> x.Phone == model.phonenumber).FirstOrDefault();
        //    if (CartCustomers != null)
        //    {

                
        //        foreach(var cart in model.cartCustomers)
        //        {
        //            var cust = new CartCustomer();

        //            cust.SubtotalCast = cart.SubtotalCast;
        //            cust.totalCast = cart.totalCast;
        //            cust.CustomerNumber = CartCustomers.Phone;
        //            cust.CreateDate = DateTime.Now;
        //            this._uow.GenericRepository<CartCustomer>().Insert(cust);
        //            this._uow.Save();

        //        }


        //        foreach (var item in model.salesReports)
        //        {

        //            var sales = new SalesReport();

        //            sales.Sales = item.Sales;
        //            sales.CustomerId = CartCustomers.Phone;
        //            sales.CreateDate = DateTime.Now;
        //            this._uow.GenericRepository<SalesReport>().Insert(sales);
        //            this._uow.Save();


        //        }

        //        foreach (var medic in model.medicationReports)
        //        {
        //            var medic2 = new MedicationReport();

        //            medic2.MedicationCode = medic.MedicationCode;
        //            medic2.MedicationName = medic.MedicationName;
        //            medic2.customerID = CartCustomers.Phone;
        //            medic2.CreateDate = DateTime.Now;
        //            this._uow.GenericRepository<MedicationReport>().Insert(medic2);
        //            this._uow.Save();
        //        }

        //    }

        //    if (model.medicationCountLists != null)
        //    {


        //        foreach( var list in model.medicationCountLists )
        //        {

        //            var medicationcount = _uow.GenericRepository<MedicationMaster>().Table().Where(x => x.MedicationCode == list.MedicationCode && x.GenericName == list.MedicationName).FirstOrDefault();

        //            if (medicationcount != null)
        //            {
        //                int countMedi = 0;

                       
        //               int conut = medicationcount.Stock - list.MedicationCount;

        //                if(conut != null)
        //                {
        //                    var medic = this._uow.GenericRepository<MedicationMaster>().Table().Where(x => x.MedicationCode == medicationcount.MedicationCode && x.MedicationName == medicationcount.MedicationName).FirstOrDefault();

        //                    if (medic != null)
        //                    {
        //                        medic.Stock = conut;
        //                        this._uow.GenericRepository<MedicationMaster>().Update(medic);
        //                        this._uow.Save();
        //                    }    
        //                }

        //            }



        //        }

        //          model.Sucess = "sucessfully";

        //    }
        //    return model;



        //}

        //public List<MedicationMasterList> GetMedicationMasterTolist()
        //{
        //    var mastermed = (from a in _uow.GenericRepository<MedicationMaster>().Table()
        //                     where a.IsDeleted == false
        //                     select new MedicationMasterList
        //                     {
        //                         MedicationID = a.MedicationID,
        //                         MedicationCode = a.MedicationCode,
        //                         MedicationName = a.MedicationName,
        //                         Strength = a.Strength,
        //                         MedicationType = a.MedicationType,
        //                         GenericName = a.GenericName,
        //                         CostPrice = a.CostPrice,
        //                         SellingPrice = a.SellingPrice,
        //                         Stock = a.Stock,
        //                         GST = a.GST,
        //                         ExpiryDate = a.ExpiryDate,
        //                         IsDeleted = a.IsDeleted,
        //                         ManufacturingDate = a.ManufacturingDate,
        //                         Category = a.Category,
        //                         Composition = a.Composition,
        //                         ShelfLocation = a.ShelfLocation,
        //                         Barcode = a.Barcode,
        //                         BatchNumber = a.BatchNumber,
        //                         Supplier = a.Supplier,
        //                         Status = a.Status
        //                     }).ToList();

        //    return mastermed;



        //}

        //public List<ProductTypeMaster> getProductType()
        //{
        //    var types = this._uow.GenericRepository<ProductTypeMaster>().Table().ToList();

        //    return types;
        //}

        //public List<GSTmaster> GetGSTmasters()
        //{
        //    var master = this._uow.GenericRepository<GSTmaster>().Table().ToList();

        //    return master;

        //}

        //public List<MedicationMasterModel> MedicationMasterExpiryDate()
        //{
        //    DateTime today = DateTime.Now;

        //    var master = (from a in this._uow.GenericRepository<MedicationMaster>()
        //                  .Table()
        //                  .Where(x => x.IsDeleted != true)
        //                  select new
        //                  {
        //                      a.CostPrice,
        //                      a.MedicationID,
        //                      a.MedicationCode,
        //                      a.MedicationName,
        //                      a.ExpiryDate,
        //                      a.MedicationType,
        //                      a.SellingPrice,
        //                      a.GST,
        //                      a.Strength,
        //                      a.Stock,
        //                      a.IsDeleted
        //                  })
        //                  .AsEnumerable()
        //                  .Select(x => new MedicationMasterModel
        //                  {
        //                      CostPrice = x.CostPrice,
        //                      MedicationID = x.MedicationID,
        //                      MedicationCode = x.MedicationCode,
        //                      MedicationName = x.MedicationName,
        //                      ExpiryDate = x.ExpiryDate,
        //                      MedicationType = x.MedicationType,
        //                      SellingPrice = x.SellingPrice,
        //                      GST = x.GST,
        //                      Strength = x.Strength,
        //                      Stock = x.Stock,
        //                      IsDeleted = x.IsDeleted,

        //                      // Calculate remaining days to expiry
        //                      WarningDate = (x.ExpiryDate - today).Days,

        //                      // Add expiry alert message
        //                      ExpiryStatus = (x.ExpiryDate - today).Days <= 20
        //                                     ? "Expiring Soon"
        //                                     : $" {(x.ExpiryDate - today).Days} days left"
        //                  }) .Where(x=> x.WarningDate <= 20)
        //                  .ToList();


        //    return master;
        //}


        //public List<Status> statusGetall()
        //{
        //    var listing = this._uow.GenericRepository<Status>().Table().ToList();


        //    return listing;
        //}

        //public List<Supplier> getallSupplier()
        //{
        //    var supplier = this._uow.GenericRepository<Supplier>().Table().ToList();

        //    return supplier;
        //}

        //public List<Category> getallCategory()
        //{
        //    var category = this._uow.GenericRepository<Category>().Table().ToList();

        //    return category;
        //}


        //public SupplierModel AddupdateSupplier(SupplierModel supplier)
        //{
        //    var supplierlist = this._uow.GenericRepository<Supplier>().Table().Where(x => x.SupplierPhone == supplier.SupplierPhone && x.SupplierName == supplier.SupplierName).FirstOrDefault();

        //    if(supplierlist == null)
        //    {
        //        supplierlist = new Supplier();

        //        supplierlist.SupplierAddress = supplier.SupplierAddress;
        //        supplierlist.SupplierPhone = supplier.SupplierPhone;
        //        supplierlist.SupplierName = supplier.SupplierName;
        //        supplierlist.SupplierDelete = true;
        //        supplierlist.ContactPerson = supplier.ContactPerson;
        //        supplierlist.GSTIN = supplier.GSTIN;
        //        supplier.PaymentTerms = supplier.PaymentTerms;
        //        supplierlist.Email =supplier.Email;
        //        supplierlist.CreateDate = DateTime.Now;
        //        supplier.CreateBy = "admin";

        //        this._uow.GenericRepository<Supplier>().Insert(supplierlist);
        //        this._uow.Save();
        //    }
        //    else
        //    {

        //        supplierlist.SupplierAddress = supplier.SupplierAddress;
        //        supplierlist.SupplierPhone = supplier.SupplierPhone;
        //        supplierlist.SupplierName = supplier.SupplierName;
        //        supplierlist.SupplierDelete = true;
        //        supplierlist.ContactPerson = supplier.ContactPerson;
        //        supplierlist.GSTIN = supplier.GSTIN;
        //        supplier.PaymentTerms = supplier.PaymentTerms;
        //        supplierlist.Email = supplier.Email;
        //        supplierlist.CreateDate = DateTime.Now;
        //        this._uow.GenericRepository<Supplier>().Update(supplierlist);
        //        this._uow.Save();


        //    }
        //    return supplier;
        //}




        //public List<MedicationMasterModel> MedicationMasterLowStock()
        //{
        //    var today = DateTime.Today;
        //    var master = (from a in this._uow.GenericRepository<MedicationMaster>().Table()
        //                  where a.IsDeleted != true
        //                  select new
        //                  {
        //                      a.CostPrice,
        //                      a.MedicationID,
        //                      a.MedicationCode,
        //                      a.MedicationName,
        //                      a.ExpiryDate,
        //                      a.MedicationType,
        //                      a.SellingPrice,
        //                      a.GST,
        //                      a.Strength,
        //                      a.Stock,
        //                      a.IsDeleted
        //                  })
        //         .AsEnumerable()
        //         .Select(x => new MedicationMasterModel
        //         {
        //             CostPrice = x.CostPrice,
        //             MedicationID = x.MedicationID,
        //             MedicationCode = x.MedicationCode,
        //             MedicationName = x.MedicationName,
        //             ExpiryDate = x.ExpiryDate,
        //             MedicationType = x.MedicationType,
        //             SellingPrice = x.SellingPrice,
        //             GST = x.GST,
        //             Strength = x.Strength,
        //             Stock = x.Stock,
        //             IsDeleted = x.IsDeleted,
        //             lowStock = x.Stock <= 30 ? "Low Stock" : "In Stock"
        //         })
        //         .Where(x => x.Stock <= 30)
        //         .ToList();

        //    return master;
        //}


        //public List<SalesReportModel> homesalesReport()
        //{

        //    List<SalesReportModel> list = new List<SalesReportModel>();
        //    DateTime today = DateTime.Today;
        //    var firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
        //    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

        //    var listing = this._uow.GenericRepository<Customer>()
        //                .Table()
        //                .Count(x => !string.IsNullOrEmpty(x.FullName));
        //    var salesOneDayAmount = _uow.GenericRepository<SalesReport>()
        //      .Table()
        //        .Where(x => x.CreateDate.Date == today)
        //      .AsEnumerable() // switch to in-memory (for conversion)
        //    .Sum(x => decimal.TryParse(x.Sales, out var val) ? val : 0);

        //    var salesOneMonthAmount = _uow.GenericRepository<SalesReport>()
        //  .Table()
        //  .Where(x => x.CreateDate >= firstDayOfMonth && x.CreateDate <= lastDayOfMonth)
        //  .AsEnumerable()
        //   .Sum(x => decimal.TryParse(x.Sales ?? "0", out var val) ? val : 0);

        //    SalesReportModel Modellist = new SalesReportModel();

        //    Modellist.totalcustomer = listing;
        //    Modellist.todaySales = salesOneDayAmount;
        //    Modellist.onemonths = salesOneMonthAmount;


        //    list.Add(Modellist);


        //    return list;



        //}

















    }
}
