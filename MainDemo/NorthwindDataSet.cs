namespace MainDemo
{


  partial class NorthwindDataSet
  {
    public void LoadOrders()
    {
      DataSetXmlHelper.LoadTable(Orders, "Northwind.Orders.xml");
    }

    public void LoadEmployees()
    {
      DataSetXmlHelper.LoadTable(Employees, "Northwind.Employees.xml");
    }

    public void LoadCustomers()
    {
      DataSetXmlHelper.LoadTable(Customers, "Northwind.Customers.xml");
    }

    public void LoadShippers()
    {
      DataSetXmlHelper.LoadTable(Shippers, "Northwind.Shippers.xml");
    }

    public void LoadOrderDetails()
    {
      DataSetXmlHelper.LoadTable(Order_Details, "Northwind.Order_Details.xml");
    }

    public void LoadProducts()
    {
      DataSetXmlHelper.LoadTable(Products, "Northwind.Products.xml");
    }

    public void LoadCategories()
    {
      DataSetXmlHelper.LoadTable(Categories, "Northwind.Categories.xml");
    }

    partial class OrdersDataTable
    {
    }

    partial class PolyCellColumnTableDataTable
    {
    }
  }
}
